namespace InventorySystem
{
    partial class WarehouseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.btn_CheckPurshases = new System.Windows.Forms.Button();
            this.btn_Inventory = new System.Windows.Forms.Button();
            this.brn_Invoice = new System.Windows.Forms.Button();
            this.btn_Purshase = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgv_products
            // 
            this.dgv_products.AllowUserToAddRows = false;
            this.dgv_products.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_products.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_products.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_products.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_products.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_products.Location = new System.Drawing.Point(0, 0);
            this.dgv_products.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgv_products.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_products.Size = new System.Drawing.Size(859, 394);
            this.dgv_products.TabIndex = 0;
            // 
            // btn_CheckPurshases
            // 
            this.btn_CheckPurshases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(176)))), ((int)(((byte)(83)))));
            this.btn_CheckPurshases.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CheckPurshases.ForeColor = System.Drawing.Color.White;
            this.btn_CheckPurshases.Location = new System.Drawing.Point(643, 5);
            this.btn_CheckPurshases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_CheckPurshases.Name = "btn_CheckPurshases";
            this.btn_CheckPurshases.Size = new System.Drawing.Size(205, 55);
            this.btn_CheckPurshases.TabIndex = 3;
            this.btn_CheckPurshases.Text = "Посмотреть накладные";
            this.btn_CheckPurshases.UseVisualStyleBackColor = false;
            this.btn_CheckPurshases.Click += new System.EventHandler(this.btn_CheckPurshases_Click);
            // 
            // btn_Inventory
            // 
            this.btn_Inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(176)))), ((int)(((byte)(83)))));
            this.btn_Inventory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Inventory.ForeColor = System.Drawing.Color.White;
            this.btn_Inventory.Location = new System.Drawing.Point(430, 5);
            this.btn_Inventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Inventory.Name = "btn_Inventory";
            this.btn_Inventory.Size = new System.Drawing.Size(205, 55);
            this.btn_Inventory.TabIndex = 2;
            this.btn_Inventory.Text = "Инвентаризация";
            this.btn_Inventory.UseVisualStyleBackColor = false;
            this.btn_Inventory.Click += new System.EventHandler(this.btn_Inventory_Click);
            // 
            // brn_Invoice
            // 
            this.brn_Invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(176)))), ((int)(((byte)(83)))));
            this.brn_Invoice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brn_Invoice.ForeColor = System.Drawing.Color.White;
            this.brn_Invoice.Location = new System.Drawing.Point(217, 5);
            this.brn_Invoice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.brn_Invoice.Name = "brn_Invoice";
            this.brn_Invoice.Size = new System.Drawing.Size(205, 55);
            this.brn_Invoice.TabIndex = 1;
            this.brn_Invoice.Text = "Выдать товар";
            this.brn_Invoice.UseVisualStyleBackColor = false;
            this.brn_Invoice.Click += new System.EventHandler(this.brn_Invoice_Click);
            // 
            // btn_Purshase
            // 
            this.btn_Purshase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(176)))), ((int)(((byte)(83)))));
            this.btn_Purshase.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Purshase.ForeColor = System.Drawing.Color.White;
            this.btn_Purshase.Location = new System.Drawing.Point(4, 5);
            this.btn_Purshase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Purshase.Name = "btn_Purshase";
            this.btn_Purshase.Size = new System.Drawing.Size(205, 55);
            this.btn_Purshase.TabIndex = 0;
            this.btn_Purshase.Text = "Оприходовать товар";
            this.btn_Purshase.UseVisualStyleBackColor = false;
            this.btn_Purshase.Click += new System.EventHandler(this.btn_Purshase_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_CheckPurshases);
            this.panel1.Controls.Add(this.btn_Purshase);
            this.panel1.Controls.Add(this.btn_Inventory);
            this.panel1.Controls.Add(this.brn_Invoice);
            this.panel1.Location = new System.Drawing.Point(16, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 67);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_products);
            this.panel2.Location = new System.Drawing.Point(16, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 394);
            this.panel2.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label8.Location = new System.Drawing.Point(18, 155);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Товары на складе";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(884, 581);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(900, 620);
            this.MinimumSize = new System.Drawing.Size(900, 620);
            this.Name = "WarehouseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            this.Activated += new System.EventHandler(this.Warehouse_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.Button btn_Inventory;
        private System.Windows.Forms.Button brn_Invoice;
        private System.Windows.Forms.Button btn_Purshase;
        private System.Windows.Forms.Button btn_CheckPurshases;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
    }
}

