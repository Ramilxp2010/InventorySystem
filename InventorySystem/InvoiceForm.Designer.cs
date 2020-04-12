namespace InventorySystem
{
    partial class InvoiceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Count = new System.Windows.Forms.TextBox();
            this.dgv_Products = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Goal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tb_OrgName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.tb_InvoiceNumber = new System.Windows.Forms.TextBox();
            this.tb_ResponsibleName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_Warehouse = new System.Windows.Forms.DataGridView();
            this.tb_Searh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Warehouse)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
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
            this.btn_Save.Location = new System.Drawing.Point(817, 699);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(203, 55);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Count
            // 
            this.tb_Count.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Count.Location = new System.Drawing.Point(598, 192);
            this.tb_Count.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Count.Name = "tb_Count";
            this.tb_Count.Size = new System.Drawing.Size(169, 26);
            this.tb_Count.TabIndex = 6;
            this.tb_Count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // dgv_Products
            // 
            this.dgv_Products.AllowUserToAddRows = false;
            this.dgv_Products.AllowUserToDeleteRows = false;
            this.dgv_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Products.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Count,
            this.Unit});
            this.dgv_Products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Products.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Products.Location = new System.Drawing.Point(0, 0);
            this.dgv_Products.Name = "dgv_Products";
            this.dgv_Products.ReadOnly = true;
            this.dgv_Products.Size = new System.Drawing.Size(1000, 188);
            this.dgv_Products.TabIndex = 10;
            this.dgv_Products.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGrid_KeyDown);
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Название";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.HeaderText = "Кол-во";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Ед. езм";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label6.Location = new System.Drawing.Point(530, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Кол-во";
            // 
            // tb_Goal
            // 
            this.tb_Goal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Goal.Location = new System.Drawing.Point(572, 142);
            this.tb_Goal.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Goal.Name = "tb_Goal";
            this.tb_Goal.Size = new System.Drawing.Size(435, 26);
            this.tb_Goal.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label4.Location = new System.Drawing.Point(577, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Назначение";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(572, 83);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(435, 26);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // tb_OrgName
            // 
            this.tb_OrgName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_OrgName.Location = new System.Drawing.Point(7, 29);
            this.tb_OrgName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_OrgName.Name = "tb_OrgName";
            this.tb_OrgName.Size = new System.Drawing.Size(553, 26);
            this.tb_OrgName.TabIndex = 1;
            this.tb_OrgName.Text = "СССОПОК БАЛАНДЫШ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label3.Location = new System.Drawing.Point(577, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Организация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер накладной";
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
            this.btn_AddProduct.Location = new System.Drawing.Point(804, 189);
            this.btn_AddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(205, 55);
            this.btn_AddProduct.TabIndex = 7;
            this.btn_AddProduct.Text = "Добавить";
            this.btn_AddProduct.UseVisualStyleBackColor = false;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // tb_InvoiceNumber
            // 
            this.tb_InvoiceNumber.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_InvoiceNumber.Location = new System.Drawing.Point(7, 83);
            this.tb_InvoiceNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tb_InvoiceNumber.Name = "tb_InvoiceNumber";
            this.tb_InvoiceNumber.Size = new System.Drawing.Size(553, 26);
            this.tb_InvoiceNumber.TabIndex = 2;
            // 
            // tb_ResponsibleName
            // 
            this.tb_ResponsibleName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ResponsibleName.Location = new System.Drawing.Point(9, 142);
            this.tb_ResponsibleName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ResponsibleName.Name = "tb_ResponsibleName";
            this.tb_ResponsibleName.Size = new System.Drawing.Size(551, 26);
            this.tb_ResponsibleName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label7.Location = new System.Drawing.Point(9, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Через кого (кому)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tb_ResponsibleName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_InvoiceNumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_Goal);
            this.panel1.Controls.Add(this.tb_OrgName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(199)))));
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 207);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.tb_Searh);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_AddProduct);
            this.panel2.Controls.Add(this.tb_Count);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(11, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 450);
            this.panel2.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_Warehouse);
            this.panel4.Location = new System.Drawing.Point(7, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1000, 103);
            this.panel4.TabIndex = 23;
            // 
            // dgv_Warehouse
            // 
            this.dgv_Warehouse.AllowUserToAddRows = false;
            this.dgv_Warehouse.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_Warehouse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Warehouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Warehouse.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Warehouse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Warehouse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_Warehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Warehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Warehouse.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Warehouse.Location = new System.Drawing.Point(0, 0);
            this.dgv_Warehouse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_Warehouse.Name = "dgv_Warehouse";
            this.dgv_Warehouse.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgv_Warehouse.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Warehouse.Size = new System.Drawing.Size(1000, 103);
            this.dgv_Warehouse.TabIndex = 0;
            // 
            // tb_Searh
            // 
            this.tb_Searh.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Searh.Location = new System.Drawing.Point(65, 16);
            this.tb_Searh.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Searh.Name = "tb_Searh";
            this.tb_Searh.Size = new System.Drawing.Size(223, 26);
            this.tb_Searh.TabIndex = 21;
            this.tb_Searh.TextChanged += new System.EventHandler(this.tb_Searh_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label9.Location = new System.Drawing.Point(12, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Поиск";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label5.Location = new System.Drawing.Point(10, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Товары на складе";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label8.Location = new System.Drawing.Point(9, 225);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Товары добавленные в накладную";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_Products);
            this.panel3.Location = new System.Drawing.Point(9, 251);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 188);
            this.panel3.TabIndex = 18;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1067, 766);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Save);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1083, 805);
            this.MinimumSize = new System.Drawing.Size(1083, 805);
            this.Name = "InvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Накладная форма № 264-АНК (ф 87)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InvoiceForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Warehouse)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Count;
        private System.Windows.Forms.DataGridView dgv_Products;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Goal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tb_OrgName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.TextBox tb_ResponsibleName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_InvoiceNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.TextBox tb_Searh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_Warehouse;
    }
}