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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryMangementForm));
            txtName = new TextBox();
            lblName = new Label();
            lblCategory = new Label();
            lblQuantity = new Label();
            lblPrice = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            tabControlInventory = new TabControl();
            tabInventory = new TabPage();
            dataGridViewInventory = new DataGridView();
            ColSelect = new DataGridViewCheckBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            ColCategory = new DataGridViewTextBoxColumn();
            Size = new DataGridViewTextBoxColumn();
            ColQuantity = new DataGridViewTextBoxColumn();
            ColPrice = new DataGridViewTextBoxColumn();
            tabItemDetails = new TabPage();
            lblFactDetail = new Label();
            lblSizeDetail = new Label();
            lblDateDetail = new Label();
            lblQuantityDetail = new Label();
            lblCategoryDetail = new Label();
            lblNameDetail = new Label();
            picBoxProduct = new PictureBox();
            tabPage1 = new TabPage();
            btnDonateDonate = new Button();
            label8 = new Label();
            mtboxCSVDonate = new MaskedTextBox();
            mtboxCardDonate = new MaskedTextBox();
            label7 = new Label();
            nudAmntDonate = new NumericUpDown();
            textNameDonate = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            lboxDonorsDonate = new ListBox();
            label5 = new Label();
            label4 = new Label();
            cboxCategory = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblProductImage = new Label();
            btnUploadImage = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnEdit = new Button();
            picBoxPreviewProduct = new PictureBox();
            label1 = new Label();
            cboxSize = new ComboBox();
            dtpDate = new DateTimePicker();
            nudQuantity = new NumericUpDown();
            tabControlInventory.SuspendLayout();
            tabInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).BeginInit();
            tabItemDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxProduct).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmntDonate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPreviewProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(177, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(202, 32);
            txtName.TabIndex = 0;
            txtName.UseWaitCursor = true;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.ActiveCaptionText;
            lblName.Location = new Point(68, 18);
            lblName.Name = "lblName";
            lblName.Size = new Size(66, 26);
            lblName.TabIndex = 4;
            lblName.Text = "Trash";
            lblName.UseWaitCursor = true;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = SystemColors.ActiveCaptionText;
            lblCategory.Location = new Point(40, 60);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(101, 26);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            lblCategory.UseWaitCursor = true;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.Transparent;
            lblQuantity.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = SystemColors.ActiveCaptionText;
            lblQuantity.Location = new Point(40, 154);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(96, 26);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Quantity";
            lblQuantity.UseWaitCursor = true;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = SystemColors.ActiveCaptionText;
            lblPrice.Location = new Point(75, 193);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(59, 26);
            lblPrice.TabIndex = 11;
            lblPrice.Text = "Date";
            lblPrice.UseWaitCursor = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Font = new Font("Yu Gothic", 12F);
            btnAdd.Location = new Point(28, 484);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 44);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.UseWaitCursor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.LightCoral;
            btnRemove.Font = new Font("Yu Gothic", 12F);
            btnRemove.Location = new Point(266, 484);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(113, 44);
            btnRemove.TabIndex = 9;
            btnRemove.Text = "Remove ";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.UseWaitCursor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // tabControlInventory
            // 
            tabControlInventory.Appearance = TabAppearance.FlatButtons;
            tabControlInventory.Controls.Add(tabInventory);
            tabControlInventory.Controls.Add(tabItemDetails);
            tabControlInventory.Controls.Add(tabPage1);
            tabControlInventory.Location = new Point(400, 9);
            tabControlInventory.Name = "tabControlInventory";
            tabControlInventory.SelectedIndex = 0;
            tabControlInventory.Size = new Size(798, 519);
            tabControlInventory.TabIndex = 10;
            tabControlInventory.UseWaitCursor = true;
            // 
            // tabInventory
            // 
            tabInventory.BackColor = Color.MediumSeaGreen;
            tabInventory.Controls.Add(dataGridViewInventory);
            tabInventory.Location = new Point(4, 32);
            tabInventory.Name = "tabInventory";
            tabInventory.Padding = new Padding(3);
            tabInventory.Size = new Size(790, 483);
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
            dataGridViewInventory.Columns.AddRange(new DataGridViewColumn[] { ColSelect, colName, ColCategory, Size, ColQuantity, ColPrice });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewInventory.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewInventory.Location = new Point(6, 6);
            dataGridViewInventory.Name = "dataGridViewInventory";
            dataGridViewInventory.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewInventory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewInventory.Size = new Size(777, 440);
            dataGridViewInventory.TabIndex = 0;
            dataGridViewInventory.UseWaitCursor = true;
            dataGridViewInventory.SelectionChanged += dataGridViewInventory_SelectionChanged;
            // 
            // ColSelect
            // 
            ColSelect.FillWeight = 44.6608047F;
            ColSelect.HeaderText = "Select";
            ColSelect.MinimumWidth = 6;
            ColSelect.Name = "ColSelect";
            ColSelect.Resizable = DataGridViewTriState.True;
            ColSelect.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // colName
            // 
            colName.FillWeight = 44.6608047F;
            colName.HeaderText = "Trash";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Resizable = DataGridViewTriState.False;
            // 
            // ColCategory
            // 
            ColCategory.FillWeight = 44.6608047F;
            ColCategory.HeaderText = "Category";
            ColCategory.MinimumWidth = 6;
            ColCategory.Name = "ColCategory";
            ColCategory.ReadOnly = true;
            ColCategory.Resizable = DataGridViewTriState.False;
            // 
            // Size
            // 
            Size.FillWeight = 44.6608047F;
            Size.HeaderText = "Size";
            Size.MinimumWidth = 6;
            Size.Name = "Size";
            // 
            // ColQuantity
            // 
            ColQuantity.FillWeight = 44.6608047F;
            ColQuantity.HeaderText = "Quantity";
            ColQuantity.MinimumWidth = 6;
            ColQuantity.Name = "ColQuantity";
            ColQuantity.ReadOnly = true;
            ColQuantity.Resizable = DataGridViewTriState.False;
            // 
            // ColPrice
            // 
            ColPrice.FillWeight = 44.6608047F;
            ColPrice.HeaderText = "Date";
            ColPrice.MinimumWidth = 6;
            ColPrice.Name = "ColPrice";
            ColPrice.ReadOnly = true;
            ColPrice.Resizable = DataGridViewTriState.False;
            // 
            // tabItemDetails
            // 
            tabItemDetails.BackColor = Color.LightSkyBlue;
            tabItemDetails.Controls.Add(lblFactDetail);
            tabItemDetails.Controls.Add(lblSizeDetail);
            tabItemDetails.Controls.Add(lblDateDetail);
            tabItemDetails.Controls.Add(lblQuantityDetail);
            tabItemDetails.Controls.Add(lblCategoryDetail);
            tabItemDetails.Controls.Add(lblNameDetail);
            tabItemDetails.Controls.Add(picBoxProduct);
            tabItemDetails.Location = new Point(4, 32);
            tabItemDetails.Name = "tabItemDetails";
            tabItemDetails.Padding = new Padding(3);
            tabItemDetails.Size = new Size(790, 483);
            tabItemDetails.TabIndex = 1;
            tabItemDetails.Text = "Item Details";
            tabItemDetails.UseWaitCursor = true;
            // 
            // lblFactDetail
            // 
            lblFactDetail.Location = new Point(23, 344);
            lblFactDetail.Name = "lblFactDetail";
            lblFactDetail.Size = new Size(761, 122);
            lblFactDetail.TabIndex = 7;
            lblFactDetail.Text = "Fun Fact:";
            lblFactDetail.UseWaitCursor = true;
            // 
            // lblSizeDetail
            // 
            lblSizeDetail.AutoSize = true;
            lblSizeDetail.Font = new Font("Yu Gothic", 10F);
            lblSizeDetail.Location = new Point(284, 128);
            lblSizeDetail.Name = "lblSizeDetail";
            lblSizeDetail.Size = new Size(47, 22);
            lblSizeDetail.TabIndex = 6;
            lblSizeDetail.Text = "Size:";
            lblSizeDetail.UseWaitCursor = true;
            // 
            // lblDateDetail
            // 
            lblDateDetail.AutoSize = true;
            lblDateDetail.BackColor = Color.Transparent;
            lblDateDetail.Font = new Font("Yu Gothic", 10F);
            lblDateDetail.Location = new Point(284, 228);
            lblDateDetail.Name = "lblDateDetail";
            lblDateDetail.Size = new Size(116, 22);
            lblDateDetail.TabIndex = 5;
            lblDateDetail.Text = "Date inputed:";
            lblDateDetail.UseWaitCursor = true;
            // 
            // lblQuantityDetail
            // 
            lblQuantityDetail.AutoSize = true;
            lblQuantityDetail.BackColor = Color.Transparent;
            lblQuantityDetail.Font = new Font("Yu Gothic", 10F);
            lblQuantityDetail.Location = new Point(284, 176);
            lblQuantityDetail.Name = "lblQuantityDetail";
            lblQuantityDetail.Size = new Size(80, 22);
            lblQuantityDetail.TabIndex = 4;
            lblQuantityDetail.Text = "Quantity:";
            lblQuantityDetail.UseWaitCursor = true;
            // 
            // lblCategoryDetail
            // 
            lblCategoryDetail.AutoSize = true;
            lblCategoryDetail.BackColor = Color.Transparent;
            lblCategoryDetail.Font = new Font("Yu Gothic", 10F);
            lblCategoryDetail.Location = new Point(284, 71);
            lblCategoryDetail.Name = "lblCategoryDetail";
            lblCategoryDetail.Size = new Size(84, 22);
            lblCategoryDetail.TabIndex = 2;
            lblCategoryDetail.Text = "Category:";
            lblCategoryDetail.UseWaitCursor = true;
            // 
            // lblNameDetail
            // 
            lblNameDetail.AutoSize = true;
            lblNameDetail.BackColor = Color.Transparent;
            lblNameDetail.Font = new Font("Yu Gothic", 10F);
            lblNameDetail.Location = new Point(284, 23);
            lblNameDetail.Name = "lblNameDetail";
            lblNameDetail.Size = new Size(58, 22);
            lblNameDetail.TabIndex = 1;
            lblNameDetail.Text = "Trash:";
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
            // tabPage1
            // 
            tabPage1.BackColor = Color.Khaki;
            tabPage1.Controls.Add(btnDonateDonate);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(mtboxCSVDonate);
            tabPage1.Controls.Add(mtboxCardDonate);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(nudAmntDonate);
            tabPage1.Controls.Add(textNameDonate);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(lboxDonorsDonate);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(790, 483);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Donate!";
            tabPage1.UseWaitCursor = true;
            // 
            // btnDonateDonate
            // 
            btnDonateDonate.BackColor = Color.DarkTurquoise;
            btnDonateDonate.Location = new Point(156, 428);
            btnDonateDonate.Name = "btnDonateDonate";
            btnDonateDonate.Size = new Size(125, 35);
            btnDonateDonate.TabIndex = 13;
            btnDonateDonate.Text = "Donate!";
            btnDonateDonate.UseVisualStyleBackColor = false;
            btnDonateDonate.UseWaitCursor = true;
            btnDonateDonate.Click += btnDonateDonate_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(333, 402);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 12;
            label8.Text = "CSV:";
            label8.UseWaitCursor = true;
            // 
            // mtboxCSVDonate
            // 
            mtboxCSVDonate.Location = new Point(380, 390);
            mtboxCSVDonate.Mask = "000";
            mtboxCSVDonate.Name = "mtboxCSVDonate";
            mtboxCSVDonate.Size = new Size(34, 32);
            mtboxCSVDonate.TabIndex = 11;
            mtboxCSVDonate.UseWaitCursor = true;
            // 
            // mtboxCardDonate
            // 
            mtboxCardDonate.Location = new Point(156, 390);
            mtboxCardDonate.Mask = "0000 0000 0000 0000";
            mtboxCardDonate.Name = "mtboxCardDonate";
            mtboxCardDonate.Size = new Size(155, 32);
            mtboxCardDonate.TabIndex = 10;
            mtboxCardDonate.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 402);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 9;
            label7.Text = "Card:";
            label7.UseWaitCursor = true;
            // 
            // nudAmntDonate
            // 
            nudAmntDonate.Location = new Point(156, 341);
            nudAmntDonate.Name = "nudAmntDonate";
            nudAmntDonate.Size = new Size(258, 32);
            nudAmntDonate.TabIndex = 8;
            nudAmntDonate.UseWaitCursor = true;
            // 
            // textNameDonate
            // 
            textNameDonate.Location = new Point(156, 294);
            textNameDonate.Name = "textNameDonate";
            textNameDonate.Size = new Size(258, 32);
            textNameDonate.TabIndex = 6;
            textNameDonate.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 353);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 5;
            label3.Text = "Amount:";
            label3.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 306);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 4;
            label2.Text = "Name:";
            label2.UseWaitCursor = true;
            label2.Click += label2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(441, 294);
            label6.Name = "label6";
            label6.Size = new Size(114, 19);
            label6.TabIndex = 3;
            label6.Text = "Hall of Donors";
            label6.UseWaitCursor = true;
            // 
            // lboxDonorsDonate
            // 
            lboxDonorsDonate.FormattingEnabled = true;
            lboxDonorsDonate.Location = new Point(441, 316);
            lboxDonorsDonate.Name = "lboxDonorsDonate";
            lboxDonorsDonate.Size = new Size(294, 144);
            lboxDonorsDonate.TabIndex = 2;
            lboxDonorsDonate.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.Location = new Point(62, 68);
            label5.Name = "label5";
            label5.Size = new Size(673, 205);
            label5.TabIndex = 1;
            label5.Text = resources.GetString("label5.Text");
            label5.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(321, 31);
            label4.Name = "label4";
            label4.Size = new Size(138, 26);
            label4.TabIndex = 0;
            label4.Text = "Who are we?";
            label4.UseWaitCursor = true;
            label4.Click += label4_Click;
            // 
            // cboxCategory
            // 
            cboxCategory.Font = new Font("Yu Gothic", 10F);
            cboxCategory.FormattingEnabled = true;
            cboxCategory.Items.AddRange(new object[] { "Recyclable", "Non-Recyclable", "Biodegradable" });
            cboxCategory.Location = new Point(177, 56);
            cboxCategory.Name = "cboxCategory";
            cboxCategory.Size = new Size(202, 30);
            cboxCategory.TabIndex = 1;
            cboxCategory.UseWaitCursor = true;
            // 
            // lblProductImage
            // 
            lblProductImage.AutoSize = true;
            lblProductImage.BackColor = Color.Transparent;
            lblProductImage.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductImage.ForeColor = SystemColors.ActiveCaptionText;
            lblProductImage.Location = new Point(63, 237);
            lblProductImage.Name = "lblProductImage";
            lblProductImage.Size = new Size(72, 26);
            lblProductImage.TabIndex = 18;
            lblProductImage.Text = "Image";
            lblProductImage.UseWaitCursor = true;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(177, 411);
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
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkTurquoise;
            btnEdit.Font = new Font("Yu Gothic", 12F);
            btnEdit.Location = new Point(147, 484);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(113, 44);
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
            picBoxPreviewProduct.Location = new Point(177, 237);
            picBoxPreviewProduct.Name = "picBoxPreviewProduct";
            picBoxPreviewProduct.Size = new Size(202, 168);
            picBoxPreviewProduct.TabIndex = 21;
            picBoxPreviewProduct.TabStop = false;
            picBoxPreviewProduct.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 108);
            label1.Name = "label1";
            label1.Size = new Size(53, 26);
            label1.TabIndex = 22;
            label1.Text = "Size";
            label1.UseWaitCursor = true;
            // 
            // cboxSize
            // 
            cboxSize.FormattingEnabled = true;
            cboxSize.Items.AddRange(new object[] { "Large", "Medium", "Small" });
            cboxSize.Location = new Point(177, 106);
            cboxSize.Name = "cboxSize";
            cboxSize.Size = new Size(202, 28);
            cboxSize.TabIndex = 23;
            cboxSize.UseWaitCursor = true;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(177, 193);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(202, 32);
            dtpDate.TabIndex = 24;
            dtpDate.UseWaitCursor = true;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(177, 148);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(202, 32);
            nudQuantity.TabIndex = 25;
            nudQuantity.UseWaitCursor = true;
            // 
            // InventoryMangementForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1201, 536);
            Controls.Add(nudQuantity);
            Controls.Add(dtpDate);
            Controls.Add(cboxSize);
            Controls.Add(label1);
            Controls.Add(picBoxPreviewProduct);
            Controls.Add(btnEdit);
            Controls.Add(btnUploadImage);
            Controls.Add(lblProductImage);
            Controls.Add(cboxCategory);
            Controls.Add(tabControlInventory);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lblPrice);
            Controls.Add(lblQuantity);
            Controls.Add(lblCategory);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "InventoryMangementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recycling Management Corp";
            UseWaitCursor = true;
            tabControlInventory.ResumeLayout(false);
            tabInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).EndInit();
            tabItemDetails.ResumeLayout(false);
            tabItemDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxProduct).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmntDonate).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPreviewProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lblName;
        private Label lblCategory;
        private Label lblQuantity;
        private Label lblPrice;
        private Button btnAdd;
        private Button btnRemove;
        private TabControl tabControlInventory;
        private TabPage tabInventory;
        private TabPage tabItemDetails;
        private ComboBox cboxCategory;
        private Label lblDateDetail;
        private Label lblQuantityDetail;
        private Label lblCategoryDetail;
        private Label lblNameDetail;
        private PictureBox picBoxProduct;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblProductImage;
        private Button btnUploadImage;
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridViewInventory;
        private Button btnEdit;
        private PictureBox picBoxPreviewProduct;
        private TabPage tabPage1;
        private Label label1;
        private DataGridViewCheckBoxColumn ColSelect;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn ColCategory;
        private new DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn ColQuantity;
        private DataGridViewTextBoxColumn ColPrice;
        private Label lblFactDetail;
        private Label lblSizeDetail;
        private ComboBox cboxSize;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox lboxDonorsDonate;
        private Label label2;
        private TextBox textNameDonate;
        private Label label3;
        private NumericUpDown nudAmntDonate;
        private Label label7;
        private Button btnDonateDonate;
        private Label label8;
        private MaskedTextBox mtboxCSVDonate;
        private MaskedTextBox mtboxCardDonate;
        private DateTimePicker dtpDate;
        private NumericUpDown nudQuantity;
    }
}
