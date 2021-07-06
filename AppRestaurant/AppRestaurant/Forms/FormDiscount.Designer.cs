
namespace AppRestaurant.Forms
{
    partial class FormDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiscount));
            this.buttonOrderNowDiscount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOnly = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOrderNowDiscount
            // 
            this.buttonOrderNowDiscount.BackColor = System.Drawing.Color.Navy;
            this.buttonOrderNowDiscount.FlatAppearance.BorderSize = 0;
            this.buttonOrderNowDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderNowDiscount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOrderNowDiscount.ForeColor = System.Drawing.Color.White;
            this.buttonOrderNowDiscount.Location = new System.Drawing.Point(729, 542);
            this.buttonOrderNowDiscount.Name = "buttonOrderNowDiscount";
            this.buttonOrderNowDiscount.Size = new System.Drawing.Size(268, 39);
            this.buttonOrderNowDiscount.TabIndex = 11;
            this.buttonOrderNowDiscount.Text = "Zamów teraz!\r\n";
            this.buttonOrderNowDiscount.UseVisualStyleBackColor = false;
            this.buttonOrderNowDiscount.Click += new System.EventHandler(this.buttonOrderNowDiscount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(625, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(475, 56);
            this.label3.TabIndex = 10;
            this.label3.Text = "zmniejszy się o 10%\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(586, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(540, 180);
            this.label2.TabIndex = 9;
            this.label2.Text = "Jeśli zamówisz Kapsalona i Greko Box\r\n         łączna kwota zamówienia\r\n\r\n\r\n\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(186, 331);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(272, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 58);
            this.label1.TabIndex = 7;
            this.label1.Text = "dziś!";
            // 
            // labelOnly
            // 
            this.labelOnly.AutoSize = true;
            this.labelOnly.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOnly.ForeColor = System.Drawing.Color.Navy;
            this.labelOnly.Location = new System.Drawing.Point(128, 75);
            this.labelOnly.Name = "labelOnly";
            this.labelOnly.Size = new System.Drawing.Size(190, 77);
            this.labelOnly.TabIndex = 6;
            this.labelOnly.Text = "Tylko";
            // 
            // FormDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.buttonOrderNowDiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOnly);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDiscount";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonOrderNowDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOnly;
    }
}