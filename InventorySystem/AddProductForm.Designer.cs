namespace InventorySystem
{
    partial class AddProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ProductName = new System.Windows.Forms.TextBox();
            this.tb_Code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Articul = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Unit = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Count = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Наименование";
            // 
            // tb_ProductName
            // 
            this.tb_ProductName.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tb_ProductName.Location = new System.Drawing.Point(20, 38);
            this.tb_ProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_ProductName.Name = "tb_ProductName";
            this.tb_ProductName.Size = new System.Drawing.Size(580, 26);
            this.tb_ProductName.TabIndex = 1;
            // 
            // tb_Code
            // 
            this.tb_Code.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tb_Code.Location = new System.Drawing.Point(20, 93);
            this.tb_Code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Code.Name = "tb_Code";
            this.tb_Code.Size = new System.Drawing.Size(580, 26);
            this.tb_Code.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Код";
            // 
            // tb_Articul
            // 
            this.tb_Articul.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tb_Articul.Location = new System.Drawing.Point(20, 148);
            this.tb_Articul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Articul.Name = "tb_Articul";
            this.tb_Articul.Size = new System.Drawing.Size(580, 26);
            this.tb_Articul.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label3.Location = new System.Drawing.Point(21, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Артикул";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label4.Location = new System.Drawing.Point(21, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ед. езм";
            // 
            // tb_Description
            // 
            this.tb_Description.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tb_Description.Location = new System.Drawing.Point(20, 260);
            this.tb_Description.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(580, 77);
            this.tb_Description.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label5.Location = new System.Drawing.Point(21, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Описание";
            // 
            // cmb_Unit
            // 
            this.cmb_Unit.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.cmb_Unit.FormattingEnabled = true;
            this.cmb_Unit.Location = new System.Drawing.Point(20, 203);
            this.cmb_Unit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Unit.Name = "cmb_Unit";
            this.cmb_Unit.Size = new System.Drawing.Size(580, 28);
            this.cmb_Unit.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            this.btn_Save.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(398, 402);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(202, 74);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Сохронить";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Count
            // 
            this.tb_Count.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tb_Count.Location = new System.Drawing.Point(20, 366);
            this.tb_Count.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Count.Name = "tb_Count";
            this.tb_Count.Size = new System.Drawing.Size(580, 26);
            this.tb_Count.TabIndex = 6;
            this.tb_Count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.label6.Location = new System.Drawing.Point(21, 342);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 112;
            this.label6.Text = "Кол-во";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(617, 494);
            this.Controls.Add(this.tb_Count);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cmb_Unit);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Articul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ProductName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(633, 533);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(633, 533);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить новый продукт";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ProductName;
        private System.Windows.Forms.TextBox tb_Code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Articul;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Unit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Count;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}