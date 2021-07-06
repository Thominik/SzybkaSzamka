namespace AppRestaurant
{
    partial class UCMenuAdminPanel
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
            this.components = new System.ComponentModel.Container();
            this.labelMenu = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonEditProd = new System.Windows.Forms.Button();
            this.buttonDeleteProd = new System.Windows.Forms.Button();
            this.buttonAddProd = new System.Windows.Forms.Button();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuModelBindingSourceADM = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuModelBindingSourceADM)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(47)))));
            this.labelMenu.Location = new System.Drawing.Point(20, 15);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(131, 44);
            this.labelMenu.TabIndex = 8;
            this.labelMenu.Text = "Menu:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.menuModelBindingSourceADM;
            this.dataGridView1.Location = new System.Drawing.Point(86, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 521);
            this.dataGridView1.TabIndex = 9;
            // 
            // buttonEditProd
            // 
            this.buttonEditProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(106)))));
            this.buttonEditProd.FlatAppearance.BorderSize = 0;
            this.buttonEditProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditProd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEditProd.ForeColor = System.Drawing.Color.White;
            this.buttonEditProd.Location = new System.Drawing.Point(662, 225);
            this.buttonEditProd.Name = "buttonEditProd";
            this.buttonEditProd.Size = new System.Drawing.Size(300, 39);
            this.buttonEditProd.TabIndex = 13;
            this.buttonEditProd.Text = "Edytuj";
            this.buttonEditProd.UseVisualStyleBackColor = false;
            this.buttonEditProd.Click += new System.EventHandler(this.buttonEditProd_Click);
            // 
            // buttonDeleteProd
            // 
            this.buttonDeleteProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(106)))));
            this.buttonDeleteProd.FlatAppearance.BorderSize = 0;
            this.buttonDeleteProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteProd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteProd.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteProd.Location = new System.Drawing.Point(662, 148);
            this.buttonDeleteProd.Name = "buttonDeleteProd";
            this.buttonDeleteProd.Size = new System.Drawing.Size(300, 39);
            this.buttonDeleteProd.TabIndex = 12;
            this.buttonDeleteProd.Text = "Usuń";
            this.buttonDeleteProd.UseVisualStyleBackColor = false;
            this.buttonDeleteProd.Click += new System.EventHandler(this.buttonDeleteProd_Click);
            // 
            // buttonAddProd
            // 
            this.buttonAddProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(106)))));
            this.buttonAddProd.FlatAppearance.BorderSize = 0;
            this.buttonAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddProd.ForeColor = System.Drawing.Color.White;
            this.buttonAddProd.Location = new System.Drawing.Point(662, 71);
            this.buttonAddProd.Name = "buttonAddProd";
            this.buttonAddProd.Size = new System.Drawing.Size(300, 39);
            this.buttonAddProd.TabIndex = 11;
            this.buttonAddProd.Text = "Dodaj";
            this.buttonAddProd.UseVisualStyleBackColor = false;
            this.buttonAddProd.Click += new System.EventHandler(this.buttonAddProd_Click);
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Produkt";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // menuModelBindingSourceADM
            // 
            this.menuModelBindingSourceADM.DataSource = typeof(AppRestaurant.Models.MenuModel);
            // 
            // UCMenuAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonEditProd);
            this.Controls.Add(this.buttonDeleteProd);
            this.Controls.Add(this.buttonAddProd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelMenu);
            this.Name = "UCMenuAdminPanel";
            this.Size = new System.Drawing.Size(1052, 615);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuModelBindingSourceADM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource menuModelBindingSourceADM;
        public System.Windows.Forms.Button buttonEditProd;
        public System.Windows.Forms.Button buttonDeleteProd;
        public System.Windows.Forms.Button buttonAddProd;
    }
}
