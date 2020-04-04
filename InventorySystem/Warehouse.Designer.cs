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
            this.gB_Actions = new System.Windows.Forms.GroupBox();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.grB_Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
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
            this.grB_Products.Location = new System.Drawing.Point(12, 106);
            this.grB_Products.Name = "grB_Products";
            this.grB_Products.Size = new System.Drawing.Size(700, 612);
            this.grB_Products.TabIndex = 1;
            this.grB_Products.TabStop = false;
            this.grB_Products.Text = "Товары";
            // 
            // gB_Actions
            // 
            this.gB_Actions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gB_Actions.Location = new System.Drawing.Point(12, 12);
            this.gB_Actions.Name = "gB_Actions";
            this.gB_Actions.Size = new System.Drawing.Size(700, 88);
            this.gB_Actions.TabIndex = 2;
            this.gB_Actions.TabStop = false;
            this.gB_Actions.Text = "Действия";
            // 
            // dgv_products
            // 
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_products.Location = new System.Drawing.Point(3, 16);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.Size = new System.Drawing.Size(694, 593);
            this.dgv_products.TabIndex = 0;
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 730);
            this.Controls.Add(this.gB_Actions);
            this.Controls.Add(this.grB_Products);
            this.Name = "Warehouse";
            this.Text = "Склад";
            this.grB_Products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox grB_Products;
        private System.Windows.Forms.GroupBox gB_Actions;
        private System.Windows.Forms.DataGridView dgv_products;
    }
}

