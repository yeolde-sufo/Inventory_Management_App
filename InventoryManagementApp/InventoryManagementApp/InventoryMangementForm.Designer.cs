namespace InventoryManagementApp
{
    partial class InventoryMangementForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            txtName = new TextBox();
            txtQuantity = new TextBox();
            txtProductId = new TextBox();
            lblName = new Label();
            lblCategory = new Label();
            lblProductId = new Label();
            lblQuantity = new Label();
            txtPrice = new TextBox();
            richTxtDescription = new RichTextBox();
            lblPrice = new Label();
            lblDescription = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            tabControlInventory = new TabControl();
            tabInventory = new TabPage();
            dataGridViewInventory = new DataGridView();
            ColSelect = new DataGridViewCheckBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            ColCategory = new DataGridViewTextBoxColumn();
            ColQuantity = new DataGridViewTextBoxColumn();
            ColPrice = new DataGridViewTextBoxColumn();
            dataGridViewProductID = new DataGridViewTextBoxColumn();
            ColDescription = new DataGridViewTextBoxColumn();
            tabItemDetails = new TabPage();
            lblDescriptionDetail = new Label();
            lblPriceDetail = new Label();
            lblQuantityDetail = new Label();
            lblProductIDDetail = new Label();
            lblCategoryDetail = new Label();
            lblNameDetail = new Label();
            picBoxProduct = new PictureBox();
            lblLogo = new Label();
            cboxCategory = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblProductImage = new Label();
            btnUploadImage = new Button();
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            btnEdit = new Button();
            picBoxPreviewProduct = new PictureBox();
            tabControlInventory.SuspendLayout();
            tabInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).BeginInit();
            tabItemDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPreviewProduct).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 379);
            txtName.Name = "txtName";
            txtName.Size = new Size(202, 27);
            txtName.TabIndex = 0;
            txtName.UseWaitCursor = true;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(468, 373);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(202, 27);
            txtQuantity.TabIndex = 3;
            txtQuantity.UseWaitCursor = true;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(138, 473);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(202, 27);
            txtProductId.TabIndex = 2;
            txtProductId.UseWaitCursor = true;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.ActiveCaptionText;
            lblName.Location = new Point(15, 385);
            lblName.Name = "lblName";
            lblName.Size = new Size(117, 21);
            lblName.TabIndex = 4;
            lblName.Text = "Product Name";
            lblName.UseWaitCursor = true;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = SystemColors.ActiveCaptionText;
            lblCategory.Location = new Point(15, 428);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(77, 21);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            lblCategory.UseWaitCursor = true;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.BackColor = Color.Transparent;
            lblProductId.Font = new Font("Yu Gothic", 12F);
            lblProductId.ForeColor = SystemColors.ActiveCaptionText;
            lblProductId.Location = new Point(15, 472);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(87, 21);
            lblProductId.TabIndex = 7;
            lblProductId.Text = "Product Id";
            lblProductId.UseWaitCursor = true;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.Transparent;
            lblQuantity.Font = new Font("Yu Gothic", 12F);
            lblQuantity.ForeColor = SystemColors.ActiveCaptionText;
            lblQuantity.Location = new Point(368, 379);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(73, 21);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Quantity";
            lblQuantity.UseWaitCursor = true;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(468, 422);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(202, 27);
            txtPrice.TabIndex = 4;
            txtPrice.UseWaitCursor = true;
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(138, 521);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(202, 96);
            richTxtDescription.TabIndex = 5;
            richTxtDescription.Text = "";
            richTxtDescription.UseWaitCursor = true;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Yu Gothic", 12F);
            lblPrice.ForeColor = SystemColors.ActiveCaptionText;
            lblPrice.Location = new Point(368, 428);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(48, 21);
            lblPrice.TabIndex = 11;
            lblPrice.Text = "Price";
            lblPrice.UseWaitCursor = true;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Yu Gothic", 12F);
            lblDescription.ForeColor = SystemColors.ActiveCaptionText;
            lblDescription.Location = new Point(14, 520);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(94, 21);
            lblDescription.TabIndex = 12;
            lblDescription.Text = "Description";
            lblDescription.UseWaitCursor = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.PaleGreen;
            btnAdd.Font = new Font("Yu Gothic", 12F);
            btnAdd.Location = new Point(368, 557);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(156, 44);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add +";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.UseWaitCursor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Pink;
            btnRemove.Font = new Font("Yu Gothic", 12F);
            btnRemove.Location = new Point(751, 557);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(156, 44);
            btnRemove.TabIndex = 9;
            btnRemove.Text = "Remove -";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.UseWaitCursor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // tabControlInventory
            // 
            tabControlInventory.Appearance = TabAppearance.FlatButtons;
            tabControlInventory.Controls.Add(tabInventory);
            tabControlInventory.Controls.Add(tabItemDetails);
            tabControlInventory.Location = new Point(-2, 61);
            tabControlInventory.Name = "tabControlInventory";
            tabControlInventory.SelectedIndex = 0;
            tabControlInventory.Size = new Size(950, 306);
            tabControlInventory.TabIndex = 10;
            tabControlInventory.UseWaitCursor = true;
            // 
            // tabInventory
            // 
            tabInventory.BackColor = Color.Transparent;
            tabInventory.Controls.Add(dataGridViewInventory);
            tabInventory.Location = new Point(4, 28);
            tabInventory.Name = "tabInventory";
            tabInventory.Padding = new Padding(3);
            tabInventory.Size = new Size(942, 274);
            tabInventory.TabIndex = 0;
            tabInventory.Text = "Inventory";
            tabInventory.UseWaitCursor = true;
            // 
            // dataGridViewInventory
            // 
            dataGridViewInventory.AllowUserToAddRows = false;
            dataGridViewInventory.AllowUserToDeleteRows = false;
            dataGridViewInventory.AllowUserToResizeColumns = false;
            dataGridViewInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInventory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewInventory.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventory.Columns.AddRange(new DataGridViewColumn[] { ColSelect, colName, ColCategory, ColQuantity, ColPrice, dataGridViewProductID, ColDescription });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewInventory.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewInventory.Location = new Point(0, 3);
            dataGridViewInventory.Name = "dataGridViewInventory";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewInventory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewInventory.Size = new Size(942, 271);
            dataGridViewInventory.TabIndex = 0;
            dataGridViewInventory.UseWaitCursor = true;
            dataGridViewInventory.SelectionChanged += dataGridViewInventory_SelectionChanged;
            // 
            // ColSelect
            // 
            ColSelect.FillWeight = 15F;
            ColSelect.HeaderText = "Select";
            ColSelect.Name = "ColSelect";
            ColSelect.Resizable = DataGridViewTriState.True;
            ColSelect.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // colName
            // 
            colName.FillWeight = 46.46345F;
            colName.HeaderText = "Product Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Resizable = DataGridViewTriState.False;
            // 
            // ColCategory
            // 
            ColCategory.FillWeight = 46.46345F;
            ColCategory.HeaderText = "Category";
            ColCategory.Name = "ColCategory";
            ColCategory.ReadOnly = true;
            ColCategory.Resizable = DataGridViewTriState.False;
            // 
            // ColQuantity
            // 
            ColQuantity.FillWeight = 46.46345F;
            ColQuantity.HeaderText = "Quantity";
            ColQuantity.Name = "ColQuantity";
            ColQuantity.ReadOnly = true;
            ColQuantity.Resizable = DataGridViewTriState.False;
            // 
            // ColPrice
            // 
            ColPrice.FillWeight = 46.46345F;
            ColPrice.HeaderText = "Price";
            ColPrice.Name = "ColPrice";
            ColPrice.ReadOnly = true;
            ColPrice.Resizable = DataGridViewTriState.False;
            // 
            // dataGridViewProductID
            // 
            dataGridViewProductID.FillWeight = 46.46345F;
            dataGridViewProductID.HeaderText = "Product ID";
            dataGridViewProductID.Name = "dataGridViewProductID";
            dataGridViewProductID.ReadOnly = true;
            dataGridViewProductID.Resizable = DataGridViewTriState.False;
            // 
            // ColDescription
            // 
            ColDescription.FillWeight = 46.46345F;
            ColDescription.HeaderText = "Product Description";
            ColDescription.Name = "ColDescription";
            ColDescription.ReadOnly = true;
            ColDescription.Resizable = DataGridViewTriState.False;
            // 
            // tabItemDetails
            // 
            tabItemDetails.BackColor = Color.AliceBlue;
            tabItemDetails.Controls.Add(lblDescriptionDetail);
            tabItemDetails.Controls.Add(lblPriceDetail);
            tabItemDetails.Controls.Add(lblQuantityDetail);
            tabItemDetails.Controls.Add(lblProductIDDetail);
            tabItemDetails.Controls.Add(lblCategoryDetail);
            tabItemDetails.Controls.Add(lblNameDetail);
            tabItemDetails.Controls.Add(picBoxProduct);
            tabItemDetails.Location = new Point(4, 27);
            tabItemDetails.Name = "tabItemDetails";
            tabItemDetails.Padding = new Padding(3);
            tabItemDetails.Size = new Size(942, 275);
            tabItemDetails.TabIndex = 1;
            tabItemDetails.Text = "Product Details";
            tabItemDetails.UseWaitCursor = true;
            // 
            // lblDescriptionDetail
            // 
            lblDescriptionDetail.AutoSize = true;
            lblDescriptionDetail.BackColor = Color.Transparent;
            lblDescriptionDetail.Font = new Font("Yu Gothic", 10F);
            lblDescriptionDetail.Location = new Point(572, 23);
            lblDescriptionDetail.Name = "lblDescriptionDetail";
            lblDescriptionDetail.Size = new Size(86, 18);
            lblDescriptionDetail.TabIndex = 6;
            lblDescriptionDetail.Text = "Description:";
            lblDescriptionDetail.UseWaitCursor = true;
            // 
            // lblPriceDetail
            // 
            lblPriceDetail.AutoSize = true;
            lblPriceDetail.BackColor = Color.Transparent;
            lblPriceDetail.Font = new Font("Yu Gothic", 10F);
            lblPriceDetail.Location = new Point(296, 214);
            lblPriceDetail.Name = "lblPriceDetail";
            lblPriceDetail.Size = new Size(45, 18);
            lblPriceDetail.TabIndex = 5;
            lblPriceDetail.Text = "Price:";
            lblPriceDetail.UseWaitCursor = true;
            // 
            // lblQuantityDetail
            // 
            lblQuantityDetail.AutoSize = true;
            lblQuantityDetail.BackColor = Color.Transparent;
            lblQuantityDetail.Font = new Font("Yu Gothic", 10F);
            lblQuantityDetail.Location = new Point(296, 161);
            lblQuantityDetail.Name = "lblQuantityDetail";
            lblQuantityDetail.Size = new Size(67, 18);
            lblQuantityDetail.TabIndex = 4;
            lblQuantityDetail.Text = "Quantity:";
            lblQuantityDetail.UseWaitCursor = true;
            // 
            // lblProductIDDetail
            // 
            lblProductIDDetail.AutoSize = true;
            lblProductIDDetail.BackColor = Color.Transparent;
            lblProductIDDetail.Font = new Font("Yu Gothic", 10F);
            lblProductIDDetail.Location = new Point(296, 115);
            lblProductIDDetail.Name = "lblProductIDDetail";
            lblProductIDDetail.Size = new Size(80, 18);
            lblProductIDDetail.TabIndex = 3;
            lblProductIDDetail.Text = "Product ID:";
            lblProductIDDetail.UseWaitCursor = true;
            // 
            // lblCategoryDetail
            // 
            lblCategoryDetail.AutoSize = true;
            lblCategoryDetail.BackColor = Color.Transparent;
            lblCategoryDetail.Font = new Font("Yu Gothic", 10F);
            lblCategoryDetail.Location = new Point(296, 67);
            lblCategoryDetail.Name = "lblCategoryDetail";
            lblCategoryDetail.Size = new Size(71, 18);
            lblCategoryDetail.TabIndex = 2;
            lblCategoryDetail.Text = "Category:";
            lblCategoryDetail.UseWaitCursor = true;
            // 
            // lblNameDetail
            // 
            lblNameDetail.AutoSize = true;
            lblNameDetail.BackColor = Color.Transparent;
            lblNameDetail.Font = new Font("Yu Gothic", 10F);
            lblNameDetail.Location = new Point(296, 23);
            lblNameDetail.Name = "lblNameDetail";
            lblNameDetail.Size = new Size(104, 18);
            lblNameDetail.TabIndex = 1;
            lblNameDetail.Text = "Product Name:";
            lblNameDetail.UseWaitCursor = true;
            // 
            // picBoxProduct
            // 
            picBoxProduct.BorderStyle = BorderStyle.FixedSingle;
            picBoxProduct.Location = new Point(23, 23);
            picBoxProduct.Name = "picBoxProduct";
            picBoxProduct.Size = new Size(243, 227);
            picBoxProduct.TabIndex = 0;
            picBoxProduct.TabStop = false;
            picBoxProduct.UseWaitCursor = true;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.Transparent;
            lblLogo.Font = new Font("Yu Gothic", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.Location = new Point(12, 9);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(416, 36);
            lblLogo.TabIndex = 16;
            lblLogo.Text = "ECPC System Parts Inventory";
            lblLogo.UseWaitCursor = true;
            // 
            // cboxCategory
            // 
            cboxCategory.Font = new Font("Yu Gothic", 10F);
            cboxCategory.FormattingEnabled = true;
            cboxCategory.Items.AddRange(new object[] { "CPU", "CPU Cooler", "Motherboard", "Memory", "Storage", "Video Card", "Case", "Power Supply", "Monitor" });
            cboxCategory.Location = new Point(138, 424);
            cboxCategory.Name = "cboxCategory";
            cboxCategory.Size = new Size(202, 25);
            cboxCategory.TabIndex = 1;
            cboxCategory.UseWaitCursor = true;
            // 
            // lblProductImage
            // 
            lblProductImage.AutoSize = true;
            lblProductImage.BackColor = Color.Transparent;
            lblProductImage.Font = new Font("Yu Gothic", 12F);
            lblProductImage.ForeColor = SystemColors.ActiveCaptionText;
            lblProductImage.Location = new Point(368, 479);
            lblProductImage.Name = "lblProductImage";
            lblProductImage.Size = new Size(56, 21);
            lblProductImage.TabIndex = 18;
            lblProductImage.Text = "Image";
            lblProductImage.UseWaitCursor = true;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(468, 470);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(202, 42);
            btnUploadImage.TabIndex = 6;
            btnUploadImage.Text = "Upload";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.UseWaitCursor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(805, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 36);
            label1.TabIndex = 19;
            label1.Text = "Admin";
            label1.UseWaitCursor = true;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.SkyBlue;
            btnEdit.Font = new Font("Yu Gothic", 12F);
            btnEdit.Location = new Point(560, 557);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(156, 44);
            btnEdit.TabIndex = 20;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.UseWaitCursor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // picBoxPreviewProduct
            // 
            picBoxPreviewProduct.BackColor = Color.White;
            picBoxPreviewProduct.BorderStyle = BorderStyle.FixedSingle;
            picBoxPreviewProduct.Location = new Point(721, 373);
            picBoxPreviewProduct.Name = "picBoxPreviewProduct";
            picBoxPreviewProduct.Size = new Size(186, 155);
            picBoxPreviewProduct.TabIndex = 21;
            picBoxPreviewProduct.TabStop = false;
            picBoxPreviewProduct.UseWaitCursor = true;
            // 
            // InventoryMangementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(944, 645);
            Controls.Add(picBoxPreviewProduct);
            Controls.Add(btnEdit);
            Controls.Add(label1);
            Controls.Add(btnUploadImage);
            Controls.Add(lblProductImage);
            Controls.Add(cboxCategory);
            Controls.Add(lblLogo);
            Controls.Add(tabControlInventory);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lblDescription);
            Controls.Add(lblPrice);
            Controls.Add(richTxtDescription);
            Controls.Add(txtPrice);
            Controls.Add(lblProductId);
            Controls.Add(lblQuantity);
            Controls.Add(lblCategory);
            Controls.Add(lblName);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductId);
            Controls.Add(txtName);
            Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "InventoryMangementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management App";
            UseWaitCursor = true;
            tabControlInventory.ResumeLayout(false);
            tabInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).EndInit();
            tabItemDetails.ResumeLayout(false);
            tabItemDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPreviewProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtProductId;
        private Label lblName;
        private Label lblCategory;
        private Label lblProductId;
        private Label lblQuantity;
        private TextBox txtPrice;
        private RichTextBox richTxtDescription;
        private Label lblPrice;
        private Label lblDescription;
        private Button btnAdd;
        private Button btnRemove;
        private TabControl tabControlInventory;
        private TabPage tabInventory;
        private TabPage tabItemDetails;
        private Label lblLogo;
        private ComboBox cboxCategory;
        private Label lblDescriptionDetail;
        private Label lblPriceDetail;
        private Label lblQuantityDetail;
        private Label lblProductIDDetail;
        private Label lblCategoryDetail;
        private Label lblNameDetail;
        private PictureBox picBoxProduct;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblProductImage;
        private Button btnUploadImage;
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridViewInventory;
        private Label label1;
        private Button btnEdit;
        private PictureBox picBoxPreviewProduct;
        private DataGridViewCheckBoxColumn ColSelect;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn ColCategory;
        private DataGridViewTextBoxColumn ColQuantity;
        private DataGridViewTextBoxColumn ColPrice;
        private DataGridViewTextBoxColumn dataGridViewProductID;
        private DataGridViewTextBoxColumn ColDescription;
    }
}
