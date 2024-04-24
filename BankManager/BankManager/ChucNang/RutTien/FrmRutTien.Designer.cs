namespace BankManager.ChucNang.RutTien
{
    partial class FrmRutTien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_Loi = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_NapTien = new System.Windows.Forms.Button();
            this.TextBox_Tien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label_Loi);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button_NapTien);
            this.panel1.Controls.Add(this.TextBox_Tien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(220, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 218);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(443, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 175);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 175);
            this.panel5.TabIndex = 4;
            // 
            // label_Loi
            // 
            this.label_Loi.AutoSize = true;
            this.label_Loi.ForeColor = System.Drawing.Color.Red;
            this.label_Loi.Location = new System.Drawing.Point(162, 130);
            this.label_Loi.Name = "label_Loi";
            this.label_Loi.Size = new System.Drawing.Size(12, 17);
            this.label_Loi.TabIndex = 23;
            this.label_Loi.Text = ".";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 1);
            this.panel2.TabIndex = 1;
            // 
            // button_NapTien
            // 
            this.button_NapTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_NapTien.Location = new System.Drawing.Point(127, 157);
            this.button_NapTien.Name = "button_NapTien";
            this.button_NapTien.Size = new System.Drawing.Size(177, 32);
            this.button_NapTien.TabIndex = 22;
            this.button_NapTien.Text = "Rút";
            this.button_NapTien.UseVisualStyleBackColor = true;
            this.button_NapTien.Click += new System.EventHandler(this.button_NapTien_Click);
            // 
            // TextBox_Tien
            // 
            this.TextBox_Tien.Location = new System.Drawing.Point(115, 97);
            this.TextBox_Tien.Name = "TextBox_Tien";
            this.TextBox_Tien.Size = new System.Drawing.Size(205, 22);
            this.TextBox_Tien.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(160, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nhập số tiền:";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(444, 42);
            this.label3.TabIndex = 19;
            this.label3.Text = "Rút Tiền";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmRutTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(885, 473);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRutTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRutTien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label_Loi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_NapTien;
        private System.Windows.Forms.TextBox TextBox_Tien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}