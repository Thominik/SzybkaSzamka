
namespace AppRestaurant.Forms
{
    partial class FormLoginOK
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
            this.labelZaloguj = new System.Windows.Forms.Label();
            this.labelSie = new System.Windows.Forms.Label();
            this.buttonLoggedOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelZaloguj
            // 
            this.labelZaloguj.AutoSize = true;
            this.labelZaloguj.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZaloguj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(27)))));
            this.labelZaloguj.Location = new System.Drawing.Point(12, 9);
            this.labelZaloguj.Name = "labelZaloguj";
            this.labelZaloguj.Size = new System.Drawing.Size(316, 56);
            this.labelZaloguj.TabIndex = 1;
            this.labelZaloguj.Text = "Zalogowano";
            // 
            // labelSie
            // 
            this.labelSie.AutoSize = true;
            this.labelSie.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.labelSie.Location = new System.Drawing.Point(111, 65);
            this.labelSie.Name = "labelSie";
            this.labelSie.Size = new System.Drawing.Size(278, 56);
            this.labelSie.TabIndex = 2;
            this.labelSie.Text = "pomyślnie!";
            // 
            // buttonLoggedOk
            // 
            this.buttonLoggedOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.buttonLoggedOk.FlatAppearance.BorderSize = 0;
            this.buttonLoggedOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoggedOk.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLoggedOk.ForeColor = System.Drawing.Color.White;
            this.buttonLoggedOk.Location = new System.Drawing.Point(125, 151);
            this.buttonLoggedOk.Name = "buttonLoggedOk";
            this.buttonLoggedOk.Size = new System.Drawing.Size(150, 39);
            this.buttonLoggedOk.TabIndex = 5;
            this.buttonLoggedOk.Text = "OK";
            this.buttonLoggedOk.UseVisualStyleBackColor = false;
            this.buttonLoggedOk.Click += new System.EventHandler(this.buttonLoggedOk_Click);
            // 
            // FormLoginOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.buttonLoggedOk);
            this.Controls.Add(this.labelSie);
            this.Controls.Add(this.labelZaloguj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoginOK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDiscount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZaloguj;
        private System.Windows.Forms.Label labelSie;
        private System.Windows.Forms.Button buttonLoggedOk;
    }
}