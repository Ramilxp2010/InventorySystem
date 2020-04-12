namespace InventorySystem
{
    partial class InventoryForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_Products = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_Products = new System.Windows.Forms.ComboBox();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btn_AddNewProduct = new System.Windows.Forms.Button();
            this.tb_Count = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_ResponsibleName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_InvoiceNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_Save = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.cmb_Products);
            this.panel2.Controls.Add(this.btn_AddProduct);
            this.panel2.Controls.Add(this.btn_AddNewProduct);
            this.panel2.Controls.Add(this.tb_Count);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(12, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 360);
            this.panel2.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label8.Location = new System.Drawing.Point(9, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Товары добавленные в накладную";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_Products);
            this.panel3.Location = new System.Drawing.Point(9, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(823, 240);
            this.panel3.TabIndex = 18;
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
            this.dgv_Products.Location = new System.Drawing.Point(0, 0);
            this.dgv_Products.Name = "dgv_Products";
            this.dgv_Products.ReadOnly = true;
            this.dgv_Products.Size = new System.Drawing.Size(823, 240);
            this.dgv_Products.TabIndex = 10;
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
            // cmb_Products
            // 
            this.cmb_Products.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Products.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_Products.FormattingEnabled = true;
            this.cmb_Products.Location = new System.Drawing.Point(9, 40);
            this.cmb_Products.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Products.Name = "cmb_Products";
            this.cmb_Products.Size = new System.Drawing.Size(217, 28);
            this.cmb_Products.TabIndex = 5;
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            this.btn_AddProduct.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AddProduct.FlatAppearance.BorderSize = 0;
            this.btn_AddProduct.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_AddProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_AddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_AddProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddProduct.ForeColor = System.Drawing.Color.White;
            this.btn_AddProduct.Location = new System.Drawing.Point(467, 16);
            this.btn_AddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(145, 55);
            this.btn_AddProduct.TabIndex = 7;
            this.btn_AddProduct.Text = "Добавить";
            this.btn_AddProduct.UseVisualStyleBackColor = false;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btn_AddNewProduct
            // 
            this.btn_AddNewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(176)))), ((int)(((byte)(83)))));
            this.btn_AddNewProduct.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AddNewProduct.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_AddNewProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_AddNewProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_AddNewProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddNewProduct.ForeColor = System.Drawing.Color.White;
            this.btn_AddNewProduct.Location = new System.Drawing.Point(620, 16);
            this.btn_AddNewProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddNewProduct.Name = "btn_AddNewProduct";
            this.btn_AddNewProduct.Size = new System.Drawing.Size(212, 55);
            this.btn_AddNewProduct.TabIndex = 8;
            this.btn_AddNewProduct.Text = "Добавить новый товар";
            this.btn_AddNewProduct.UseVisualStyleBackColor = false;
            this.btn_AddNewProduct.Click += new System.EventHandler(this.btn_AddNewProduct_Click);
            // 
            // tb_Count
            // 
            this.tb_Count.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Count.Location = new System.Drawing.Point(234, 42);
            this.tb_Count.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Count.Name = "tb_Count";
            this.tb_Count.Size = new System.Drawing.Size(225, 26);
            this.tb_Count.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label5.Location = new System.Drawing.Point(9, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Товар";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label6.Location = new System.Drawing.Point(241, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Кол-во";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tb_ResponsibleName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_InvoiceNumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(199)))));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 128);
            this.panel1.TabIndex = 19;
            // 
            // tb_ResponsibleName
            // 
            this.tb_ResponsibleName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ResponsibleName.Location = new System.Drawing.Point(9, 88);
            this.tb_ResponsibleName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ResponsibleName.Name = "tb_ResponsibleName";
            this.tb_ResponsibleName.Size = new System.Drawing.Size(445, 26);
            this.tb_ResponsibleName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label7.Location = new System.Drawing.Point(9, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ответственный";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер накладной";
            // 
            // tb_InvoiceNumber
            // 
            this.tb_InvoiceNumber.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_InvoiceNumber.Location = new System.Drawing.Point(7, 29);
            this.tb_InvoiceNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tb_InvoiceNumber.Name = "tb_InvoiceNumber";
            this.tb_InvoiceNumber.Size = new System.Drawing.Size(447, 26);
            this.tb_InvoiceNumber.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label3.Location = new System.Drawing.Point(463, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(462, 29);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(380, 26);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Save.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(611, 513);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(235, 55);
            this.btn_Save.TabIndex = 21;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(884, 581);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(900, 620);
            this.MinimumSize = new System.Drawing.Size(900, 620);
            this.Name = "InventoryForm";
            this.Text = "Инвентаризация";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_Products;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.ComboBox cmb_Products;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Button btn_AddNewProduct;
        private System.Windows.Forms.TextBox tb_Count;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_ResponsibleName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_InvoiceNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}