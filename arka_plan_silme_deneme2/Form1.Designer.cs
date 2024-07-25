namespace arka_plan_silme_deneme2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectPictureButton = new System.Windows.Forms.Button();
            this.SelectBackground = new System.Windows.Forms.Button();
            this.ExtractButton = new System.Windows.Forms.Button();
            this.SelectPicture_picturebox = new System.Windows.Forms.PictureBox();
            this.SelectBackground_PictureBox = new System.Windows.Forms.PictureBox();
            this.Showresult_Picturebox = new System.Windows.Forms.PictureBox();
            this.tolerans_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPicture_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectBackground_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Showresult_Picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tolerans_numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectPictureButton
            // 
            this.SelectPictureButton.Location = new System.Drawing.Point(43, 318);
            this.SelectPictureButton.Name = "SelectPictureButton";
            this.SelectPictureButton.Size = new System.Drawing.Size(108, 23);
            this.SelectPictureButton.TabIndex = 0;
            this.SelectPictureButton.Text = "Resim Ekle";
            this.SelectPictureButton.UseVisualStyleBackColor = true;
            this.SelectPictureButton.Click += new System.EventHandler(this.SelectPictureButton_Click);
            // 
            // SelectBackground
            // 
            this.SelectBackground.Location = new System.Drawing.Point(659, 318);
            this.SelectBackground.Name = "SelectBackground";
            this.SelectBackground.Size = new System.Drawing.Size(108, 23);
            this.SelectBackground.TabIndex = 1;
            this.SelectBackground.Text = "Arka Planı seç";
            this.SelectBackground.UseVisualStyleBackColor = true;
            this.SelectBackground.Click += new System.EventHandler(this.SelectBackground_Click);
            // 
            // ExtractButton
            // 
            this.ExtractButton.Location = new System.Drawing.Point(84, 510);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(108, 23);
            this.ExtractButton.TabIndex = 2;
            this.ExtractButton.Text = "Ayıkla";
            this.ExtractButton.UseVisualStyleBackColor = true;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // SelectPicture_picturebox
            // 
            this.SelectPicture_picturebox.Location = new System.Drawing.Point(12, 3);
            this.SelectPicture_picturebox.Name = "SelectPicture_picturebox";
            this.SelectPicture_picturebox.Size = new System.Drawing.Size(394, 309);
            this.SelectPicture_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SelectPicture_picturebox.TabIndex = 3;
            this.SelectPicture_picturebox.TabStop = false;
            // 
            // SelectBackground_PictureBox
            // 
            this.SelectBackground_PictureBox.Location = new System.Drawing.Point(435, 3);
            this.SelectBackground_PictureBox.Name = "SelectBackground_PictureBox";
            this.SelectBackground_PictureBox.Size = new System.Drawing.Size(394, 309);
            this.SelectBackground_PictureBox.TabIndex = 4;
            this.SelectBackground_PictureBox.TabStop = false;
            // 
            // Showresult_Picturebox
            // 
            this.Showresult_Picturebox.Location = new System.Drawing.Point(211, 318);
            this.Showresult_Picturebox.Name = "Showresult_Picturebox";
            this.Showresult_Picturebox.Size = new System.Drawing.Size(394, 309);
            this.Showresult_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Showresult_Picturebox.TabIndex = 5;
            this.Showresult_Picturebox.TabStop = false;
            this.Showresult_Picturebox.Click += new System.EventHandler(this.Showresult_Picturebox_Click);
            // 
            // tolerans_numericUpDown1
            // 
            this.tolerans_numericUpDown1.Location = new System.Drawing.Point(84, 458);
            this.tolerans_numericUpDown1.Name = "tolerans_numericUpDown1";
            this.tolerans_numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.tolerans_numericUpDown1.TabIndex = 6;
            this.tolerans_numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 654);
            this.Controls.Add(this.tolerans_numericUpDown1);
            this.Controls.Add(this.Showresult_Picturebox);
            this.Controls.Add(this.SelectBackground_PictureBox);
            this.Controls.Add(this.SelectPicture_picturebox);
            this.Controls.Add(this.ExtractButton);
            this.Controls.Add(this.SelectBackground);
            this.Controls.Add(this.SelectPictureButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectPicture_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectBackground_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Showresult_Picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tolerans_numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectPictureButton;
        private System.Windows.Forms.Button SelectBackground;
        private System.Windows.Forms.Button ExtractButton;
        private System.Windows.Forms.PictureBox SelectPicture_picturebox;
        private System.Windows.Forms.PictureBox SelectBackground_PictureBox;
        private System.Windows.Forms.PictureBox Showresult_Picturebox;
        private System.Windows.Forms.NumericUpDown tolerans_numericUpDown1;
    }
}

