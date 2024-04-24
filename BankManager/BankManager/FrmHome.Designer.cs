namespace BankManager
{
    partial class FrmHome
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
            this.button_MoTK = new System.Windows.Forms.Button();
            this.button_DichVu = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_MoTK
            // 
            this.button_MoTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_MoTK.Location = new System.Drawing.Point(297, 146);
            this.button_MoTK.Name = "button_MoTK";
            this.button_MoTK.Size = new System.Drawing.Size(230, 38);
            this.button_MoTK.TabIndex = 0;
            this.button_MoTK.Text = "Mở Tài Khoản ";
            this.button_MoTK.UseVisualStyleBackColor = true;
            this.button_MoTK.Click += new System.EventHandler(this.button_MoTK_Click);
            // 
            // button_DichVu
            // 
            this.button_DichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_DichVu.Location = new System.Drawing.Point(297, 219);
            this.button_DichVu.Name = "button_DichVu";
            this.button_DichVu.Size = new System.Drawing.Size(230, 38);
            this.button_DichVu.TabIndex = 1;
            this.button_DichVu.Text = "Dịch Vụ Khác";
            this.button_DichVu.UseVisualStyleBackColor = true;
            this.button_DichVu.Click += new System.EventHandler(this.button_DichVu_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Thoat.Location = new System.Drawing.Point(297, 295);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(230, 38);
            this.button_Thoat.TabIndex = 2;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 473);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_DichVu);
            this.Controls.Add(this.button_MoTK);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_MoTK;
        private System.Windows.Forms.Button button_DichVu;
        private System.Windows.Forms.Button button_Thoat;
    }
}

