namespace InventorySystem
{
    partial class Purshase
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
            this.gB_Purchase = new System.Windows.Forms.GroupBox();
            this.tb_Goal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tb_PurchaseNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Providers = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gb_Products = new System.Windows.Forms.GroupBox();
            this.dgv_Products = new System.Windows.Forms.DataGridView();
            this.tb_Count = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_AddNewProduct = new System.Windows.Forms.Button();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.cmb_Products = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gB_Purchase.SuspendLayout();
            this.gb_Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gB_Purchase
            // 
            this.gB_Purchase.Controls.Add(this.tb_Goal);
            this.gB_Purchase.Controls.Add(this.label4);
            this.gB_Purchase.Controls.Add(this.dateTimePicker1);
            this.gB_Purchase.Controls.Add(this.tb_PurchaseNumber);
            this.gB_Purchase.Controls.Add(this.label3);
            this.gB_Purchase.Controls.Add(this.label2);
            this.gB_Purchase.Controls.Add(this.label1);
            this.gB_Purchase.Controls.Add(this.cmb_Providers);
            this.gB_Purchase.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gB_Purchase.Location = new System.Drawing.Point(16, 19);
            this.gB_Purchase.Margin = new System.Windows.Forms.Padding(4);
            this.gB_Purchase.Name = "gB_Purchase";
            this.gB_Purchase.Padding = new System.Windows.Forms.Padding(4);
            this.gB_Purchase.Size = new System.Drawing.Size(1035, 193);
            this.gB_Purchase.TabIndex = 0;
            this.gB_Purchase.TabStop = false;
            this.gB_Purchase.Text = "Накладная";
            // 
            // tb_Goal
            // 
            this.tb_Goal.Location = new System.Drawing.Point(20, 157);
            this.tb_Goal.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Goal.Name = "tb_Goal";
            this.tb_Goal.Size = new System.Drawing.Size(212, 26);
            this.tb_Goal.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Назначение";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(592, 54);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(435, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // tb_PurchaseNumber
            // 
            this.tb_PurchaseNumber.Location = new System.Drawing.Point(21, 105);
            this.tb_PurchaseNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tb_PurchaseNumber.Name = "tb_PurchaseNumber";
            this.tb_PurchaseNumber.Size = new System.Drawing.Size(212, 26);
            this.tb_PurchaseNumber.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер накладной";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поставщик";
            // 
            // cmb_Providers
            // 
            this.cmb_Providers.FormattingEnabled = true;
            this.cmb_Providers.Location = new System.Drawing.Point(20, 52);
            this.cmb_Providers.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Providers.Name = "cmb_Providers";
            this.cmb_Providers.Size = new System.Drawing.Size(558, 28);
            this.cmb_Providers.TabIndex = 0;
            // 
            // gb_Products
            // 
            this.gb_Products.Controls.Add(this.dgv_Products);
            this.gb_Products.Location = new System.Drawing.Point(16, 295);
            this.gb_Products.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Products.Name = "gb_Products";
            this.gb_Products.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Products.Size = new System.Drawing.Size(1035, 422);
            this.gb_Products.TabIndex = 1;
            this.gb_Products.TabStop = false;
            this.gb_Products.Text = "Товары";
            // 
            // dgv_Products
            // 
            this.dgv_Products.AllowUserToAddRows = false;
            this.dgv_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Products.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Unit,
            this.Count});
            this.dgv_Products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Products.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Products.Location = new System.Drawing.Point(4, 23);
            this.dgv_Products.Name = "dgv_Products";
            this.dgv_Products.ReadOnly = true;
            this.dgv_Products.Size = new System.Drawing.Size(1027, 395);
            this.dgv_Products.TabIndex = 10;
            // 
            // tb_Count
            // 
            this.tb_Count.Location = new System.Drawing.Point(364, 240);
            this.tb_Count.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Count.Name = "tb_Count";
            this.tb_Count.Size = new System.Drawing.Size(212, 26);
            this.tb_Count.TabIndex = 9;
            this.tb_Count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 216);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Кол-во";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Товар";
            // 
            // btn_AddNewProduct
            // 
            this.btn_AddNewProduct.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_AddNewProduct.Location = new System.Drawing.Point(832, 235);
            this.btn_AddNewProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddNewProduct.Name = "btn_AddNewProduct";
            this.btn_AddNewProduct.Size = new System.Drawing.Size(211, 36);
            this.btn_AddNewProduct.TabIndex = 3;
            this.btn_AddNewProduct.Text = "Добавить новый товар";
            this.btn_AddNewProduct.UseVisualStyleBackColor = false;
            this.btn_AddNewProduct.Click += new System.EventHandler(this.btn_AddNewProduct_Click);
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_AddProduct.Location = new System.Drawing.Point(597, 235);
            this.btn_AddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(100, 36);
            this.btn_AddProduct.TabIndex = 2;
            this.btn_AddProduct.Text = "Добавить";
            this.btn_AddProduct.UseVisualStyleBackColor = false;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // cmb_Products
            // 
            this.cmb_Products.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Products.FormattingEnabled = true;
            this.cmb_Products.Location = new System.Drawing.Point(36, 240);
            this.cmb_Products.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Products.Name = "cmb_Products";
            this.cmb_Products.Size = new System.Drawing.Size(320, 28);
            this.cmb_Products.TabIndex = 1;
            this.cmb_Products.SelectedIndexChanged += new System.EventHandler(this.cmb_Products_SelectedIndexChanged);
            this.cmb_Products.TextUpdate += new System.EventHandler(this.cmb_Products_TextUpdate);
            this.cmb_Products.DataSourceChanged += new System.EventHandler(this.cmb_Products_DataSourceChanged);
            this.cmb_Products.TextChanged += new System.EventHandler(this.cmb_Products_TextChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_Save.Location = new System.Drawing.Point(881, 725);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(170, 36);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Название";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Ед. езм";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.HeaderText = "Кол-во";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // Purshase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1067, 766);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Count);
            this.Controls.Add(this.gb_Products);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gB_Purchase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_AddNewProduct);
            this.Controls.Add(this.cmb_Products);
            this.Controls.Add(this.btn_AddProduct);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1083, 805);
            this.MinimumSize = new System.Drawing.Size(1083, 805);
            this.Name = "Purshase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purshase";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Purshase_FormClosed);
            this.gB_Purchase.ResumeLayout(false);
            this.gB_Purchase.PerformLayout();
            this.gb_Products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gB_Purchase;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tb_PurchaseNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Providers;
        private System.Windows.Forms.GroupBox gb_Products;
        private System.Windows.Forms.ComboBox cmb_Products;
        private System.Windows.Forms.Button btn_AddNewProduct;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.TextBox tb_Goal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tb_Count;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_Products;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}