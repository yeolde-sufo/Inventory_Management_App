namespace InventoryManagementApp
{
    public partial class InventoryMangementForm : Form
    {
        private List<Product> products = new List<Product>();

        public InventoryMangementForm()
        {
            InitializeComponent();
        }

        private void lstProductInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstProductInventory.SelectedIndex;
            if (selectedIndex >= 0)
            {

                var product = products[selectedIndex];

                lblNameDetail.Text = $"Name: {product.Name}";
                lblCategoryDetail.Text = $"Category: {product.Category}";
                lblDescriptionDetail.Text = $"Description: {product.Description}";
                lblPriceDetail.Text = $"Price: {product.Price:C}";
                lblQuantityDetail.Text = $"Quantity: {product.Quantity}";
                lblProductIDDetail.Text = $"Product ID: {product.ProductId}";

                // Load and display image if path is valid
                if (!string.IsNullOrEmpty(product.ImagePath) && File.Exists(product.ImagePath))
                {
                    picBoxProduct.Image = Image.FromFile(product.ImagePath);
                }
                else
                {
                    picBoxProduct.Image = null; // Or set a default image
                }
            }
            else
            {
                ClearProductDetails();
            }
        }

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

        private void UpdateProductList()
        {
            int prevIndex = lstProductInventory.SelectedIndex;
            lstProductInventory.Items.Clear();
            foreach (Product p in products)
            {
                lstProductInventory.Items.Add(p.ToString());
            }
            // Restore selection if possible
            if (products.Count > 0)
            {
                lstProductInventory.SelectedIndex = Math.Min(prevIndex, products.Count - 1);
            }
            else
            {
                ClearProductDetails();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int prevIndex = lstProductInventory.SelectedIndex;
            if (prevIndex >= 0)
            {
                products.RemoveAt(prevIndex);
                UpdateProductList();
                // Restore selection if possible
                if (products.Count > 0)
                {
                    lstProductInventory.SelectedIndex = Math.Min(prevIndex, products.Count - 1);
                }
                else
                {
                    ClearProductDetails();
                }
            }
            else
            {
                MessageBox.Show("Select a product to remove.");
            }
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
                int selectedIndex = lstProductInventory.SelectedIndex;
                if (selectedIndex >= 0 && selectedIndex < products.Count)
                {
                    products[selectedIndex].ImagePath = imagePath;
                }
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


