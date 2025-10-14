using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;



namespace InventoryManagementApp
{
    public partial class InventoryMangementForm : Form
    {
        private List<Product> products = new List<Product>();

        public InventoryMangementForm()
        {
            InitializeComponent();
            nudQuantity.Minimum = 1;
            LoadProductsFromDb();
            LoadDonorsFromDb();
        }

        // Adding new products to the data grid view table.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string category = cboxCategory.Text;
                string imagePath = picBoxProduct.Tag as string ?? string.Empty;
                string size = cboxSize.SelectedItem?.ToString() ?? string.Empty;
                int quantity = (int)nudQuantity.Value;
                DateTime date = dtpDate.Value;

                Product p = new Product(name, category, imagePath)
                {
                    Size = size,
                    Quantity = quantity,
                    Date = date
                };

                // Add to database
                string connectionString = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Products (Name, Category, ImagePath, Size, Quantity, Date) VALUES (@Name, @Category, @ImagePath, @Size, @Quantity, @Date)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", p.Name);
                        cmd.Parameters.AddWithValue("@Category", p.Category);
                        cmd.Parameters.AddWithValue("@ImagePath", p.ImagePath);
                        cmd.Parameters.AddWithValue("@Size", p.Size);
                        cmd.Parameters.AddWithValue("@Quantity", p.Quantity);
                        cmd.Parameters.AddWithValue("@Date", p.Date);
                        cmd.ExecuteNonQuery();
                    }
                }

                products.Add(p);
                UpdateProductList();

                txtName.Clear();
                cboxCategory.SelectedIndex = -1;
                cboxSize.SelectedIndex = -1;
                dtpDate.Value = DateTime.Now;
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
                dataGridViewInventory.Rows.Add(
                    false,
                    p.Name,
                    p.Category,
                    p.Size,
                    p.Quantity,
                    p.Date.ToShortDateString()
                );
            }
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
            if (dataGridViewInventory.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewInventory.SelectedRows[0].Index;
                if (selectedIndex >= 0 && selectedIndex < products.Count)
                {
                    // Remove from database
                    string connectionString = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Products WHERE Name=@Name";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", products[selectedIndex].Name);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    products.RemoveAt(selectedIndex);
                    UpdateProductList();
                }
            }
            else
            {
                MessageBox.Show("Please select a product to remove.");
            }
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
            lblDateDetail.Text = "Price:";
            lblQuantityDetail.Text = "Quantity:";
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
                    cboxSize.SelectedItem = selectedProduct.Size;
                    nudQuantity.Value = selectedProduct.Quantity;
                    dtpDate.Value = selectedProduct.Date;
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
                        Product selectedProduct = products[index];
                        selectedProduct.Name = txtName.Text;
                        selectedProduct.Category = cboxCategory.Text;
                        selectedProduct.Size = cboxSize.SelectedItem?.ToString() ?? string.Empty;
                        selectedProduct.Quantity = (int)nudQuantity.Value;
                        selectedProduct.Date = dtpDate.Value;
                        selectedProduct.ImagePath = picBoxProduct.Tag as string ?? string.Empty;

                        // Update in database
                        string connectionString = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = "UPDATE Products SET Category=@Category, ImagePath=@ImagePath, Size=@Size, Quantity=@Quantity, Date=@Date WHERE Name=@Name";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@Name", selectedProduct.Name);
                                cmd.Parameters.AddWithValue("@Category", selectedProduct.Category);
                                cmd.Parameters.AddWithValue("@ImagePath", selectedProduct.ImagePath);
                                cmd.Parameters.AddWithValue("@Size", selectedProduct.Size);
                                cmd.Parameters.AddWithValue("@Quantity", selectedProduct.Quantity);
                                cmd.Parameters.AddWithValue("@Date", selectedProduct.Date);
                                cmd.ExecuteNonQuery();
                            }
                        }

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
                int index = dataGridViewInventory.SelectedRows[0].Index;
                if (index >= 0 && index < products.Count)
                {
                    return products[index];
                }
            }
            return null;
        }

        private static readonly string[] FunFacts = new[]
        {
            "Fun Fact: Recycling helps reduce the need to extract, refine, and process raw materials like timber, oil, and minerals, which cause significant air and water pollution. By reusing materials such as aluminum, glass, paper, and plastics, recycling conserves the planet’s limited natural resources and decreases greenhouse gas emissions. For example, recycling one ton of paper saves around 17 trees and 7,000 gallons of water, while recycling metals like aluminum can reduce energy use by up to 95% compared to producing new metal from ore.",
            "Fun Fact: Beyond its environmental impact, recycling supports a growing green economy. The recycling and reuse industry employs millions of people worldwide in collection, sorting, processing, and manufacturing sectors. In the United States alone, recycling activities contribute hundreds of thousands of jobs and billions of dollars in wages and tax revenues each year. Investing in recycling infrastructure not only benefits the planet but also stimulates innovation and sustainable economic growth.",
            "Fun Fact: Many people don’t realize that improper recycling, such as placing food-stained containers, non-recyclable plastics, or mixed materials in recycling bins, can contaminate entire batches of recyclable waste. Contamination increases processing costs and often causes materials to be diverted to landfills instead. Proper sorting, rinsing, and understanding of local recycling rules are essential to ensure that the materials we recycle truly get a second life."
        };

        private void dataGridViewInventory_SelectionChanged(object sender, EventArgs e)
        {
            var selectedProduct = GetSelectedProduct();
            if (selectedProduct != null)
            {
                lblNameDetail.Text = $"Name: {selectedProduct.Name}";
                lblCategoryDetail.Text = $"Category: {selectedProduct.Category}";
                lblQuantityDetail.Text = $"Quantity: {selectedProduct.Quantity}";
                lblSizeDetail.Text = $"Size: {selectedProduct.Size}";
                lblDateDetail.Text = $"Date: {selectedProduct.Date.ToShortDateString()}";

                // Display a random fun fact
                var random = new Random();
                int factIndex = random.Next(FunFacts.Length);
                lblFactDetail.Text = FunFacts[factIndex];

                if (!string.IsNullOrEmpty(selectedProduct.ImagePath) && File.Exists(selectedProduct.ImagePath))
                {
                    if (picBoxProduct.Image != null)
                    {
                        picBoxProduct.Image.Dispose();
                        picBoxProduct.Image = null;
                    }
                            //picBoxProduct.Image = Image.FromFile(selectedProduct.ImagePath);
                }
                else
                {
                    //picBoxProduct.Image = null;
                }
            }
            else
            {
                ClearProductDetails();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDonateDonate_Click(object sender, EventArgs e)
{
    string donorName = textNameDonate.Text.Trim();
    decimal amount = nudAmntDonate.Value;
    string cardNumber = mtboxCardDonate.Text.Trim();
    string csv = mtboxCSVDonate.Text.Trim();

    // Validation
    if (string.IsNullOrEmpty(donorName))
    {
        MessageBox.Show("Please enter your name.");
        return;
    }
    if (amount <= 0)
    {
        MessageBox.Show("Please enter a valid donation amount.");
        return;
    }
    if (!IsValidCardNumber(cardNumber))
    {
        MessageBox.Show("Please enter a valid card number (16 digits).");
        return;
    }
    if (!IsValidCSV(csv))
    {
        MessageBox.Show("Please enter a valid CSV (3 digits).");
        return;
    }

    // Add to database
    AddDonorToDb(donorName, amount, cardNumber, csv);

    // Add to donors list
    lboxDonorsDonate.Items.Add($"{donorName} - ${amount}");

    // Optionally clear fields after successful donation
    textNameDonate.Clear();
    nudAmntDonate.Value = nudAmntDonate.Minimum;
    mtboxCardDonate.Clear();
    mtboxCSVDonate.Clear();

    MessageBox.Show("Thank you for your donation!");
}

        // Helper methods for validation
        private bool IsValidCardNumber(string card)
        {
            return mtboxCardDonate.MaskFull;
        }

        private bool IsValidCSV(string csv)
        {
            return mtboxCSVDonate.MaskFull;
        }

        private void AddDonorToDb(string name, decimal amount, string cardNumber, string csv)
{
    string connectionString = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;
    using (SqlConnection conn = new SqlConnection(connectionString))
    {
        conn.Open();
        string query = "INSERT INTO Donors (Name, Amount) VALUES (@Name, @Amount)";
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Amount", amount);
            cmd.ExecuteNonQuery();
        }
    }
}

private void EditDonorInDb(string oldName, string newName, decimal amount, string cardNumber, string csv)
{
    string connectionString = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;
    using (SqlConnection conn = new SqlConnection(connectionString))
    {
        conn.Open();
        string query = "UPDATE Donors SET Name=@NewName, Amount=@Amount WHERE Name=@OldName";
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@NewName", newName);
            cmd.Parameters.AddWithValue("@Amount", amount);
            cmd.Parameters.AddWithValue("@OldName", oldName);
            cmd.ExecuteNonQuery();
        }
    }
}

