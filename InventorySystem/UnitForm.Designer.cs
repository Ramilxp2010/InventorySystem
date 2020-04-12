namespace InventorySystem
{
    partial class UnitForm
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
            this.btn_Updater = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_Units = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Units)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Updater
            // 
            this.btn_Updater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            this.btn_Updater.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Updater.ForeColor = System.Drawing.Color.White;
            this.btn_Updater.Location = new System.Drawing.Point(225, 512);
            this.btn_Updater.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Updater.Name = "btn_Updater";
            this.btn_Updater.Size = new System.Drawing.Size(205, 55);
            this.btn_Updater.TabIndex = 44;
            this.btn_Updater.Text = "Изменить";
            this.btn_Updater.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Red;
            this.btn_Delete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(225, 577);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(205, 55);
            this.btn_Delete.TabIndex = 43;
            this.btn_Delete.Text = "Удалить";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            this.btn_Add.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(12, 512);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(205, 55);
            this.btn_Add.TabIndex = 42;
            this.btn_Add.Text = "Добавить";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label8.Location = new System.Drawing.Point(13, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 41;
            this.label8.Text = "Ед. изм";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_Units);
            this.panel3.Location = new System.Drawing.Point(12, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(418, 470);
            this.panel3.TabIndex = 40;
            // 
            // dgv_Units
            // 
            this.dgv_Units.AllowUserToAddRows = false;
            this.dgv_Units.AllowUserToDeleteRows = false;
            this.dgv_Units.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Units.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Units.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Units.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName});
            this.dgv_Units.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Units.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Units.Location = new System.Drawing.Point(0, 0);
            this.dgv_Units.Name = "dgv_Units";
            this.dgv_Units.ReadOnly = true;
            this.dgv_Units.Size = new System.Drawing.Size(418, 470);
            this.dgv_Units.TabIndex = 10;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Название";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // UnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 641);
            this.Controls.Add(this.btn_Updater);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Name = "UnitForm";
            this.Text = "Ед. изм";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Units)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Updater;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
    }
}