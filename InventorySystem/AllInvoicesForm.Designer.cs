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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_PurchaseInvoices = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_invoice = new System.Windows.Forms.TabPage();
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
            this.tab_Invoices.SuspendLayout();
            this.tab_PurchaseInvoices.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PurchaseInvoices)).BeginInit();
            this.tab_invoice.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoices)).BeginInit();
            this.tab_inventory.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventories)).BeginInit();
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
            this.tab_PurchaseInvoices.Controls.Add(this.panel3);
            this.tab_PurchaseInvoices.Location = new System.Drawing.Point(4, 28);
            this.tab_PurchaseInvoices.Name = "tab_PurchaseInvoices";
            this.tab_PurchaseInvoices.Padding = new System.Windows.Forms.Padding(3);
            this.tab_PurchaseInvoices.Size = new System.Drawing.Size(861, 533);
            this.tab_PurchaseInvoices.TabIndex = 0;
            this.tab_PurchaseInvoices.Text = "Приходные накладные";
            this.tab_PurchaseInvoices.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_PurchaseInvoices);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(855, 527);
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
            this.dgv_PurchaseInvoices.Size = new System.Drawing.Size(855, 527);
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
            this.tab_invoice.Controls.Add(this.panel1);
            this.tab_invoice.Location = new System.Drawing.Point(4, 28);
            this.tab_invoice.Name = "tab_invoice";
            this.tab_invoice.Padding = new System.Windows.Forms.Padding(3);
            this.tab_invoice.Size = new System.Drawing.Size(861, 533);
            this.tab_invoice.TabIndex = 1;
            this.tab_invoice.Text = "Накладные";
            this.tab_invoice.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_Invoices);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 527);
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
            this.dgv_Invoices.Size = new System.Drawing.Size(855, 527);
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 527);
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
            this.dgv_Inventories.Size = new System.Drawing.Size(855, 527);
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
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PurchaseInvoices)).EndInit();
            this.tab_invoice.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoices)).EndInit();
            this.tab_inventory.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventories)).EndInit();
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
    }
}