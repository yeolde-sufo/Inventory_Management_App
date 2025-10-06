namespace InventoryManagementApp
{
    public partial class InventoryMangementForm : Form
    {
        private List<Product> products = new List<Product>();

        public InventoryMangementForm()
        {
            InitializeComponent();
        }

        // Adding new products to the data grid view table.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Get input values
                string name = txtName.Text;
                string description = richTxtDescription.Text;
                string category = cboxCategory.Text;
                string imagePath = picBoxProduct.Tag as string ?? string.Empty;
                int productId = int.Parse(txtProductId.Text);
                int quantity = int.Parse(txtQuantity.Text);
                decimal price = decimal.Parse(txtPrice.Text);

                // Create new product
                Product p = new Product(name, category, description, productId, quantity, price, imagePath);
                products.Add(p);
                // Update ListBox
                UpdateProductList();
                // Clear TextBoxes
                txtName.Clear();
                cboxCategory.SelectedIndex = -1;
                richTxtDescription.Clear();
                txtProductId.Clear();
                txtQuantity.Clear();
                txtPrice.Clear();
                picBoxProduct.Image = null;
                picBoxPreviewProduct.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product: {ex.Message}");
            }
        }

        // Refresh the DataGridView to show current inventory
        private void UpdateProductList()
        {
            dataGridViewInventory.Rows.Clear();
            foreach (Product p in products)
            {
                dataGridViewInventory.Rows.Add(false, p.Name, p.Category, p.Quantity, p.Price.ToString("C"), p.ProductId, p.Description);
            }
            // Restore selection if possible
            if (products.Count > 0)
            {
                dataGridViewInventory.Rows[0].Selected = true;
            }
            else
            {
                ClearProductDetails();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Collect indices to remove (in reverse order to avoid shifting)
            var indicesToRemove = new List<int>();
            for (int i = dataGridViewInventory.Rows.Count - 1; i >= 0; i--)
            {
                var row = dataGridViewInventory.Rows[i];
                if (row.Cells["ColSelect"].Value is bool isChecked && isChecked)
                {
                    indicesToRemove.Add(i);
                }
            }

            // Remove from products list and DataGridView
            foreach (int i in indicesToRemove)
            {
                if (i >= 0 && i < products.Count)
                    products.RemoveAt(i);
            }
            UpdateProductList();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // File Types for Images
            openFileDialog1.Title = "Select your product image."; // Dialog Title
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;
                try
                {
                    picBoxProduct.Image = Image.FromFile(imagePath);
                    picBoxPreviewProduct.Image = Image.FromFile(imagePath);
                    MessageBox.Show("Image loaded successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}");
                }
                picBoxProduct.Tag = imagePath;

                // Associate image path with selected product
                int selectedIndex = dataGridViewInventory.SelectedRows.Count > 0 ? dataGridViewInventory.SelectedRows[0].Index : -1;
                if (selectedIndex >= 0 && selectedIndex < products.Count)
                {
                    products[selectedIndex].ImagePath = imagePath;
                }
            }
        }
        private void ClearProductDetails()
        {
            picBoxProduct.Image = null;
            picBoxPreviewProduct.Image = null;
            lblNameDetail.Text = "Name:";
            lblCategoryDetail.Text = "Category:";
            lblDescriptionDetail.Text = "Description:";
            lblPriceDetail.Text = "Price:";
            lblQuantityDetail.Text = "Quantity:";
            lblProductIDDetail.Text = "Product ID:";
        }

        // Load selected product details into input fields for editing
        private void LoadSelectedProductToInputs()
        {
            if (dataGridViewInventory.SelectedRows.Count > 0)
            {
                int index = dataGridViewInventory.SelectedRows[0].Index;
                if (index >= 0 && index < products.Count)
                {
                    Product selectedProduct = products[index];
                    txtName.Text = selectedProduct.Name;
                    cboxCategory.Text = selectedProduct.Category;
                    richTxtDescription.Text = selectedProduct.Description;
                    txtProductId.Text = selectedProduct.ProductId.ToString();
                    txtQuantity.Text = selectedProduct.Quantity.ToString();
                    txtPrice.Text = selectedProduct.Price.ToString();
                    picBoxProduct.Tag = selectedProduct.ImagePath;
                    if (!string.IsNullOrEmpty(selectedProduct.ImagePath) && File.Exists(selectedProduct.ImagePath))
                    {
                        picBoxProduct.Image = Image.FromFile(selectedProduct.ImagePath);
                        picBoxPreviewProduct.Image = Image.FromFile(selectedProduct.ImagePath);
                    }
                    else
                    {
                        picBoxProduct.Image = null;
                        picBoxPreviewProduct.Image = null;
                    }
                }
            }
        }

        // Edit the selected product with new values from input fields
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewInventory.SelectedRows.Count > 0)
            {
                int index = dataGridViewInventory.SelectedRows[0].Index;
                if (index >= 0 && index < products.Count)
                {
                    try
                    {
                        // Update the selected product with new values
                        Product selectedProduct = products[index];
                        selectedProduct.Name = txtName.Text;
                        selectedProduct.Category = cboxCategory.Text;
                        selectedProduct.Description = richTxtDescription.Text;
                        selectedProduct.ProductId = int.Parse(txtProductId.Text);
                        selectedProduct.Quantity = int.Parse(txtQuantity.Text);
                        selectedProduct.Price = decimal.Parse(txtPrice.Text);
                        selectedProduct.ImagePath = picBoxProduct.Tag as string ?? string.Empty;

                        UpdateProductList();
                        ClearProductDetails();
                        MessageBox.Show("Product updated successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating product: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to edit.");
            }
        }

        private Product? GetSelectedProduct()
        {
            if (dataGridViewInventory.SelectedRows.Count > 0)
            {
                var row = dataGridViewInventory.SelectedRows[0];
                // Assuming ProductId is in column 5 (adjust if needed)
                int productId = Convert.ToInt32(row.Cells[5].Value);
                return products.FirstOrDefault(p => p.ProductId == productId);
            }
            return null;
        }

        private void dataGridViewInventory_SelectionChanged(object sender, EventArgs e)
        {
            var selectedProduct = GetSelectedProduct();
            if (selectedProduct != null)
            {
                lblNameDetail.Text = $"Name: {selectedProduct.Name}";
                lblCategoryDetail.Text = $"Category: {selectedProduct.Category}";
                lblDescriptionDetail.Text = $"Description: {selectedProduct.Description}";
                lblPriceDetail.Text = $"Price: {selectedProduct.Price:C}";
                lblQuantityDetail.Text = $"Quantity: {selectedProduct.Quantity}";
                lblProductIDDetail.Text = $"Product ID: {selectedProduct.ProductId}";

                if (!string.IsNullOrEmpty(selectedProduct.ImagePath) && File.Exists(selectedProduct.ImagePath))
                {
                    picBoxProduct.Image = Image.FromFile(selectedProduct.ImagePath);
                }
                else
                {
                    picBoxProduct.Image = null;
                }
            }
            else
            {
                ClearProductDetails();
            }
        }
    }
}


