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
            lstProductInventory = new ListBox();
            tabItemDetails = new TabPage();
            lblDescriptionDetail = new Label();
            lblPriceDetail = new Label();
            lblQuantityDetail = new Label();
            lblProductIDDetail = new Label();
            lblCategoryDetail = new Label();
            lblNameDetail = new Label();
            picBoxProduct = new PictureBox();
            label1 = new Label();
            cboxCategory = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblProductImage = new Label();
            btnUploadImage = new Button();
            openFileDialog1 = new OpenFileDialog();
            tabControlInventory.SuspendLayout();
            tabInventory.SuspendLayout();
            tabItemDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxProduct).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 96);
            txtName.Name = "txtName";
            txtName.Size = new Size(202, 27);
            txtName.TabIndex = 0;
            txtName.UseWaitCursor = true;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(131, 245);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(202, 27);
            txtQuantity.TabIndex = 3;
            txtQuantity.UseWaitCursor = true;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(131, 198);
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
            lblName.Location = new Point(13, 102);
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
            lblCategory.Location = new Point(13, 145);
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
            lblProductId.Location = new Point(13, 197);
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
            lblQuantity.Location = new Point(13, 244);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(73, 21);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Quantity";
            lblQuantity.UseWaitCursor = true;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(132, 292);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(202, 27);
            txtPrice.TabIndex = 4;
            txtPrice.UseWaitCursor = true;
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(131, 341);
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
            lblPrice.Location = new Point(13, 292);
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
            lblDescription.Location = new Point(13, 340);
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
            btnAdd.Location = new Point(10, 500);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(156, 97);
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
            btnRemove.Location = new Point(172, 500);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(162, 97);
            btnRemove.TabIndex = 9;
            btnRemove.Text = "Remove -";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.UseWaitCursor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // tabControlInventory
            // 
            tabControlInventory.Controls.Add(tabInventory);
            tabControlInventory.Controls.Add(tabItemDetails);
            tabControlInventory.Location = new Point(339, 0);
            tabControlInventory.Name = "tabControlInventory";
            tabControlInventory.SelectedIndex = 0;
            tabControlInventory.Size = new Size(458, 597);
            tabControlInventory.TabIndex = 10;
            tabControlInventory.UseWaitCursor = true;
            // 
            // tabInventory
            // 
            tabInventory.BackColor = Color.Transparent;
            tabInventory.Controls.Add(lstProductInventory);
            tabInventory.Location = new Point(4, 25);
            tabInventory.Name = "tabInventory";
            tabInventory.Padding = new Padding(3);
            tabInventory.Size = new Size(450, 568);
            tabInventory.TabIndex = 0;
            tabInventory.Text = "Inventory";
            tabInventory.UseWaitCursor = true;
            // 
            // lstProductInventory
            // 
            lstProductInventory.BorderStyle = BorderStyle.FixedSingle;
            lstProductInventory.FormattingEnabled = true;
            lstProductInventory.HorizontalScrollbar = true;
            lstProductInventory.Location = new Point(6, 7);
            lstProductInventory.Name = "lstProductInventory";
            lstProductInventory.Size = new Size(438, 546);
            lstProductInventory.TabIndex = 7;
            lstProductInventory.UseWaitCursor = true;
            lstProductInventory.SelectedIndexChanged += lstProductInventory_SelectedIndexChanged;
            // 
            // tabItemDetails
            // 
            tabItemDetails.BackColor = Color.SeaShell;
            tabItemDetails.Controls.Add(lblDescriptionDetail);
            tabItemDetails.Controls.Add(lblPriceDetail);
            tabItemDetails.Controls.Add(lblQuantityDetail);
            tabItemDetails.Controls.Add(lblProductIDDetail);
            tabItemDetails.Controls.Add(lblCategoryDetail);
            tabItemDetails.Controls.Add(lblNameDetail);
            tabItemDetails.Controls.Add(picBoxProduct);
            tabItemDetails.Location = new Point(4, 24);
            tabItemDetails.Name = "tabItemDetails";
            tabItemDetails.Padding = new Padding(3);
            tabItemDetails.Size = new Size(450, 569);
            tabItemDetails.TabIndex = 1;
            tabItemDetails.Text = "Product Details";
            tabItemDetails.UseWaitCursor = true;
            // 
            // lblDescriptionDetail
            // 
            lblDescriptionDetail.AutoSize = true;
            lblDescriptionDetail.BackColor = Color.Transparent;
            lblDescriptionDetail.Font = new Font("Yu Gothic", 10F);
            lblDescriptionDetail.Location = new Point(26, 415);
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
            lblPriceDetail.Location = new Point(26, 371);
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
            lblQuantityDetail.Location = new Point(26, 327);
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
            lblProductIDDetail.Location = new Point(26, 287);
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
            lblCategoryDetail.Location = new Point(26, 245);
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
            lblNameDetail.Location = new Point(26, 205);
            lblNameDetail.Name = "lblNameDetail";
            lblNameDetail.Size = new Size(104, 18);
            lblNameDetail.TabIndex = 1;
            lblNameDetail.Text = "Product Name:";
            lblNameDetail.UseWaitCursor = true;
            // 
            // picBoxProduct
            // 
            picBoxProduct.BorderStyle = BorderStyle.FixedSingle;
            picBoxProduct.Location = new Point(146, 19);
            picBoxProduct.Name = "picBoxProduct";
            picBoxProduct.Size = new Size(161, 166);
            picBoxProduct.TabIndex = 0;
            picBoxProduct.TabStop = false;
            picBoxProduct.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 25);
            label1.Name = "label1";
            label1.Size = new Size(315, 36);
            label1.TabIndex = 16;
            label1.Text = "PC Systems and Parts";
            label1.UseWaitCursor = true;
            // 
            // cboxCategory
            // 
            cboxCategory.Font = new Font("Yu Gothic", 10F);
            cboxCategory.FormattingEnabled = true;
            cboxCategory.Items.AddRange(new object[] { "CPU", "CPU Cooler", "Motherboard", "Memory", "Storage", "Video Card", "Case", "Power Supply", "Monitor" });
            cboxCategory.Location = new Point(131, 146);
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
            lblProductImage.Location = new Point(13, 461);
            lblProductImage.Name = "lblProductImage";
            lblProductImage.Size = new Size(56, 21);
            lblProductImage.TabIndex = 18;
            lblProductImage.Text = "Image";
            lblProductImage.UseWaitCursor = true;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(131, 452);
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
            // InventoryMangementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(800, 607);
            Controls.Add(btnUploadImage);
            Controls.Add(lblProductImage);
            Controls.Add(cboxCategory);
            Controls.Add(label1);
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
            tabItemDetails.ResumeLayout(false);
            tabItemDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxProduct).EndInit();
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
        private Label label1;
        private ListBox lstProductInventory;
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
    }
}
