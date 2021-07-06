
namespace AppRestaurant
{
    partial class UCHome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHome));
            this.labelOnly = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOrderNow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOnly
            // 
            this.labelOnly.AutoSize = true;
            this.labelOnly.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.labelOnly.Location = new System.Drawing.Point(77, 52);
            this.labelOnly.Name = "labelOnly";
            this.labelOnly.Size = new System.Drawing.Size(190, 77);
            this.labelOnly.TabIndex = 0;
            this.labelOnly.Text = "Tylko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(221, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "dziś!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(514, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 180);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jeśli zamówisz trzy Kapsalony\r\nłączna kwota zamówienia\r\n\r\n\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(510, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(475, 56);
            this.label3.TabIndex = 4;
            this.label3.Text = "zmniejszy się o 10%\r\n";
            // 
            // buttonOrderNow
            // 
            this.buttonOrderNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.buttonOrderNow.FlatAppearance.BorderSize = 0;
            this.buttonOrderNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderNow.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOrderNow.ForeColor = System.Drawing.Color.White;
            this.buttonOrderNow.Location = new System.Drawing.Point(603, 412);
            this.buttonOrderNow.Name = "buttonOrderNow";
            this.buttonOrderNow.Size = new System.Drawing.Size(268, 39);
            this.buttonOrderNow.TabIndex = 5;
            this.buttonOrderNow.Text = "Zamów teraz!\r\n";
            this.buttonOrderNow.UseVisualStyleBackColor = false;
            this.buttonOrderNow.Click += new System.EventHandler(this.buttonOrderNow_Click);
            // 
            // UCHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonOrderNow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOnly);
            this.Name = "UCHome";
            this.Size = new System.Drawing.Size(1052, 528);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOnly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button buttonOrderNow;
    }
}
