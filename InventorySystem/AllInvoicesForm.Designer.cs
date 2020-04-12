namespace InventorySystem
{
    partial class AllInvoicesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab_Invoices = new System.Windows.Forms.TabControl();
            this.tab_PurchaseInvoices = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_ToPurchase = new System.Windows.Forms.DateTimePicker();
            this.dtp_FromPurchase = new System.Windows.Forms.DateTimePicker();
            this.rb_dayPurchase = new System.Windows.Forms.RadioButton();
            this.rb_ChoosePurchase = new System.Windows.Forms.RadioButton();
            this.rb_WeekPurchase = new System.Windows.Forms.RadioButton();
            this.rb_AllPurchase = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_PurchaseInvoices = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_invoice = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_ToInvoice = new System.Windows.Forms.DateTimePicker();
            this.dtp_FromInvoice = new System.Windows.Forms.DateTimePicker();
            this.rb_DayInvoice = new System.Windows.Forms.RadioButton();
            this.rb_ChooseInvoice = new System.Windows.Forms.RadioButton();
            this.rb_WeekInvoice = new System.Windows.Forms.RadioButton();
            this.rb_AllInvoice = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Invoices = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_inventory = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Inventories = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_ToInventory = new System.Windows.Forms.DateTimePicker();
            this.dtp_FromInventory = new System.Windows.Forms.DateTimePicker();
            this.rb_DayInventory = new System.Windows.Forms.RadioButton();
            this.rb_ChooseInventory = new System.Windows.Forms.RadioButton();
            this.rb_WeekInventory = new System.Windows.Forms.RadioButton();
            this.rb_AllInventory = new System.Windows.Forms.RadioButton();
            this.tab_Invoices.SuspendLayout();
            this.tab_PurchaseInvoices.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PurchaseInvoices)).BeginInit();
            this.tab_invoice.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoices)).BeginInit();
            this.tab_inventory.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventories)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Invoices
            // 
            this.tab_Invoices.Controls.Add(this.tab_PurchaseInvoices);
            this.tab_Invoices.Controls.Add(this.tab_invoice);
            this.tab_Invoices.Controls.Add(this.tab_inventory);
            this.tab_Invoices.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab_Invoices.Location = new System.Drawing.Point(3, 12);
            this.tab_Invoices.Name = "tab_Invoices";
            this.tab_Invoices.SelectedIndex = 0;
            this.tab_Invoices.Size = new System.Drawing.Size(869, 565);
            this.tab_Invoices.TabIndex = 0;
            // 
            // tab_PurchaseInvoices
            // 
            this.tab_PurchaseInvoices.Controls.Add(this.groupBox1);
            this.tab_PurchaseInvoices.Controls.Add(this.panel3);
            this.tab_PurchaseInvoices.Location = new System.Drawing.Point(4, 28);
            this.tab_PurchaseInvoices.Name = "tab_PurchaseInvoices";
            this.tab_PurchaseInvoices.Padding = new System.Windows.Forms.Padding(3);
            this.tab_PurchaseInvoices.Size = new System.Drawing.Size(861, 533);
            this.tab_PurchaseInvoices.TabIndex = 0;
            this.tab_PurchaseInvoices.Text = "Приходные накладные";
            this.tab_PurchaseInvoices.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_ToPurchase);
            this.groupBox1.Controls.Add(this.dtp_FromPurchase);
            this.groupBox1.Controls.Add(this.rb_dayPurchase);
            this.groupBox1.Controls.Add(this.rb_ChoosePurchase);
            this.groupBox1.Controls.Add(this.rb_WeekPurchase);
            this.groupBox1.Controls.Add(this.rb_AllPurchase);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 100);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Период";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "по";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "c";
            // 
            // dtp_ToPurchase
            // 
            this.dtp_ToPurchase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ToPurchase.Location = new System.Drawing.Point(612, 55);
            this.dtp_ToPurchase.Name = "dtp_ToPurchase";
            this.dtp_ToPurchase.Size = new System.Drawing.Size(231, 27);
            this.dtp_ToPurchase.TabIndex = 26;
            this.dtp_ToPurchase.ValueChanged += new System.EventHandler(this.dtp_FromPurchase_ValueChanged);
            // 
            // dtp_FromPurchase
            // 
            this.dtp_FromPurchase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FromPurchase.Location = new System.Drawing.Point(354, 55);
            this.dtp_FromPurchase.Name = "dtp_FromPurchase";
            this.dtp_FromPurchase.Size = new System.Drawing.Size(219, 27);
            this.dtp_FromPurchase.TabIndex = 25;
            this.dtp_FromPurchase.ValueChanged += new System.EventHandler(this.dtp_FromPurchase_ValueChanged);
            // 
            // rb_dayPurchase
            // 
            this.rb_dayPurchase.AutoSize = true;
            this.rb_dayPurchase.Location = new System.Drawing.Point(17, 26);
            this.rb_dayPurchase.Name = "rb_dayPurchase";
            this.rb_dayPurchase.Size = new System.Drawing.Size(81, 23);
            this.rb_dayPurchase.TabIndex = 21;
            this.rb_dayPurchase.TabStop = true;
            this.rb_dayPurchase.Text = "за день";
            this.rb_dayPurchase.UseVisualStyleBackColor = true;
            this.rb_dayPurchase.CheckedChanged += new System.EventHandler(this.rbPurchase_CheckedChanged);
            // 
            // rb_ChoosePurchase
            // 
            this.rb_ChoosePurchase.AutoSize = true;
            this.rb_ChoosePurchase.Location = new System.Drawing.Point(192, 55);
            this.rb_ChoosePurchase.Name = "rb_ChoosePurchase";
            this.rb_ChoosePurchase.Size = new System.Drawing.Size(103, 23);
            this.rb_ChoosePurchase.TabIndex = 24;
            this.rb_ChoosePurchase.TabStop = true;
            this.rb_ChoosePurchase.Text = "выбор дат";
            this.rb_ChoosePurchase.UseVisualStyleBackColor = true;
            this.rb_ChoosePurchase.CheckedChanged += new System.EventHandler(this.rbPurchase_CheckedChanged);
            // 
            // rb_WeekPurchase
            // 
            this.rb_WeekPurchase.AutoSize = true;
            this.rb_WeekPurchase.Location = new System.Drawing.Point(17, 55);
            this.rb_WeekPurchase.Name = "rb_WeekPurchase";
            this.rb_WeekPurchase.Size = new System.Drawing.Size(102, 23);
            this.rb_WeekPurchase.TabIndex = 22;
            this.rb_WeekPurchase.TabStop = true;
            this.rb_WeekPurchase.Text = "за неделю";
            this.rb_WeekPurchase.UseVisualStyleBackColor = true;
            this.rb_WeekPurchase.CheckedChanged += new System.EventHandler(this.rbPurchase_CheckedChanged);
            // 
            // rb_AllPurchase
            // 
            this.rb_AllPurchase.AutoSize = true;
            this.rb_AllPurchase.Location = new System.Drawing.Point(192, 26);
            this.rb_AllPurchase.Name = "rb_AllPurchase";
            this.rb_AllPurchase.Size = new System.Drawing.Size(118, 23);
            this.rb_AllPurchase.TabIndex = 23;
            this.rb_AllPurchase.TabStop = true;
            this.rb_AllPurchase.Text = "за все время";
            this.rb_AllPurchase.UseVisualStyleBackColor = true;
            this.rb_AllPurchase.CheckedChanged += new System.EventHandler(this.rbPurchase_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_PurchaseInvoices);
            this.panel3.Location = new System.Drawing.Point(3, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(852, 415);
            this.panel3.TabIndex = 20;
            // 
            // dgv_PurchaseInvoices
            // 
            this.dgv_PurchaseInvoices.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_PurchaseInvoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_PurchaseInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PurchaseInvoices.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_PurchaseInvoices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_PurchaseInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PurchaseInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Unit,
            this.Count});
            this.dgv_PurchaseInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_PurchaseInvoices.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_PurchaseInvoices.Location = new System.Drawing.Point(0, 0);
            this.dgv_PurchaseInvoices.Name = "dgv_PurchaseInvoices";
            this.dgv_PurchaseInvoices.ReadOnly = true;
            this.dgv_PurchaseInvoices.Size = new System.Drawing.Size(852, 415);
            this.dgv_PurchaseInvoices.TabIndex = 10;
            this.dgv_PurchaseInvoices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ДАТА";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "ПОСТАВЩИК";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.HeaderText = "НОМЕР НАКЛАДНОЙ";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // tab_invoice
            // 
            this.tab_invoice.Controls.Add(this.groupBox2);
            this.tab_invoice.Controls.Add(this.panel1);
            this.tab_invoice.Location = new System.Drawing.Point(4, 28);
            this.tab_invoice.Name = "tab_invoice";
            this.tab_invoice.Padding = new System.Windows.Forms.Padding(3);
            this.tab_invoice.Size = new System.Drawing.Size(861, 533);
            this.tab_invoice.TabIndex = 1;
            this.tab_invoice.Text = "Накладные";
            this.tab_invoice.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtp_ToInvoice);
            this.groupBox2.Controls.Add(this.dtp_FromInvoice);
            this.groupBox2.Controls.Add(this.rb_DayInvoice);
            this.groupBox2.Controls.Add(this.rb_ChooseInvoice);
            this.groupBox2.Controls.Add(this.rb_WeekInvoice);
            this.groupBox2.Controls.Add(this.rb_AllInvoice);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(848, 100);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Период";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "по";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "c";
            // 
            // dtp_ToInvoice
            // 
            this.dtp_ToInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ToInvoice.Location = new System.Drawing.Point(612, 55);
            this.dtp_ToInvoice.Name = "dtp_ToInvoice";
            this.dtp_ToInvoice.Size = new System.Drawing.Size(231, 27);
            this.dtp_ToInvoice.TabIndex = 26;
            this.dtp_ToInvoice.ValueChanged += new System.EventHandler(this.dtp_FromInvoice_ValueChanged);
            // 
            // dtp_FromInvoice
            // 
            this.dtp_FromInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FromInvoice.Location = new System.Drawing.Point(354, 55);
            this.dtp_FromInvoice.Name = "dtp_FromInvoice";
            this.dtp_FromInvoice.Size = new System.Drawing.Size(219, 27);
            this.dtp_FromInvoice.TabIndex = 25;
            this.dtp_FromInvoice.ValueChanged += new System.EventHandler(this.dtp_FromInvoice_ValueChanged);
            // 
            // rb_DayInvoice
            // 
            this.rb_DayInvoice.AutoSize = true;
            this.rb_DayInvoice.Location = new System.Drawing.Point(17, 26);
            this.rb_DayInvoice.Name = "rb_DayInvoice";
            this.rb_DayInvoice.Size = new System.Drawing.Size(81, 23);
            this.rb_DayInvoice.TabIndex = 21;
            this.rb_DayInvoice.TabStop = true;
            this.rb_DayInvoice.Text = "за день";
            this.rb_DayInvoice.UseVisualStyleBackColor = true;
            this.rb_DayInvoice.CheckedChanged += new System.EventHandler(this.rbInvoice_CheckedChanged);
            // 
            // rb_ChooseInvoice
            // 
            this.rb_ChooseInvoice.AutoSize = true;
            this.rb_ChooseInvoice.Location = new System.Drawing.Point(192, 55);
            this.rb_ChooseInvoice.Name = "rb_ChooseInvoice";
            this.rb_ChooseInvoice.Size = new System.Drawing.Size(103, 23);
            this.rb_ChooseInvoice.TabIndex = 24;
            this.rb_ChooseInvoice.TabStop = true;
            this.rb_ChooseInvoice.Text = "выбор дат";
            this.rb_ChooseInvoice.UseVisualStyleBackColor = true;
            this.rb_ChooseInvoice.CheckedChanged += new System.EventHandler(this.rbInvoice_CheckedChanged);
            // 
            // rb_WeekInvoice
            // 
            this.rb_WeekInvoice.AutoSize = true;
            this.rb_WeekInvoice.Location = new System.Drawing.Point(17, 55);
            this.rb_WeekInvoice.Name = "rb_WeekInvoice";
            this.rb_WeekInvoice.Size = new System.Drawing.Size(102, 23);
            this.rb_WeekInvoice.TabIndex = 22;
            this.rb_WeekInvoice.TabStop = true;
            this.rb_WeekInvoice.Text = "за неделю";
            this.rb_WeekInvoice.UseVisualStyleBackColor = true;
            this.rb_WeekInvoice.CheckedChanged += new System.EventHandler(this.rbInvoice_CheckedChanged);
            // 
            // rb_AllInvoice
            // 
            this.rb_AllInvoice.AutoSize = true;
            this.rb_AllInvoice.Location = new System.Drawing.Point(192, 26);
            this.rb_AllInvoice.Name = "rb_AllInvoice";
            this.rb_AllInvoice.Size = new System.Drawing.Size(118, 23);
            this.rb_AllInvoice.TabIndex = 23;
            this.rb_AllInvoice.TabStop = true;
            this.rb_AllInvoice.Text = "за все время";
            this.rb_AllInvoice.UseVisualStyleBackColor = true;
            this.rb_AllInvoice.CheckedChanged += new System.EventHandler(this.rbInvoice_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_Invoices);
            this.panel1.Location = new System.Drawing.Point(3, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 418);
            this.panel1.TabIndex = 21;
            // 
            // dgv_Invoices
            // 
            this.dgv_Invoices.AllowUserToAddRows = false;
            this.dgv_Invoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Invoices.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Invoices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_Invoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Invoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgv_Invoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Invoices.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Invoices.Location = new System.Drawing.Point(0, 0);
            this.dgv_Invoices.Name = "dgv_Invoices";
            this.dgv_Invoices.ReadOnly = true;
            this.dgv_Invoices.Size = new System.Drawing.Size(851, 418);
            this.dgv_Invoices.TabIndex = 10;
            this.dgv_Invoices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ДАТА";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "КОМУ(ЧЕРЕЗ КОГО)";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "НАЗНАЧЕНИЕ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "НОМЕР НАКЛАДНОЙ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tab_inventory
            // 
            this.tab_inventory.Controls.Add(this.groupBox3);
            this.tab_inventory.Controls.Add(this.panel2);
            this.tab_inventory.Location = new System.Drawing.Point(4, 28);
            this.tab_inventory.Name = "tab_inventory";
            this.tab_inventory.Padding = new System.Windows.Forms.Padding(3);
            this.tab_inventory.Size = new System.Drawing.Size(861, 533);
            this.tab_inventory.TabIndex = 2;
            this.tab_inventory.Text = "Инвентаризации";
            this.tab_inventory.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_Inventories);
            this.panel2.Location = new System.Drawing.Point(3, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 418);
            this.panel2.TabIndex = 21;
            // 
            // dgv_Inventories
            // 
            this.dgv_Inventories.AllowUserToAddRows = false;
            this.dgv_Inventories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Inventories.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Inventories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_Inventories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Inventories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgv_Inventories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Inventories.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Inventories.Location = new System.Drawing.Point(0, 0);
            this.dgv_Inventories.Name = "dgv_Inventories";
            this.dgv_Inventories.ReadOnly = true;
            this.dgv_Inventories.Size = new System.Drawing.Size(849, 418);
            this.dgv_Inventories.TabIndex = 10;
            this.dgv_Inventories.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "ДАТА";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ОТВЕТСТВЕННЫЙ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "НОМЕР";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dtp_ToInventory);
            this.groupBox3.Controls.Add(this.dtp_FromInventory);
            this.groupBox3.Controls.Add(this.rb_DayInventory);
            this.groupBox3.Controls.Add(this.rb_ChooseInventory);
            this.groupBox3.Controls.Add(this.rb_WeekInventory);
            this.groupBox3.Controls.Add(this.rb_AllInventory);
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(849, 100);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Период";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "по";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "c";
            // 
            // dtp_ToInventory
            // 
            this.dtp_ToInventory.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ToInventory.Location = new System.Drawing.Point(612, 55);
            this.dtp_ToInventory.Name = "dtp_ToInventory";
            this.dtp_ToInventory.Size = new System.Drawing.Size(231, 27);
            this.dtp_ToInventory.TabIndex = 26;
            this.dtp_ToInventory.ValueChanged += new System.EventHandler(this.dtp_FromInventory_ValueChanged);
            // 
            // dtp_FromInventory
            // 
            this.dtp_FromInventory.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FromInventory.Location = new System.Drawing.Point(354, 55);
            this.dtp_FromInventory.Name = "dtp_FromInventory";
            this.dtp_FromInventory.Size = new System.Drawing.Size(219, 27);
            this.dtp_FromInventory.TabIndex = 25;
            this.dtp_FromInventory.ValueChanged += new System.EventHandler(this.dtp_FromInventory_ValueChanged);
            // 
            // rb_DayInventory
            // 
            this.rb_DayInventory.AutoSize = true;
            this.rb_DayInventory.Location = new System.Drawing.Point(17, 26);
            this.rb_DayInventory.Name = "rb_DayInventory";
            this.rb_DayInventory.Size = new System.Drawing.Size(81, 23);
            this.rb_DayInventory.TabIndex = 21;
            this.rb_DayInventory.TabStop = true;
            this.rb_DayInventory.Text = "за день";
            this.rb_DayInventory.UseVisualStyleBackColor = true;
            this.rb_DayInventory.CheckedChanged += new System.EventHandler(this.rbInventory_CheckedChanged);
            // 
            // rb_ChooseInventory
            // 
            this.rb_ChooseInventory.AutoSize = true;
            this.rb_ChooseInventory.Location = new System.Drawing.Point(192, 55);
            this.rb_ChooseInventory.Name = "rb_ChooseInventory";
            this.rb_ChooseInventory.Size = new System.Drawing.Size(103, 23);
            this.rb_ChooseInventory.TabIndex = 24;
            this.rb_ChooseInventory.TabStop = true;
            this.rb_ChooseInventory.Text = "выбор дат";
            this.rb_ChooseInventory.UseVisualStyleBackColor = true;
            this.rb_ChooseInventory.CheckedChanged += new System.EventHandler(this.rbInventory_CheckedChanged);
            // 
            // rb_WeekInventory
            // 
            this.rb_WeekInventory.AutoSize = true;
            this.rb_WeekInventory.Location = new System.Drawing.Point(17, 55);
            this.rb_WeekInventory.Name = "rb_WeekInventory";
            this.rb_WeekInventory.Size = new System.Drawing.Size(102, 23);
            this.rb_WeekInventory.TabIndex = 22;
            this.rb_WeekInventory.TabStop = true;
            this.rb_WeekInventory.Text = "за неделю";
            this.rb_WeekInventory.UseVisualStyleBackColor = true;
            this.rb_WeekInventory.CheckedChanged += new System.EventHandler(this.rbInventory_CheckedChanged);
            // 
            // rb_AllInventory
            // 
            this.rb_AllInventory.AutoSize = true;
            this.rb_AllInventory.Location = new System.Drawing.Point(192, 26);
            this.rb_AllInventory.Name = "rb_AllInventory";
            this.rb_AllInventory.Size = new System.Drawing.Size(118, 23);
            this.rb_AllInventory.TabIndex = 23;
            this.rb_AllInventory.TabStop = true;
            this.rb_AllInventory.Text = "за все время";
            this.rb_AllInventory.UseVisualStyleBackColor = true;
            this.rb_AllInventory.CheckedChanged += new System.EventHandler(this.rbInventory_CheckedChanged);
            // 
            // AllInvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(884, 581);
            this.Controls.Add(this.tab_Invoices);
            this.MaximumSize = new System.Drawing.Size(900, 620);
            this.MinimumSize = new System.Drawing.Size(900, 620);
            this.Name = "AllInvoicesForm";
            this.Text = "Счета-фактуры и произведенные инвентаризации";
            this.tab_Invoices.ResumeLayout(false);
            this.tab_PurchaseInvoices.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PurchaseInvoices)).EndInit();
            this.tab_invoice.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoices)).EndInit();
            this.tab_inventory.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventories)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Invoices;
        private System.Windows.Forms.TabPage tab_PurchaseInvoices;
        private System.Windows.Forms.TabPage tab_invoice;
        private System.Windows.Forms.TabPage tab_inventory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_PurchaseInvoices;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Invoices;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_Inventories;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_ToPurchase;
        private System.Windows.Forms.DateTimePicker dtp_FromPurchase;
        private System.Windows.Forms.RadioButton rb_dayPurchase;
        private System.Windows.Forms.RadioButton rb_ChoosePurchase;
        private System.Windows.Forms.RadioButton rb_WeekPurchase;
        private System.Windows.Forms.RadioButton rb_AllPurchase;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_ToInvoice;
        private System.Windows.Forms.DateTimePicker dtp_FromInvoice;
        private System.Windows.Forms.RadioButton rb_DayInvoice;
        private System.Windows.Forms.RadioButton rb_ChooseInvoice;
        private System.Windows.Forms.RadioButton rb_WeekInvoice;
        private System.Windows.Forms.RadioButton rb_AllInvoice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_ToInventory;
        private System.Windows.Forms.DateTimePicker dtp_FromInventory;
        private System.Windows.Forms.RadioButton rb_DayInventory;
        private System.Windows.Forms.RadioButton rb_ChooseInventory;
        private System.Windows.Forms.RadioButton rb_WeekInventory;
        private System.Windows.Forms.RadioButton rb_AllInventory;
    }
}