private void RemoveDonorFromDb(string name)
{
    string connectionString = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;
    using (SqlConnection conn = new SqlConnection(connectionString))
    {
        conn.Open();
        string query = "DELETE FROM Donors WHERE Name=@Name";
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.ExecuteNonQuery();
        }
    }
}

        public void LoadProductsFromDb()
        {
            products.Clear();
            string connectionString = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Name, Category, ImagePath, Size, Quantity, Date FROM Products";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new Product(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2))
                        {
                            Size = reader.GetString(3),
                            Quantity = reader.GetInt32(4),
                            Date = reader.GetDateTime(5)
                        };
                        products.Add(product);
                    }
                }
            }
            UpdateProductList();
        }

        private void LoadDonorsFromDb()
{
    string connectionString = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;
    using (SqlConnection conn = new SqlConnection(connectionString))
    {
        conn.Open();
        string query = "SELECT Name, Amount FROM Donors";
        using (SqlCommand cmd = new SqlCommand(query, conn))
        using (SqlDataReader reader = cmd.ExecuteReader())
        {
            lboxDonorsDonate.Items.Clear();
            while (reader.Read())
            {
                string name = reader.GetString(0);
                decimal amount = reader.GetDecimal(1);
                lboxDonorsDonate.Items.Add($"{name} - ${amount}");
            }
        }
    }
}
    }
}



