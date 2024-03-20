namespace p01Grocery1
{
    partial class frmHome
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
            this.dataProducts = new System.Windows.Forms.DataGridView();
            this.prodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAll = new System.Windows.Forms.TabControl();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnProdSave = new System.Windows.Forms.Button();
            this.btnProdAdd = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProdType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCustClear = new System.Windows.Forms.Button();
            this.btnCustSave = new System.Windows.Forms.Button();
            this.btnCustAdd = new System.Windows.Forms.Button();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustMname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustFname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCustLname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataCustomers = new System.Windows.Forms.DataGridView();
            this.custID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custLname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custMname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.btnAddSales = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSalesProdID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSalesCustID = new System.Windows.Forms.TextBox();
            this.dataSales = new System.Windows.Forms.DataGridView();
            this.dataSalesCustomers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSalesProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSalesCustomer = new System.Windows.Forms.TextBox();
            this.txtSalesProdcut = new System.Windows.Forms.TextBox();
            this.salesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalsales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).BeginInit();
            this.tabAll.SuspendLayout();
            this.tabProducts.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomers)).BeginInit();
            this.tabSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSalesCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSalesProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dataProducts
            // 
            this.dataProducts.AllowUserToAddRows = false;
            this.dataProducts.AllowUserToDeleteRows = false;
            this.dataProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodID,
            this.prodName,
            this.prodType,
            this.manufacturer,
            this.price});
            this.dataProducts.Location = new System.Drawing.Point(304, 55);
            this.dataProducts.Name = "dataProducts";
            this.dataProducts.ReadOnly = true;
            this.dataProducts.RowHeadersWidth = 51;
            this.dataProducts.RowTemplate.Height = 24;
            this.dataProducts.Size = new System.Drawing.Size(991, 578);
            this.dataProducts.TabIndex = 0;
            this.dataProducts.SelectionChanged += new System.EventHandler(this.dataProducts_SelectionChanged);
            // 
            // prodID
            // 
            this.prodID.HeaderText = "Product ID";
            this.prodID.MinimumWidth = 6;
            this.prodID.Name = "prodID";
            this.prodID.ReadOnly = true;
            this.prodID.Width = 175;
            // 
            // prodName
            // 
            this.prodName.HeaderText = "Name";
            this.prodName.MinimumWidth = 6;
            this.prodName.Name = "prodName";
            this.prodName.ReadOnly = true;
            this.prodName.Width = 200;
            // 
            // prodType
            // 
            this.prodType.HeaderText = "Type";
            this.prodType.MinimumWidth = 6;
            this.prodType.Name = "prodType";
            this.prodType.ReadOnly = true;
            this.prodType.Width = 200;
            // 
            // manufacturer
            // 
            this.manufacturer.HeaderText = "Manufacturer";
            this.manufacturer.MinimumWidth = 6;
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.ReadOnly = true;
            this.manufacturer.Width = 200;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 150;
            // 
            // tabAll
            // 
            this.tabAll.Controls.Add(this.tabProducts);
            this.tabAll.Controls.Add(this.tabCustomers);
            this.tabAll.Controls.Add(this.tabSales);
            this.tabAll.Location = new System.Drawing.Point(12, 12);
            this.tabAll.Name = "tabAll";
            this.tabAll.SelectedIndex = 0;
            this.tabAll.Size = new System.Drawing.Size(1318, 708);
            this.tabAll.TabIndex = 1;
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.btnSearchProduct);
            this.tabProducts.Controls.Add(this.txtSearchProduct);
            this.tabProducts.Controls.Add(this.btnClearAll);
            this.tabProducts.Controls.Add(this.btnProdSave);
            this.tabProducts.Controls.Add(this.btnProdAdd);
            this.tabProducts.Controls.Add(this.txtPrice);
            this.tabProducts.Controls.Add(this.label5);
            this.tabProducts.Controls.Add(this.txtManufacturer);
            this.tabProducts.Controls.Add(this.label4);
            this.tabProducts.Controls.Add(this.txtProdType);
            this.tabProducts.Controls.Add(this.label3);
            this.tabProducts.Controls.Add(this.txtProdName);
            this.tabProducts.Controls.Add(this.label2);
            this.tabProducts.Controls.Add(this.txtProdID);
            this.tabProducts.Controls.Add(this.label1);
            this.tabProducts.Controls.Add(this.dataProducts);
            this.tabProducts.Location = new System.Drawing.Point(4, 29);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(1310, 675);
            this.tabProducts.TabIndex = 0;
            this.tabProducts.Text = "PRODUCTS";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClearAll.Location = new System.Drawing.Point(25, 578);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(239, 55);
            this.btnClearAll.TabIndex = 13;
            this.btnClearAll.Text = "CLEAR";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnProdSave
            // 
            this.btnProdSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProdSave.Location = new System.Drawing.Point(25, 520);
            this.btnProdSave.Name = "btnProdSave";
            this.btnProdSave.Size = new System.Drawing.Size(239, 51);
            this.btnProdSave.TabIndex = 12;
            this.btnProdSave.Text = "SAVE";
            this.btnProdSave.UseVisualStyleBackColor = false;
            this.btnProdSave.Click += new System.EventHandler(this.btnProdSave_Click);
            // 
            // btnProdAdd
            // 
            this.btnProdAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProdAdd.Location = new System.Drawing.Point(25, 464);
            this.btnProdAdd.Name = "btnProdAdd";
            this.btnProdAdd.Size = new System.Drawing.Size(239, 49);
            this.btnProdAdd.TabIndex = 11;
            this.btnProdAdd.Text = "ADD";
            this.btnProdAdd.UseVisualStyleBackColor = false;
            this.btnProdAdd.Click += new System.EventHandler(this.btnProdAdd_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(25, 417);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(239, 26);
            this.txtPrice.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price:";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(25, 330);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(239, 26);
            this.txtManufacturer.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Manufacturer:";
            // 
            // txtProdType
            // 
            this.txtProdType.Location = new System.Drawing.Point(25, 247);
            this.txtProdType.Name = "txtProdType";
            this.txtProdType.Size = new System.Drawing.Size(239, 26);
            this.txtProdType.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product Type:";
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(25, 162);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(239, 26);
            this.txtProdName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Name:";
            // 
            // txtProdID
            // 
            this.txtProdID.Enabled = false;
            this.txtProdID.Location = new System.Drawing.Point(25, 84);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.Size = new System.Drawing.Size(139, 26);
            this.txtProdID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product ID:";
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.btnCustomerSearch);
            this.tabCustomers.Controls.Add(this.txtCustomerSearch);
            this.tabCustomers.Controls.Add(this.txtAddress);
            this.tabCustomers.Controls.Add(this.label11);
            this.tabCustomers.Controls.Add(this.btnCustClear);
            this.tabCustomers.Controls.Add(this.btnCustSave);
            this.tabCustomers.Controls.Add(this.btnCustAdd);
            this.tabCustomers.Controls.Add(this.txtSex);
            this.tabCustomers.Controls.Add(this.label6);
            this.tabCustomers.Controls.Add(this.txtCustMname);
            this.tabCustomers.Controls.Add(this.label7);
            this.tabCustomers.Controls.Add(this.txtCustFname);
            this.tabCustomers.Controls.Add(this.label8);
            this.tabCustomers.Controls.Add(this.txtCustLname);
            this.tabCustomers.Controls.Add(this.label9);
            this.tabCustomers.Controls.Add(this.txtCustID);
            this.tabCustomers.Controls.Add(this.label10);
            this.tabCustomers.Controls.Add(this.dataCustomers);
            this.tabCustomers.Location = new System.Drawing.Point(4, 29);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(1310, 675);
            this.tabCustomers.TabIndex = 1;
            this.tabCustomers.Text = "CUSTOMERS";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(23, 351);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(239, 26);
            this.txtAddress.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Address:";
            // 
            // btnCustClear
            // 
            this.btnCustClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCustClear.Location = new System.Drawing.Point(23, 583);
            this.btnCustClear.Name = "btnCustClear";
            this.btnCustClear.Size = new System.Drawing.Size(239, 55);
            this.btnCustClear.TabIndex = 27;
            this.btnCustClear.Text = "CLEAR";
            this.btnCustClear.UseVisualStyleBackColor = false;
            this.btnCustClear.Click += new System.EventHandler(this.btnCustClear_Click);
            // 
            // btnCustSave
            // 
            this.btnCustSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCustSave.Location = new System.Drawing.Point(23, 525);
            this.btnCustSave.Name = "btnCustSave";
            this.btnCustSave.Size = new System.Drawing.Size(239, 51);
            this.btnCustSave.TabIndex = 26;
            this.btnCustSave.Text = "SAVE";
            this.btnCustSave.UseVisualStyleBackColor = false;
            this.btnCustSave.Click += new System.EventHandler(this.btnCustSave_Click);
            // 
            // btnCustAdd
            // 
            this.btnCustAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCustAdd.Location = new System.Drawing.Point(23, 469);
            this.btnCustAdd.Name = "btnCustAdd";
            this.btnCustAdd.Size = new System.Drawing.Size(239, 49);
            this.btnCustAdd.TabIndex = 25;
            this.btnCustAdd.Text = "ADD";
            this.btnCustAdd.UseVisualStyleBackColor = false;
            this.btnCustAdd.Click += new System.EventHandler(this.btnCustAdd_Click);
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(23, 422);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(239, 26);
            this.txtSex.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Sex:";
            // 
            // txtCustMname
            // 
            this.txtCustMname.Location = new System.Drawing.Point(23, 281);
            this.txtCustMname.Name = "txtCustMname";
            this.txtCustMname.Size = new System.Drawing.Size(239, 26);
            this.txtCustMname.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Middle Name:";
            // 
            // txtCustFname
            // 
            this.txtCustFname.Location = new System.Drawing.Point(23, 210);
            this.txtCustFname.Name = "txtCustFname";
            this.txtCustFname.Size = new System.Drawing.Size(239, 26);
            this.txtCustFname.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "First Name:";
            // 
            // txtCustLname
            // 
            this.txtCustLname.Location = new System.Drawing.Point(23, 144);
            this.txtCustLname.Name = "txtCustLname";
            this.txtCustLname.Size = new System.Drawing.Size(239, 26);
            this.txtCustLname.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Last Name:";
            // 
            // txtCustID
            // 
            this.txtCustID.Enabled = false;
            this.txtCustID.Location = new System.Drawing.Point(23, 75);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(139, 26);
            this.txtCustID.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Customer ID:";
            // 
            // dataCustomers
            // 
            this.dataCustomers.AllowUserToAddRows = false;
            this.dataCustomers.AllowUserToDeleteRows = false;
            this.dataCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custID,
            this.custLname,
            this.custFname,
            this.custMname,
            this.custAddress,
            this.sex});
            this.dataCustomers.Location = new System.Drawing.Point(302, 46);
            this.dataCustomers.Name = "dataCustomers";
            this.dataCustomers.ReadOnly = true;
            this.dataCustomers.RowHeadersWidth = 51;
            this.dataCustomers.RowTemplate.Height = 24;
            this.dataCustomers.Size = new System.Drawing.Size(991, 592);
            this.dataCustomers.TabIndex = 14;
            this.dataCustomers.SelectionChanged += new System.EventHandler(this.dataCustomers_SelectionChanged);
            // 
            // custID
            // 
            this.custID.HeaderText = "ID";
            this.custID.MinimumWidth = 6;
            this.custID.Name = "custID";
            this.custID.ReadOnly = true;
            this.custID.Width = 125;
            // 
            // custLname
            // 
            this.custLname.HeaderText = "Last Name";
            this.custLname.MinimumWidth = 6;
            this.custLname.Name = "custLname";
            this.custLname.ReadOnly = true;
            this.custLname.Width = 175;
            // 
            // custFname
            // 
            this.custFname.HeaderText = "First Name";
            this.custFname.MinimumWidth = 6;
            this.custFname.Name = "custFname";
            this.custFname.ReadOnly = true;
            this.custFname.Width = 175;
            // 
            // custMname
            // 
            this.custMname.HeaderText = "Middle Name";
            this.custMname.MinimumWidth = 6;
            this.custMname.Name = "custMname";
            this.custMname.ReadOnly = true;
            this.custMname.Width = 175;
            // 
            // custAddress
            // 
            this.custAddress.HeaderText = "Address";
            this.custAddress.MinimumWidth = 6;
            this.custAddress.Name = "custAddress";
            this.custAddress.ReadOnly = true;
            this.custAddress.Width = 150;
            // 
            // sex
            // 
            this.sex.HeaderText = "Sex";
            this.sex.MinimumWidth = 6;
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            this.sex.Width = 125;
            // 
            // tabSales
            // 
            this.tabSales.Controls.Add(this.txtSalesProdcut);
            this.tabSales.Controls.Add(this.txtSalesCustomer);
            this.tabSales.Controls.Add(this.btnAddSales);
            this.tabSales.Controls.Add(this.label14);
            this.tabSales.Controls.Add(this.txtQuantity);
            this.tabSales.Controls.Add(this.label13);
            this.tabSales.Controls.Add(this.txtSalesProdID);
            this.tabSales.Controls.Add(this.label12);
            this.tabSales.Controls.Add(this.txtSalesCustID);
            this.tabSales.Controls.Add(this.dataSales);
            this.tabSales.Controls.Add(this.dataSalesCustomers);
            this.tabSales.Controls.Add(this.dataSalesProduct);
            this.tabSales.Location = new System.Drawing.Point(4, 29);
            this.tabSales.Name = "tabSales";
            this.tabSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabSales.Size = new System.Drawing.Size(1310, 675);
            this.tabSales.TabIndex = 2;
            this.tabSales.Text = "SALES";
            this.tabSales.UseVisualStyleBackColor = true;
            // 
            // btnAddSales
            // 
            this.btnAddSales.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddSales.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddSales.Location = new System.Drawing.Point(6, 326);
            this.btnAddSales.Name = "btnAddSales";
            this.btnAddSales.Size = new System.Drawing.Size(174, 50);
            this.btnAddSales.TabIndex = 23;
            this.btnAddSales.Text = "BUY";
            this.btnAddSales.UseVisualStyleBackColor = false;
            this.btnAddSales.Click += new System.EventHandler(this.btnAddSales_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(6, 267);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(174, 26);
            this.txtQuantity.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Product ID:";
            // 
            // txtSalesProdID
            // 
            this.txtSalesProdID.Enabled = false;
            this.txtSalesProdID.Location = new System.Drawing.Point(97, 143);
            this.txtSalesProdID.Name = "txtSalesProdID";
            this.txtSalesProdID.Size = new System.Drawing.Size(83, 26);
            this.txtSalesProdID.TabIndex = 19;
            this.txtSalesProdID.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Customer ID:";
            // 
            // txtSalesCustID
            // 
            this.txtSalesCustID.Enabled = false;
            this.txtSalesCustID.Location = new System.Drawing.Point(111, 57);
            this.txtSalesCustID.Name = "txtSalesCustID";
            this.txtSalesCustID.Size = new System.Drawing.Size(69, 26);
            this.txtSalesCustID.TabIndex = 17;
            this.txtSalesCustID.Visible = false;
            // 
            // dataSales
            // 
            this.dataSales.AllowUserToAddRows = false;
            this.dataSales.AllowUserToDeleteRows = false;
            this.dataSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesID,
            this.customer,
            this.product,
            this.salesprice,
            this.quantity,
            this.totalsales,
            this.datePurchase});
            this.dataSales.Location = new System.Drawing.Point(205, 499);
            this.dataSales.Name = "dataSales";
            this.dataSales.ReadOnly = true;
            this.dataSales.Size = new System.Drawing.Size(1039, 176);
            this.dataSales.TabIndex = 16;
            // 
            // dataSalesCustomers
            // 
            this.dataSalesCustomers.AllowUserToAddRows = false;
            this.dataSalesCustomers.AllowUserToDeleteRows = false;
            this.dataSalesCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSalesCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dataSalesCustomers.Location = new System.Drawing.Point(205, 24);
            this.dataSalesCustomers.Name = "dataSalesCustomers";
            this.dataSalesCustomers.ReadOnly = true;
            this.dataSalesCustomers.RowHeadersWidth = 51;
            this.dataSalesCustomers.RowTemplate.Height = 24;
            this.dataSalesCustomers.Size = new System.Drawing.Size(1039, 223);
            this.dataSalesCustomers.TabIndex = 15;
            this.dataSalesCustomers.SelectionChanged += new System.EventHandler(this.dataSalesCustomers_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 175;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 175;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Middle Name";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 175;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Address";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Sex";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataSalesProduct
            // 
            this.dataSalesProduct.AllowUserToAddRows = false;
            this.dataSalesProduct.AllowUserToDeleteRows = false;
            this.dataSalesProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSalesProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataSalesProduct.Location = new System.Drawing.Point(205, 289);
            this.dataSalesProduct.Name = "dataSalesProduct";
            this.dataSalesProduct.ReadOnly = true;
            this.dataSalesProduct.RowHeadersWidth = 51;
            this.dataSalesProduct.RowTemplate.Height = 24;
            this.dataSalesProduct.Size = new System.Drawing.Size(1039, 181);
            this.dataSalesProduct.TabIndex = 1;
            this.dataSalesProduct.SelectionChanged += new System.EventHandler(this.dataSalesProduct_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Product ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 175;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Manufacturer";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Price";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // txtSalesCustomer
            // 
            this.txtSalesCustomer.Location = new System.Drawing.Point(6, 86);
            this.txtSalesCustomer.Name = "txtSalesCustomer";
            this.txtSalesCustomer.Size = new System.Drawing.Size(174, 26);
            this.txtSalesCustomer.TabIndex = 24;
            // 
            // txtSalesProdcut
            // 
            this.txtSalesProdcut.Location = new System.Drawing.Point(6, 181);
            this.txtSalesProdcut.Name = "txtSalesProdcut";
            this.txtSalesProdcut.Size = new System.Drawing.Size(174, 26);
            this.txtSalesProdcut.TabIndex = 25;
            // 
            // salesID
            // 
            this.salesID.HeaderText = "Sales ID";
            this.salesID.Name = "salesID";
            this.salesID.ReadOnly = true;
            this.salesID.Width = 150;
            // 
            // customer
            // 
            this.customer.HeaderText = "Customer";
            this.customer.Name = "customer";
            this.customer.ReadOnly = true;
            this.customer.Width = 175;
            // 
            // product
            // 
            this.product.HeaderText = "Product";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            this.product.Width = 175;
            // 
            // salesprice
            // 
            this.salesprice.HeaderText = "Price";
            this.salesprice.Name = "salesprice";
            this.salesprice.ReadOnly = true;
            this.salesprice.Width = 125;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 150;
            // 
            // totalsales
            // 
            this.totalsales.HeaderText = "Total Sales";
            this.totalsales.Name = "totalsales";
            this.totalsales.ReadOnly = true;
            this.totalsales.Width = 150;
            // 
            // datePurchase
            // 
            this.datePurchase.HeaderText = "Date";
            this.datePurchase.Name = "datePurchase";
            this.datePurchase.ReadOnly = true;
            this.datePurchase.Width = 125;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(304, 25);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(599, 26);
            this.txtSearchProduct.TabIndex = 14;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(936, 18);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(119, 33);
            this.btnSearchProduct.TabIndex = 15;
            this.btnSearchProduct.Text = "SEARCH";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Location = new System.Drawing.Point(352, 14);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(406, 26);
            this.txtCustomerSearch.TabIndex = 29;
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.Location = new System.Drawing.Point(903, 6);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(94, 34);
            this.btnCustomerSearch.TabIndex = 30;
            this.btnCustomerSearch.Text = "SEARCH";
            this.btnCustomerSearch.UseVisualStyleBackColor = true;
            this.btnCustomerSearch.Click += new System.EventHandler(this.btnCustomerSearch_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 812);
            this.Controls.Add(this.tabAll);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHome";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).EndInit();
            this.tabAll.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);
            this.tabProducts.PerformLayout();
            this.tabCustomers.ResumeLayout(false);
            this.tabCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomers)).EndInit();
            this.tabSales.ResumeLayout(false);
            this.tabSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSalesCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSalesProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.TabControl tabAll;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.Button btnProdAdd;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProdType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProdSave;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCustClear;
        private System.Windows.Forms.Button btnCustSave;
        private System.Windows.Forms.Button btnCustAdd;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustMname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustFname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustLname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn custID;
        private System.Windows.Forms.DataGridViewTextBoxColumn custLname;
        private System.Windows.Forms.DataGridViewTextBoxColumn custFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn custMname;
        private System.Windows.Forms.DataGridViewTextBoxColumn custAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.TabPage tabSales;
        private System.Windows.Forms.DataGridView dataSalesCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridView dataSalesProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView dataSales;
        private System.Windows.Forms.TextBox txtSalesCustID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSalesProdID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddSales;
        private System.Windows.Forms.TextBox txtSalesProdcut;
        private System.Windows.Forms.TextBox txtSalesCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalsales;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePurchase;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Button btnCustomerSearch;
        private System.Windows.Forms.TextBox txtCustomerSearch;
    }
}

