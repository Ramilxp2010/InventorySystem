namespace InventorySystem
{
    partial class Warehouse
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grB_Products = new System.Windows.Forms.GroupBox();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.gB_Actions = new System.Windows.Forms.GroupBox();
            this.btn_CheckPurshases = new System.Windows.Forms.Button();
            this.btn_Inventory = new System.Windows.Forms.Button();
            this.brn_Invoice = new System.Windows.Forms.Button();
            this.btn_Purshase = new System.Windows.Forms.Button();
            this.grB_Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.gB_Actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // grB_Products
            // 
            this.grB_Products.Controls.Add(this.dgv_products);
            this.grB_Products.Location = new System.Drawing.Point(16, 163);
            this.grB_Products.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grB_Products.Name = "grB_Products";
            this.grB_Products.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grB_Products.Size = new System.Drawing.Size(1038, 589);
            this.grB_Products.TabIndex = 1;
            this.grB_Products.TabStop = false;
            this.grB_Products.Text = "Товары";
            // 
            // dgv_products
            // 
            this.dgv_products.AllowUserToAddRows = false;
            this.dgv_products.AllowUserToDeleteRows = false;
            this.dgv_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_products.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_products.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_products.Location = new System.Drawing.Point(4, 24);
            this.dgv_products.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.ReadOnly = true;
            this.dgv_products.Size = new System.Drawing.Size(1030, 560);
            this.dgv_products.TabIndex = 0;
            // 
            // gB_Actions
            // 
            this.gB_Actions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gB_Actions.Controls.Add(this.btn_CheckPurshases);
            this.gB_Actions.Controls.Add(this.btn_Inventory);
            this.gB_Actions.Controls.Add(this.brn_Invoice);
            this.gB_Actions.Controls.Add(this.btn_Purshase);
            this.gB_Actions.Location = new System.Drawing.Point(16, 18);
            this.gB_Actions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gB_Actions.Name = "gB_Actions";
            this.gB_Actions.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gB_Actions.Size = new System.Drawing.Size(1038, 135);
            this.gB_Actions.TabIndex = 2;
            this.gB_Actions.TabStop = false;
            this.gB_Actions.Text = "Действия";
            // 
            // btn_CheckPurshases
            // 
            this.btn_CheckPurshases.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_CheckPurshases.Location = new System.Drawing.Point(432, 29);
            this.btn_CheckPurshases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_CheckPurshases.Name = "btn_CheckPurshases";
            this.btn_CheckPurshases.Size = new System.Drawing.Size(133, 97);
            this.btn_CheckPurshases.TabIndex = 3;
            this.btn_CheckPurshases.Text = "Посмотреть накладные";
            this.btn_CheckPurshases.UseVisualStyleBackColor = false;
            // 
            // btn_Inventory
            // 
            this.btn_Inventory.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_Inventory.Location = new System.Drawing.Point(291, 29);
            this.btn_Inventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Inventory.Name = "btn_Inventory";
            this.btn_Inventory.Size = new System.Drawing.Size(133, 97);
            this.btn_Inventory.TabIndex = 2;
            this.btn_Inventory.Text = "Инвентаризация";
            this.btn_Inventory.UseVisualStyleBackColor = false;
            // 
            // brn_Invoice
            // 
            this.brn_Invoice.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.brn_Invoice.Location = new System.Drawing.Point(149, 29);
            this.brn_Invoice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.brn_Invoice.Name = "brn_Invoice";
            this.brn_Invoice.Size = new System.Drawing.Size(133, 97);
            this.brn_Invoice.TabIndex = 1;
            this.brn_Invoice.Text = "Выдать товар";
            this.brn_Invoice.UseVisualStyleBackColor = false;
            // 
            // btn_Purshase
            // 
            this.btn_Purshase.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_Purshase.Location = new System.Drawing.Point(8, 29);
            this.btn_Purshase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Purshase.Name = "btn_Purshase";
            this.btn_Purshase.Size = new System.Drawing.Size(133, 97);
            this.btn_Purshase.TabIndex = 0;
            this.btn_Purshase.Text = "Оприходовать товар";
            this.btn_Purshase.UseVisualStyleBackColor = false;
            this.btn_Purshase.Click += new System.EventHandler(this.btn_Purshase_Click);
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1067, 766);
            this.Controls.Add(this.gB_Actions);
            this.Controls.Add(this.grB_Products);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1083, 805);
            this.MinimumSize = new System.Drawing.Size(1083, 805);
            this.Name = "Warehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            this.Activated += new System.EventHandler(this.Warehouse_Enter);
            this.grB_Products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.gB_Actions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox grB_Products;
        private System.Windows.Forms.GroupBox gB_Actions;
        private System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.Button btn_Inventory;
        private System.Windows.Forms.Button brn_Invoice;
        private System.Windows.Forms.Button btn_Purshase;
        private System.Windows.Forms.Button btn_CheckPurshases;
    }
}

