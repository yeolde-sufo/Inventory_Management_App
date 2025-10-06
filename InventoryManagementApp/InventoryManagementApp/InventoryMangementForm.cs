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
            openFileDialog1.Title = "Select a Profile Image"; // Dialog Title
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;
                try
                {
                    picBoxProduct.Image = Image.FromFile(imagePath);
                    MessageBox.Show("Image loaded successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}");
                }
                picBoxProduct.Tag = imagePath;

                // Associate image path with selected product
                //int selectedIndex = dataGridViewInventory
                //if (selectedIndex >= 0 && selectedIndex < products.Count)
                //{
                    //products[selectedIndex].ImagePath = imagePath;
                //}
            }
        }
        private void ClearProductDetails()
        {
            picBoxProduct.Image = null;
            lblNameDetail.Text = "Name:";
            lblCategoryDetail.Text = "Category:";
            lblDescriptionDetail.Text = "Description:";
            lblPriceDetail.Text = "Price:";
            lblQuantityDetail.Text = "Quantity:";
            lblProductIDDetail.Text = "Product ID:";
        }
    }
}


