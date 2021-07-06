namespace AppRestaurant
{
    partial class UCEditProduct
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
            this.buttonReturnFromEditProduct = new System.Windows.Forms.Button();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.textBoxPriceEdit = new System.Windows.Forms.TextBox();
            this.textBoxProductNameEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReturnFromEditProduct
            // 
            this.buttonReturnFromEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(106)))));
            this.buttonReturnFromEditProduct.FlatAppearance.BorderSize = 0;
            this.buttonReturnFromEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturnFromEditProduct.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReturnFromEditProduct.ForeColor = System.Drawing.Color.White;
            this.buttonReturnFromEditProduct.Location = new System.Drawing.Point(690, 326);
            this.buttonReturnFromEditProduct.Name = "buttonReturnFromEditProduct";
            this.buttonReturnFromEditProduct.Size = new System.Drawing.Size(250, 39);
            this.buttonReturnFromEditProduct.TabIndex = 36;
            this.buttonReturnFromEditProduct.Text = "Powrót";
            this.buttonReturnFromEditProduct.UseVisualStyleBackColor = false;
            this.buttonReturnFromEditProduct.Click += new System.EventHandler(this.buttonReturnFromEditProduct_Click);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(106)))));
            this.buttonEditProduct.FlatAppearance.BorderSize = 0;
            this.buttonEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditProduct.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEditProduct.ForeColor = System.Drawing.Color.White;
            this.buttonEditProduct.Location = new System.Drawing.Point(690, 245);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(250, 39);
            this.buttonEditProduct.TabIndex = 35;
            this.buttonEditProduct.Text = "Zakończ edycję";
            this.buttonEditProduct.UseVisualStyleBackColor = false;
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // textBoxPriceEdit
            // 
            this.textBoxPriceEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPriceEdit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPriceEdit.Location = new System.Drawing.Point(118, 381);
            this.textBoxPriceEdit.Name = "textBoxPriceEdit";
            this.textBoxPriceEdit.Size = new System.Drawing.Size(308, 24);
            this.textBoxPriceEdit.TabIndex = 34;
            // 
            // textBoxProductNameEdit
            // 
            this.textBoxProductNameEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProductNameEdit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxProductNameEdit.Location = new System.Drawing.Point(118, 260);
            this.textBoxProductNameEdit.Name = "textBoxProductNameEdit";
            this.textBoxProductNameEdit.Size = new System.Drawing.Size(308, 24);
            this.textBoxProductNameEdit.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(112, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 33);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cena:";
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(47)))));
            this.labelMenu.Location = new System.Drawing.Point(112, 209);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(239, 33);
            this.labelMenu.TabIndex = 31;
            this.labelMenu.Text = "Nazwa produktu:";
            // 
            // UCEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonReturnFromEditProduct);
            this.Controls.Add(this.buttonEditProduct);
            this.Controls.Add(this.textBoxPriceEdit);
            this.Controls.Add(this.textBoxProductNameEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMenu);
            this.Name = "UCEditProduct";
            this.Size = new System.Drawing.Size(1052, 615);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonReturnFromEditProduct;
        public System.Windows.Forms.Button buttonEditProduct;
        public System.Windows.Forms.TextBox textBoxPriceEdit;
        public System.Windows.Forms.TextBox textBoxProductNameEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMenu;
    }
}
