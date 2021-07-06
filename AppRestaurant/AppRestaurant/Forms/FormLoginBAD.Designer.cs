
namespace AppRestaurant.Forms
{
    partial class FormLoginBAD
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
            this.buttonTryAgain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelZaloguj
            // 
            this.labelZaloguj.AutoSize = true;
            this.labelZaloguj.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZaloguj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(27)))));
            this.labelZaloguj.Location = new System.Drawing.Point(12, 23);
            this.labelZaloguj.Name = "labelZaloguj";
            this.labelZaloguj.Size = new System.Drawing.Size(116, 36);
            this.labelZaloguj.TabIndex = 2;
            this.labelZaloguj.Text = "Nie ma";
            // 
            // labelSie
            // 
            this.labelSie.AutoSize = true;
            this.labelSie.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.labelSie.Location = new System.Drawing.Point(134, 23);
            this.labelSie.Name = "labelSie";
            this.labelSie.Size = new System.Drawing.Size(124, 36);
            this.labelSie.TabIndex = 3;
            this.labelSie.Text = "takiego";
            // 
            // buttonTryAgain
            // 
            this.buttonTryAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.buttonTryAgain.FlatAppearance.BorderSize = 0;
            this.buttonTryAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTryAgain.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTryAgain.ForeColor = System.Drawing.Color.White;
            this.buttonTryAgain.Location = new System.Drawing.Point(75, 135);
            this.buttonTryAgain.Name = "buttonTryAgain";
            this.buttonTryAgain.Size = new System.Drawing.Size(250, 39);
            this.buttonTryAgain.TabIndex = 6;
            this.buttonTryAgain.Text = "Spróbuj ponownie!";
            this.buttonTryAgain.UseVisualStyleBackColor = false;
            this.buttonTryAgain.Click += new System.EventHandler(this.buttonTryAgain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(190, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "użytkownika!";
            // 
            // FormLoginBAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTryAgain);
            this.Controls.Add(this.labelSie);
            this.Controls.Add(this.labelZaloguj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoginBAD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoginBAD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZaloguj;
        private System.Windows.Forms.Label labelSie;
        private System.Windows.Forms.Button buttonTryAgain;
        private System.Windows.Forms.Label label1;
    }
}