namespace AppRestaurant
{
    partial class UCAddProduct
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
            this.buttonReturnFromAddingProduct = new System.Windows.Forms.Button();
            this.buttonAddProductInAddControl = new System.Windows.Forms.Button();
            this.textBoxPriceAdd = new System.Windows.Forms.TextBox();
            this.textBoxProductNameAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReturnFromAddingProduct
            // 
            this.buttonReturnFromAddingProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(106)))));
            this.buttonReturnFromAddingProduct.FlatAppearance.BorderSize = 0;
            this.buttonReturnFromAddingProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturnFromAddingProduct.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReturnFromAddingProduct.ForeColor = System.Drawing.Color.White;
            this.buttonReturnFromAddingProduct.Location = new System.Drawing.Point(689, 318);
            this.buttonReturnFromAddingProduct.Name = "buttonReturnFromAddingProduct";
            this.buttonReturnFromAddingProduct.Size = new System.Drawing.Size(250, 39);
            this.buttonReturnFromAddingProduct.TabIndex = 30;
            this.buttonReturnFromAddingProduct.Text = "Powrót";
            this.buttonReturnFromAddingProduct.UseVisualStyleBackColor = false;
            this.buttonReturnFromAddingProduct.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonAddProductInAddControl
            // 
            this.buttonAddProductInAddControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(106)))));
            this.buttonAddProductInAddControl.FlatAppearance.BorderSize = 0;
            this.buttonAddProductInAddControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProductInAddControl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddProductInAddControl.ForeColor = System.Drawing.Color.White;
            this.buttonAddProductInAddControl.Location = new System.Drawing.Point(689, 237);
            this.buttonAddProductInAddControl.Name = "buttonAddProductInAddControl";
            this.buttonAddProductInAddControl.Size = new System.Drawing.Size(250, 39);
            this.buttonAddProductInAddControl.TabIndex = 29;
            this.buttonAddProductInAddControl.Text = "Dodaj";
            this.buttonAddProductInAddControl.UseVisualStyleBackColor = false;
            this.buttonAddProductInAddControl.Click += new System.EventHandler(this.buttonAddProductLastControl_Click);
            // 
            // textBoxPriceAdd
            // 
            this.textBoxPriceAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPriceAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPriceAdd.Location = new System.Drawing.Point(117, 373);
            this.textBoxPriceAdd.Name = "textBoxPriceAdd";
            this.textBoxPriceAdd.Size = new System.Drawing.Size(308, 24);
            this.textBoxPriceAdd.TabIndex = 28;
            // 
            // textBoxProductNameAdd
            // 
            this.textBoxProductNameAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProductNameAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxProductNameAdd.Location = new System.Drawing.Point(117, 252);
            this.textBoxProductNameAdd.Name = "textBoxProductNameAdd";
            this.textBoxProductNameAdd.Size = new System.Drawing.Size(308, 24);
            this.textBoxProductNameAdd.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(111, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 33);
            this.label1.TabIndex = 26;
            this.label1.Text = "Cena:";
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(47)))));
            this.labelMenu.Location = new System.Drawing.Point(111, 201);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(239, 33);
            this.labelMenu.TabIndex = 25;
            this.labelMenu.Text = "Nazwa produktu:";
            // 
            // UCAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonReturnFromAddingProduct);
            this.Controls.Add(this.buttonAddProductInAddControl);
            this.Controls.Add(this.textBoxPriceAdd);
            this.Controls.Add(this.textBoxProductNameAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMenu);
            this.Name = "UCAddProduct";
            this.Size = new System.Drawing.Size(1052, 615);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonReturnFromAddingProduct;
        public System.Windows.Forms.Button buttonAddProductInAddControl;
        public System.Windows.Forms.TextBox textBoxPriceAdd;
        public System.Windows.Forms.TextBox textBoxProductNameAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMenu;
    }
}
