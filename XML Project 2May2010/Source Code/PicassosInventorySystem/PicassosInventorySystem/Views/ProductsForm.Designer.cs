namespace PicassosInventorySystem.Views
{
    partial class ProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.tabSystem = new System.Windows.Forms.TabControl();
            this.tabVendors = new System.Windows.Forms.TabPage();
            this.txtVendorId = new System.Windows.Forms.TextBox();
            this.txtVendorContactPerson = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVendorPhoneNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVendorZip = new System.Windows.Forms.TextBox();
            this.txtVendorState = new System.Windows.Forms.TextBox();
            this.txtVendorCity = new System.Windows.Forms.TextBox();
            this.txtVendorStreet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxVendors = new System.Windows.Forms.ListBox();
            this.tabCatalog = new System.Windows.Forms.TabPage();
            this.txtCatalogId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCatalogUnitCost = new System.Windows.Forms.TextBox();
            this.rdoCatalogVolume = new System.Windows.Forms.RadioButton();
            this.rdoCatalogSingle = new System.Windows.Forms.RadioButton();
            this.rdoCatalogBox = new System.Windows.Forms.RadioButton();
            this.lblUnitCost = new System.Windows.Forms.Label();
            this.txtCatalogVendorProductId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxCatalogVendor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCatalogItemDescription = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbxCatalogItems = new System.Windows.Forms.ListBox();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.cbxInventoryCatalogItem = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtInventoryId = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLocationDescription = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbxLocation = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtInventoryROQty = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtInventoryROPoint = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtInventoryQtyOnHand = new System.Windows.Forms.TextBox();
            this.txtInventoryDescription = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbxInventory = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.txtVendorComments = new System.Windows.Forms.RichTextBox();
            this.volumeItemDetailsControl1 = new PicassosInventorySystem.Views.VolumeItemDetailsControl();
            this.boxedItemDetailsControl1 = new PicassosInventorySystem.Views.BoxedItemDetailsControl();
            this.txtCatalogComments = new System.Windows.Forms.RichTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtInventoryComments = new System.Windows.Forms.RichTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tabSystem.SuspendLayout();
            this.tabVendors.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabCatalog.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabInventory.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSystem
            // 
            this.tabSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSystem.Controls.Add(this.tabVendors);
            this.tabSystem.Controls.Add(this.tabCatalog);
            this.tabSystem.Controls.Add(this.tabInventory);
            this.tabSystem.Location = new System.Drawing.Point(3, 12);
            this.tabSystem.Name = "tabSystem";
            this.tabSystem.SelectedIndex = 0;
            this.tabSystem.Size = new System.Drawing.Size(626, 395);
            this.tabSystem.TabIndex = 0;
            // 
            // tabVendors
            // 
            this.tabVendors.Controls.Add(this.txtVendorComments);
            this.tabVendors.Controls.Add(this.label21);
            this.tabVendors.Controls.Add(this.txtVendorId);
            this.tabVendors.Controls.Add(this.txtVendorContactPerson);
            this.tabVendors.Controls.Add(this.label8);
            this.tabVendors.Controls.Add(this.txtVendorPhoneNo);
            this.tabVendors.Controls.Add(this.label7);
            this.tabVendors.Controls.Add(this.txtVendorName);
            this.tabVendors.Controls.Add(this.label6);
            this.tabVendors.Controls.Add(this.groupBox1);
            this.tabVendors.Controls.Add(this.label1);
            this.tabVendors.Controls.Add(this.lbxVendors);
            this.tabVendors.Location = new System.Drawing.Point(4, 22);
            this.tabVendors.Name = "tabVendors";
            this.tabVendors.Padding = new System.Windows.Forms.Padding(3);
            this.tabVendors.Size = new System.Drawing.Size(618, 369);
            this.tabVendors.TabIndex = 0;
            this.tabVendors.Text = "Vendors";
            this.tabVendors.UseVisualStyleBackColor = true;
            // 
            // txtVendorId
            // 
            this.txtVendorId.Location = new System.Drawing.Point(398, 13);
            this.txtVendorId.Name = "txtVendorId";
            this.txtVendorId.Size = new System.Drawing.Size(100, 20);
            this.txtVendorId.TabIndex = 12;
            this.txtVendorId.Visible = false;
            // 
            // txtVendorContactPerson
            // 
            this.txtVendorContactPerson.Location = new System.Drawing.Point(398, 95);
            this.txtVendorContactPerson.Name = "txtVendorContactPerson";
            this.txtVendorContactPerson.Size = new System.Drawing.Size(200, 20);
            this.txtVendorContactPerson.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Contact Person:";
            // 
            // txtVendorPhoneNo
            // 
            this.txtVendorPhoneNo.Location = new System.Drawing.Point(398, 65);
            this.txtVendorPhoneNo.Name = "txtVendorPhoneNo";
            this.txtVendorPhoneNo.Size = new System.Drawing.Size(200, 20);
            this.txtVendorPhoneNo.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Phone No:";
            // 
            // txtVendorName
            // 
            this.txtVendorName.Location = new System.Drawing.Point(398, 39);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(200, 20);
            this.txtVendorName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Vendor Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVendorZip);
            this.groupBox1.Controls.Add(this.txtVendorState);
            this.groupBox1.Controls.Add(this.txtVendorCity);
            this.groupBox1.Controls.Add(this.txtVendorStreet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(302, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 132);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // txtVendorZip
            // 
            this.txtVendorZip.Location = new System.Drawing.Point(62, 98);
            this.txtVendorZip.Name = "txtVendorZip";
            this.txtVendorZip.Size = new System.Drawing.Size(84, 20);
            this.txtVendorZip.TabIndex = 7;
            // 
            // txtVendorState
            // 
            this.txtVendorState.Location = new System.Drawing.Point(55, 71);
            this.txtVendorState.Name = "txtVendorState";
            this.txtVendorState.Size = new System.Drawing.Size(241, 20);
            this.txtVendorState.TabIndex = 5;
            // 
            // txtVendorCity
            // 
            this.txtVendorCity.Location = new System.Drawing.Point(55, 44);
            this.txtVendorCity.Name = "txtVendorCity";
            this.txtVendorCity.Size = new System.Drawing.Size(241, 20);
            this.txtVendorCity.TabIndex = 3;
            // 
            // txtVendorStreet
            // 
            this.txtVendorStreet.Location = new System.Drawing.Point(55, 17);
            this.txtVendorStreet.Name = "txtVendorStreet";
            this.txtVendorStreet.Size = new System.Drawing.Size(241, 20);
            this.txtVendorStreet.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Zip Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "State:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Street:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendors";
            // 
            // lbxVendors
            // 
            this.lbxVendors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxVendors.FormattingEnabled = true;
            this.lbxVendors.Location = new System.Drawing.Point(6, 39);
            this.lbxVendors.Name = "lbxVendors";
            this.lbxVendors.Size = new System.Drawing.Size(289, 316);
            this.lbxVendors.TabIndex = 1;
            this.lbxVendors.SelectedIndexChanged += new System.EventHandler(this.lbxVendors_SelectedIndexChanged);
            // 
            // tabCatalog
            // 
            this.tabCatalog.Controls.Add(this.txtCatalogComments);
            this.tabCatalog.Controls.Add(this.label22);
            this.tabCatalog.Controls.Add(this.txtCatalogId);
            this.tabCatalog.Controls.Add(this.groupBox2);
            this.tabCatalog.Controls.Add(this.txtCatalogVendorProductId);
            this.tabCatalog.Controls.Add(this.label12);
            this.tabCatalog.Controls.Add(this.cbxCatalogVendor);
            this.tabCatalog.Controls.Add(this.label10);
            this.tabCatalog.Controls.Add(this.txtCatalogItemDescription);
            this.tabCatalog.Controls.Add(this.label11);
            this.tabCatalog.Controls.Add(this.label16);
            this.tabCatalog.Controls.Add(this.lbxCatalogItems);
            this.tabCatalog.Location = new System.Drawing.Point(4, 22);
            this.tabCatalog.Name = "tabCatalog";
            this.tabCatalog.Padding = new System.Windows.Forms.Padding(3);
            this.tabCatalog.Size = new System.Drawing.Size(618, 369);
            this.tabCatalog.TabIndex = 1;
            this.tabCatalog.Text = "Catalog";
            this.tabCatalog.UseVisualStyleBackColor = true;
            // 
            // txtCatalogId
            // 
            this.txtCatalogId.Location = new System.Drawing.Point(204, 1);
            this.txtCatalogId.Name = "txtCatalogId";
            this.txtCatalogId.Size = new System.Drawing.Size(55, 20);
            this.txtCatalogId.TabIndex = 9;
            this.txtCatalogId.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCatalogUnitCost);
            this.groupBox2.Controls.Add(this.volumeItemDetailsControl1);
            this.groupBox2.Controls.Add(this.boxedItemDetailsControl1);
            this.groupBox2.Controls.Add(this.rdoCatalogVolume);
            this.groupBox2.Controls.Add(this.rdoCatalogSingle);
            this.groupBox2.Controls.Add(this.rdoCatalogBox);
            this.groupBox2.Controls.Add(this.lblUnitCost);
            this.groupBox2.Location = new System.Drawing.Point(289, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 126);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Catalog Type";
            // 
            // txtCatalogUnitCost
            // 
            this.txtCatalogUnitCost.Location = new System.Drawing.Point(156, 19);
            this.txtCatalogUnitCost.Name = "txtCatalogUnitCost";
            this.txtCatalogUnitCost.Size = new System.Drawing.Size(100, 20);
            this.txtCatalogUnitCost.TabIndex = 2;
            this.txtCatalogUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCatalogUnitCost.TextChanged += new System.EventHandler(this.txtCatalogUnitCost_TextChanged);
            // 
            // rdoCatalogVolume
            // 
            this.rdoCatalogVolume.AutoSize = true;
            this.rdoCatalogVolume.Location = new System.Drawing.Point(15, 78);
            this.rdoCatalogVolume.Name = "rdoCatalogVolume";
            this.rdoCatalogVolume.Size = new System.Drawing.Size(60, 17);
            this.rdoCatalogVolume.TabIndex = 2;
            this.rdoCatalogVolume.Text = "Volume";
            this.rdoCatalogVolume.UseVisualStyleBackColor = true;
            // 
            // rdoCatalogSingle
            // 
            this.rdoCatalogSingle.AutoSize = true;
            this.rdoCatalogSingle.Checked = true;
            this.rdoCatalogSingle.Location = new System.Drawing.Point(15, 31);
            this.rdoCatalogSingle.Name = "rdoCatalogSingle";
            this.rdoCatalogSingle.Size = new System.Drawing.Size(54, 17);
            this.rdoCatalogSingle.TabIndex = 0;
            this.rdoCatalogSingle.TabStop = true;
            this.rdoCatalogSingle.Text = "Single";
            this.rdoCatalogSingle.UseVisualStyleBackColor = true;
            // 
            // rdoCatalogBox
            // 
            this.rdoCatalogBox.AutoSize = true;
            this.rdoCatalogBox.Location = new System.Drawing.Point(15, 55);
            this.rdoCatalogBox.Name = "rdoCatalogBox";
            this.rdoCatalogBox.Size = new System.Drawing.Size(43, 17);
            this.rdoCatalogBox.TabIndex = 1;
            this.rdoCatalogBox.Text = "Box";
            this.rdoCatalogBox.UseVisualStyleBackColor = true;
            this.rdoCatalogBox.CheckedChanged += new System.EventHandler(this.rdoCatalogBox_CheckedChanged);
            // 
            // lblUnitCost
            // 
            this.lblUnitCost.AutoSize = true;
            this.lblUnitCost.Location = new System.Drawing.Point(97, 22);
            this.lblUnitCost.Name = "lblUnitCost";
            this.lblUnitCost.Size = new System.Drawing.Size(53, 13);
            this.lblUnitCost.TabIndex = 1;
            this.lblUnitCost.Text = "Unit Cost:";
            // 
            // txtCatalogVendorProductId
            // 
            this.txtCatalogVendorProductId.Location = new System.Drawing.Point(377, 104);
            this.txtCatalogVendorProductId.Name = "txtCatalogVendorProductId";
            this.txtCatalogVendorProductId.Size = new System.Drawing.Size(211, 20);
            this.txtCatalogVendorProductId.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(275, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Vendor Product Id:";
            // 
            // cbxCatalogVendor
            // 
            this.cbxCatalogVendor.FormattingEnabled = true;
            this.cbxCatalogVendor.Location = new System.Drawing.Point(377, 77);
            this.cbxCatalogVendor.Name = "cbxCatalogVendor";
            this.cbxCatalogVendor.Size = new System.Drawing.Size(211, 21);
            this.cbxCatalogVendor.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(330, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Vendor:";
            // 
            // txtCatalogItemDescription
            // 
            this.txtCatalogItemDescription.Location = new System.Drawing.Point(377, 20);
            this.txtCatalogItemDescription.Multiline = true;
            this.txtCatalogItemDescription.Name = "txtCatalogItemDescription";
            this.txtCatalogItemDescription.Size = new System.Drawing.Size(211, 50);
            this.txtCatalogItemDescription.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(311, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Description:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Catalog Items";
            // 
            // lbxCatalogItems
            // 
            this.lbxCatalogItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxCatalogItems.FormattingEnabled = true;
            this.lbxCatalogItems.Location = new System.Drawing.Point(7, 27);
            this.lbxCatalogItems.Name = "lbxCatalogItems";
            this.lbxCatalogItems.Size = new System.Drawing.Size(252, 329);
            this.lbxCatalogItems.TabIndex = 1;
            this.lbxCatalogItems.SelectedIndexChanged += new System.EventHandler(this.lbxCatalogItems_SelectedIndexChanged);
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.txtInventoryComments);
            this.tabInventory.Controls.Add(this.label23);
            this.tabInventory.Controls.Add(this.cbxInventoryCatalogItem);
            this.tabInventory.Controls.Add(this.label19);
            this.tabInventory.Controls.Add(this.txtInventoryId);
            this.tabInventory.Controls.Add(this.groupBox3);
            this.tabInventory.Controls.Add(this.txtInventoryROQty);
            this.tabInventory.Controls.Add(this.label18);
            this.tabInventory.Controls.Add(this.txtInventoryROPoint);
            this.tabInventory.Controls.Add(this.label13);
            this.tabInventory.Controls.Add(this.txtInventoryQtyOnHand);
            this.tabInventory.Controls.Add(this.txtInventoryDescription);
            this.tabInventory.Controls.Add(this.label15);
            this.tabInventory.Controls.Add(this.label9);
            this.tabInventory.Controls.Add(this.label17);
            this.tabInventory.Controls.Add(this.lbxInventory);
            this.tabInventory.Location = new System.Drawing.Point(4, 22);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Size = new System.Drawing.Size(618, 369);
            this.tabInventory.TabIndex = 2;
            this.tabInventory.Text = "Inventory";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // cbxInventoryCatalogItem
            // 
            this.cbxInventoryCatalogItem.FormattingEnabled = true;
            this.cbxInventoryCatalogItem.Location = new System.Drawing.Point(373, 29);
            this.cbxInventoryCatalogItem.Name = "cbxInventoryCatalogItem";
            this.cbxInventoryCatalogItem.Size = new System.Drawing.Size(183, 21);
            this.cbxInventoryCatalogItem.TabIndex = 4;
            this.cbxInventoryCatalogItem.SelectedIndexChanged += new System.EventHandler(this.cbxInventoryCatalogItem_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(316, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Item:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInventoryId
            // 
            this.txtInventoryId.Location = new System.Drawing.Point(373, 4);
            this.txtInventoryId.Name = "txtInventoryId";
            this.txtInventoryId.ReadOnly = true;
            this.txtInventoryId.Size = new System.Drawing.Size(100, 20);
            this.txtInventoryId.TabIndex = 2;
            this.txtInventoryId.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLocationDescription);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.cbxLocation);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(308, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 78);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Location Details";
            // 
            // txtLocationDescription
            // 
            this.txtLocationDescription.Location = new System.Drawing.Point(77, 50);
            this.txtLocationDescription.Name = "txtLocationDescription";
            this.txtLocationDescription.Size = new System.Drawing.Size(181, 20);
            this.txtLocationDescription.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 50);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Description:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxLocation
            // 
            this.cbxLocation.FormattingEnabled = true;
            this.cbxLocation.Location = new System.Drawing.Point(75, 19);
            this.cbxLocation.Name = "cbxLocation";
            this.cbxLocation.Size = new System.Drawing.Size(183, 21);
            this.cbxLocation.TabIndex = 1;
            this.cbxLocation.SelectedIndexChanged += new System.EventHandler(this.cbxLocation_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Location:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInventoryROQty
            // 
            this.txtInventoryROQty.Location = new System.Drawing.Point(386, 258);
            this.txtInventoryROQty.Name = "txtInventoryROQty";
            this.txtInventoryROQty.Size = new System.Drawing.Size(100, 20);
            this.txtInventoryROQty.TabIndex = 13;
            this.txtInventoryROQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInventoryROQty.TextChanged += new System.EventHandler(this.txtInventoryROQty_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(303, 261);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Re-Order Qty";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInventoryROPoint
            // 
            this.txtInventoryROPoint.Location = new System.Drawing.Point(386, 234);
            this.txtInventoryROPoint.Name = "txtInventoryROPoint";
            this.txtInventoryROPoint.Size = new System.Drawing.Size(100, 20);
            this.txtInventoryROPoint.TabIndex = 11;
            this.txtInventoryROPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInventoryROPoint.TextChanged += new System.EventHandler(this.txtInventoryROPoint_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(303, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Re-Order Point";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInventoryQtyOnHand
            // 
            this.txtInventoryQtyOnHand.Location = new System.Drawing.Point(386, 211);
            this.txtInventoryQtyOnHand.Name = "txtInventoryQtyOnHand";
            this.txtInventoryQtyOnHand.Size = new System.Drawing.Size(100, 20);
            this.txtInventoryQtyOnHand.TabIndex = 9;
            this.txtInventoryQtyOnHand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInventoryQtyOnHand.TextChanged += new System.EventHandler(this.txtInventoryQtyOnHand_TextChanged);
            // 
            // txtInventoryDescription
            // 
            this.txtInventoryDescription.Location = new System.Drawing.Point(373, 60);
            this.txtInventoryDescription.Multiline = true;
            this.txtInventoryDescription.Name = "txtInventoryDescription";
            this.txtInventoryDescription.ReadOnly = true;
            this.txtInventoryDescription.Size = new System.Drawing.Size(221, 46);
            this.txtInventoryDescription.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(304, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Description:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Qty On Hand:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Inventory Items";
            // 
            // lbxInventory
            // 
            this.lbxInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxInventory.FormattingEnabled = true;
            this.lbxInventory.Location = new System.Drawing.Point(13, 38);
            this.lbxInventory.Name = "lbxInventory";
            this.lbxInventory.Size = new System.Drawing.Size(252, 316);
            this.lbxInventory.TabIndex = 1;
            this.lbxInventory.SelectedIndexChanged += new System.EventHandler(this.lbxInventory_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Image = global::PicassosInventorySystem.Properties.Resources.OK011;
            this.btnOK.Location = new System.Drawing.Point(554, 413);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 68);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "&OK";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNew.Image = global::PicassosInventorySystem.Properties.Resources.AddNewRecord;
            this.btnAddNew.Location = new System.Drawing.Point(260, 413);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 68);
            this.btnAddNew.TabIndex = 17;
            this.btnAddNew.Text = "&AddNew";
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Image = global::PicassosInventorySystem.Properties.Resources.deleteSmall;
            this.btnDelete.Location = new System.Drawing.Point(3, 413);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 68);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Image = global::PicassosInventorySystem.Properties.Resources.refreshSmall;
            this.btnClear.Location = new System.Drawing.Point(98, 413);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 68);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "&Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Image = global::PicassosInventorySystem.Properties.Resources.Save022;
            this.btnSave.Location = new System.Drawing.Point(179, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 68);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "&Update";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(301, 276);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "Comments:";
            // 
            // txtVendorComments
            // 
            this.txtVendorComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVendorComments.Location = new System.Drawing.Point(301, 292);
            this.txtVendorComments.Name = "txtVendorComments";
            this.txtVendorComments.Size = new System.Drawing.Size(297, 71);
            this.txtVendorComments.TabIndex = 14;
            this.txtVendorComments.Text = "";
            // 
            // volumeItemDetailsControl1
            // 
            this.volumeItemDetailsControl1.Location = new System.Drawing.Point(82, 38);
            this.volumeItemDetailsControl1.MinimunVolume = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.volumeItemDetailsControl1.Name = "volumeItemDetailsControl1";
            this.volumeItemDetailsControl1.Size = new System.Drawing.Size(167, 58);
            this.volumeItemDetailsControl1.TabIndex = 0;
            this.volumeItemDetailsControl1.UnitOfMeasure = "";
            this.volumeItemDetailsControl1.Visible = false;
            // 
            // boxedItemDetailsControl1
            // 
            this.boxedItemDetailsControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.boxedItemDetailsControl1.BoxCost = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.boxedItemDetailsControl1.Location = new System.Drawing.Point(77, 44);
            this.boxedItemDetailsControl1.Name = "boxedItemDetailsControl1";
            this.boxedItemDetailsControl1.Size = new System.Drawing.Size(222, 66);
            this.boxedItemDetailsControl1.TabIndex = 6;
            this.boxedItemDetailsControl1.UnitsInBox = 0;
            this.boxedItemDetailsControl1.Visible = false;
            // 
            // txtCatalogComments
            // 
            this.txtCatalogComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCatalogComments.Location = new System.Drawing.Point(289, 292);
            this.txtCatalogComments.Name = "txtCatalogComments";
            this.txtCatalogComments.Size = new System.Drawing.Size(315, 64);
            this.txtCatalogComments.TabIndex = 16;
            this.txtCatalogComments.Text = "";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(289, 276);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 13);
            this.label22.TabIndex = 15;
            this.label22.Text = "Comments:";
            // 
            // txtInventoryComments
            // 
            this.txtInventoryComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInventoryComments.Location = new System.Drawing.Point(294, 306);
            this.txtInventoryComments.Name = "txtInventoryComments";
            this.txtInventoryComments.Size = new System.Drawing.Size(315, 53);
            this.txtInventoryComments.TabIndex = 18;
            this.txtInventoryComments.Text = "";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(294, 286);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 13);
            this.label23.TabIndex = 17;
            this.label23.Text = "Comments:";
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 487);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabSystem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductsForm";
            this.Text = "Picasso Products";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductsForm_FormClosing);
            this.tabSystem.ResumeLayout(false);
            this.tabVendors.ResumeLayout(false);
            this.tabVendors.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabCatalog.ResumeLayout(false);
            this.tabCatalog.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabInventory.ResumeLayout(false);
            this.tabInventory.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSystem;
        private System.Windows.Forms.TabPage tabVendors;
        private System.Windows.Forms.TabPage tabCatalog;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxVendors;
        private System.Windows.Forms.TextBox txtVendorContactPerson;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVendorPhoneNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVendorZip;
        private System.Windows.Forms.TextBox txtVendorState;
        private System.Windows.Forms.TextBox txtVendorCity;
        private System.Windows.Forms.TextBox txtVendorStreet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUnitCost;
        private System.Windows.Forms.TextBox txtCatalogItemDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox lbxCatalogItems;
        private System.Windows.Forms.TextBox txtCatalogVendorProductId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxCatalogVendor;
        private System.Windows.Forms.GroupBox groupBox2;
        private BoxedItemDetailsControl boxedItemDetailsControl1;
        private System.Windows.Forms.RadioButton rdoCatalogVolume;
        private System.Windows.Forms.RadioButton rdoCatalogSingle;
        private System.Windows.Forms.RadioButton rdoCatalogBox;
        private VolumeItemDetailsControl volumeItemDetailsControl1;
        private System.Windows.Forms.TextBox txtCatalogUnitCost;
        private System.Windows.Forms.TextBox txtCatalogId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtInventoryQtyOnHand;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxLocation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtInventoryDescription;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox lbxInventory;
        private System.Windows.Forms.TextBox txtInventoryROPoint;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLocationDescription;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtInventoryROQty;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtInventoryId;
        private System.Windows.Forms.ComboBox cbxInventoryCatalogItem;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtVendorId;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RichTextBox txtVendorComments;
        private System.Windows.Forms.RichTextBox txtCatalogComments;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RichTextBox txtInventoryComments;
        private System.Windows.Forms.Label label23;
    }
}