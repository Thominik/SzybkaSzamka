
namespace AppRestaurant
{
    partial class UCOrderFirstPage
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
            this.dataGridViewLeft = new System.Windows.Forms.DataGridView();
            this.dataGridViewRight = new System.Windows.Forms.DataGridView();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonPassToOtherControl = new System.Windows.Forms.Button();
            this.menuModelBindingSourceRight = new System.Windows.Forms.BindingSource(this.components);
            this.idMenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuModelBindingSourceLeft = new System.Windows.Forms.BindingSource(this.components);
            this.idMenuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridRightQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuModelBindingSourceRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuModelBindingSourceLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLeft
            // 
            this.dataGridViewLeft.AutoGenerateColumns = false;
            this.dataGridViewLeft.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLeft.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMenuDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridViewLeft.DataSource = this.menuModelBindingSourceLeft;
            this.dataGridViewLeft.Location = new System.Drawing.Point(19, 22);
            this.dataGridViewLeft.Name = "dataGridViewLeft";
            this.dataGridViewLeft.Size = new System.Drawing.Size(434, 575);
            this.dataGridViewLeft.TabIndex = 0;
            // 
            // dataGridViewRight
            // 
            this.dataGridViewRight.AutoGenerateColumns = false;
            this.dataGridViewRight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRight.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMenuDataGridViewTextBoxColumn1,
            this.productNameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.gridRightQuantity});
            this.dataGridViewRight.DataSource = this.menuModelBindingSourceRight;
            this.dataGridViewRight.Location = new System.Drawing.Point(599, 22);
            this.dataGridViewRight.Name = "dataGridViewRight";
            this.dataGridViewRight.Size = new System.Drawing.Size(435, 575);
            this.dataGridViewRight.TabIndex = 1;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.buttonAddProduct.FlatAppearance.BorderSize = 0;
            this.buttonAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProduct.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddProduct.ForeColor = System.Drawing.Color.White;
            this.buttonAddProduct.Location = new System.Drawing.Point(459, 250);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(130, 39);
            this.buttonAddProduct.TabIndex = 5;
            this.buttonAddProduct.Text = "Dodaj";
            this.buttonAddProduct.UseVisualStyleBackColor = false;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.buttonDeleteProduct.FlatAppearance.BorderSize = 0;
            this.buttonDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteProduct.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteProduct.Location = new System.Drawing.Point(459, 319);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(130, 39);
            this.buttonDeleteProduct.TabIndex = 6;
            this.buttonDeleteProduct.Text = "Usuń";
            this.buttonDeleteProduct.UseVisualStyleBackColor = false;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonPassToOtherControl
            // 
            this.buttonPassToOtherControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.buttonPassToOtherControl.FlatAppearance.BorderSize = 0;
            this.buttonPassToOtherControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPassToOtherControl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPassToOtherControl.ForeColor = System.Drawing.Color.White;
            this.buttonPassToOtherControl.Location = new System.Drawing.Point(459, 388);
            this.buttonPassToOtherControl.Name = "buttonPassToOtherControl";
            this.buttonPassToOtherControl.Size = new System.Drawing.Size(130, 39);
            this.buttonPassToOtherControl.TabIndex = 7;
            this.buttonPassToOtherControl.Text = "Zamów";
            this.buttonPassToOtherControl.UseVisualStyleBackColor = false;
            this.buttonPassToOtherControl.Click += new System.EventHandler(this.buttonPassToOtherControl_Click);
            // 
            // menuModelBindingSourceRight
            // 
            this.menuModelBindingSourceRight.DataSource = typeof(AppRestaurant.Models.MenuModel);
            // 
            // idMenuDataGridViewTextBoxColumn
            // 
            this.idMenuDataGridViewTextBoxColumn.DataPropertyName = "IdMenu";
            this.idMenuDataGridViewTextBoxColumn.HeaderText = "Numer z menu";
            this.idMenuDataGridViewTextBoxColumn.Name = "idMenuDataGridViewTextBoxColumn";
            this.idMenuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Produkt";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // menuModelBindingSourceLeft
            // 
            this.menuModelBindingSourceLeft.DataSource = typeof(AppRestaurant.Models.MenuModel);
            // 
            // idMenuDataGridViewTextBoxColumn1
            // 
            this.idMenuDataGridViewTextBoxColumn1.DataPropertyName = "IdMenu";
            this.idMenuDataGridViewTextBoxColumn1.HeaderText = "Numer z menu";
            this.idMenuDataGridViewTextBoxColumn1.Name = "idMenuDataGridViewTextBoxColumn1";
            this.idMenuDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn1
            // 
            this.productNameDataGridViewTextBoxColumn1.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn1.HeaderText = "Produkt";
            this.productNameDataGridViewTextBoxColumn1.Name = "productNameDataGridViewTextBoxColumn1";
            this.productNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Cena";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gridRightQuantity
            // 
            this.gridRightQuantity.DataPropertyName = "Quantity";
            this.gridRightQuantity.HeaderText = "Ilość";
            this.gridRightQuantity.Name = "gridRightQuantity";
            // 
            // UCOrderFirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonPassToOtherControl);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.dataGridViewRight);
            this.Controls.Add(this.dataGridViewLeft);
            this.Name = "UCOrderFirstPage";
            this.Size = new System.Drawing.Size(1052, 615);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuModelBindingSourceRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuModelBindingSourceLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn idMenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource menuModelBindingSourceLeft;
        public System.Windows.Forms.BindingSource menuModelBindingSourceRight;
        public System.Windows.Forms.Button buttonAddProduct;
        public System.Windows.Forms.Button buttonDeleteProduct;
        public System.Windows.Forms.DataGridView dataGridViewLeft;
        public System.Windows.Forms.DataGridView dataGridViewRight;
        public System.Windows.Forms.Button buttonPassToOtherControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMenuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridRightQuantity;
    }
}
