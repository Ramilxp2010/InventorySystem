namespace InventorySystem
{
    partial class TransactionDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Print = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_ResponsibleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_InvoiceNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Goal = new System.Windows.Forms.TextBox();
            this.tb_OrgName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label8.Location = new System.Drawing.Point(17, 229);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Товары в накладной";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_products);
            this.panel2.Location = new System.Drawing.Point(12, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 253);
            this.panel2.TabIndex = 22;
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
            this.dgv_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
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
            this.dgv_products.Size = new System.Drawing.Size(860, 253);
            this.dgv_products.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "НАЗВАНИЕ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "КОЛИЧЕСТВО";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ЕД.ИЗМ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "КОД";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            this.btn_Print.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Print.FlatAppearance.BorderSize = 0;
            this.btn_Print.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_Print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Print.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Location = new System.Drawing.Point(631, 515);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(235, 55);
            this.btn_Print.TabIndex = 24;
            this.btn_Print.Text = "Печать";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Visible = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 207);
            this.panel1.TabIndex = 25;
            // 
            // tb_ResponsibleName
            // 
            this.tb_ResponsibleName.Enabled = false;
            this.tb_ResponsibleName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ResponsibleName.Location = new System.Drawing.Point(9, 142);
            this.tb_ResponsibleName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ResponsibleName.Name = "tb_ResponsibleName";
            this.tb_ResponsibleName.Size = new System.Drawing.Size(429, 26);
            this.tb_ResponsibleName.TabIndex = 3;
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
            // tb_InvoiceNumber
            // 
            this.tb_InvoiceNumber.Enabled = false;
            this.tb_InvoiceNumber.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_InvoiceNumber.Location = new System.Drawing.Point(7, 83);
            this.tb_InvoiceNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tb_InvoiceNumber.Name = "tb_InvoiceNumber";
            this.tb_InvoiceNumber.Size = new System.Drawing.Size(431, 26);
            this.tb_InvoiceNumber.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label3.Location = new System.Drawing.Point(451, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата";
            // 
            // tb_Goal
            // 
            this.tb_Goal.Enabled = false;
            this.tb_Goal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Goal.Location = new System.Drawing.Point(446, 142);
            this.tb_Goal.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Goal.Name = "tb_Goal";
            this.tb_Goal.Size = new System.Drawing.Size(406, 26);
            this.tb_Goal.TabIndex = 4;
            // 
            // tb_OrgName
            // 
            this.tb_OrgName.Enabled = false;
            this.tb_OrgName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_OrgName.Location = new System.Drawing.Point(7, 29);
            this.tb_OrgName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_OrgName.Name = "tb_OrgName";
            this.tb_OrgName.Size = new System.Drawing.Size(431, 26);
            this.tb_OrgName.TabIndex = 1;
            this.tb_OrgName.Text = "СССОПОК БАЛАНДЫШ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label4.Location = new System.Drawing.Point(451, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Назначение";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(446, 83);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(406, 26);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // TransactionDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 581);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(900, 620);
            this.MinimumSize = new System.Drawing.Size(900, 620);
            this.Name = "TransactionDetailForm";
            this.Text = "TransactionDetailForm";
            this.Load += new System.EventHandler(this.TransactionDetailForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_ResponsibleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_InvoiceNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Goal;
        private System.Windows.Forms.TextBox tb_OrgName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}