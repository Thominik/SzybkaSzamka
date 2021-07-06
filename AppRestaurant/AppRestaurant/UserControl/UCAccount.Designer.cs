
namespace AppRestaurant
{
    partial class UCAccount
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
            this.labelCzesc = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelYourDiscountCode = new System.Windows.Forms.Label();
            this.labelDiscountCode = new System.Windows.Forms.Label();
            this.gridLastOrders = new System.Windows.Forms.DataGridView();
            this.foodOrderModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelLastOrders = new System.Windows.Forms.Label();
            this.orderNumberModelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridLastOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodOrderModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberModelBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCzesc
            // 
            this.labelCzesc.AutoSize = true;
            this.labelCzesc.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCzesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(27)))));
            this.labelCzesc.Location = new System.Drawing.Point(56, 43);
            this.labelCzesc.Name = "labelCzesc";
            this.labelCzesc.Size = new System.Drawing.Size(222, 77);
            this.labelCzesc.TabIndex = 4;
            this.labelCzesc.Text = "Cześć";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirstName.Location = new System.Drawing.Point(248, 133);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(242, 58);
            this.labelFirstName.TabIndex = 5;
            this.labelFirstName.Text = "firstName";
            this.labelFirstName.Click += new System.EventHandler(this.labelFirstName_Click);
            // 
            // labelYourDiscountCode
            // 
            this.labelYourDiscountCode.AutoSize = true;
            this.labelYourDiscountCode.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYourDiscountCode.Location = new System.Drawing.Point(77, 317);
            this.labelYourDiscountCode.Name = "labelYourDiscountCode";
            this.labelYourDiscountCode.Size = new System.Drawing.Size(274, 30);
            this.labelYourDiscountCode.TabIndex = 6;
            this.labelYourDiscountCode.Text = "Twoje kody rabatowe:\r\n";
            // 
            // labelDiscountCode
            // 
            this.labelDiscountCode.AutoSize = true;
            this.labelDiscountCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDiscountCode.Location = new System.Drawing.Point(78, 389);
            this.labelDiscountCode.Name = "labelDiscountCode";
            this.labelDiscountCode.Size = new System.Drawing.Size(118, 19);
            this.labelDiscountCode.TabIndex = 7;
            this.labelDiscountCode.Text = "Kod rabatowy";
            // 
            // gridLastOrders
            // 
            this.gridLastOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLastOrders.AutoGenerateColumns = false;
            this.gridLastOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLastOrders.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridLastOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLastOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.gridLastOrders.DataSource = this.orderNumberModelBindingSource3;
            this.gridLastOrders.Location = new System.Drawing.Point(596, 161);
            this.gridLastOrders.Name = "gridLastOrders";
            this.gridLastOrders.Size = new System.Drawing.Size(371, 420);
            this.gridLastOrders.TabIndex = 8;
            this.gridLastOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLastOrders_CellContentClick);
            // 
            // labelLastOrders
            // 
            this.labelLastOrders.AutoSize = true;
            this.labelLastOrders.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLastOrders.Location = new System.Drawing.Point(591, 102);
            this.labelLastOrders.Name = "labelLastOrders";
            this.labelLastOrders.Size = new System.Drawing.Size(272, 30);
            this.labelLastOrders.TabIndex = 9;
            this.labelLastOrders.Text = "Ostatnie zamówienia:";
            // 
            // orderNumberModelBindingSource3
            // 
            this.orderNumberModelBindingSource3.DataSource = typeof(AppRestaurant.Models.OrderNumberModel);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdOrder";
            this.dataGridViewTextBoxColumn1.HeaderText = "Numer zamówienia:";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TotalPrice";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cena całkowita";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // UCAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelLastOrders);
            this.Controls.Add(this.gridLastOrders);
            this.Controls.Add(this.labelDiscountCode);
            this.Controls.Add(this.labelYourDiscountCode);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelCzesc);
            this.Name = "UCAccount";
            this.Size = new System.Drawing.Size(1052, 615);
            ((System.ComponentModel.ISupportInitialize)(this.gridLastOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodOrderModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberModelBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCzesc;
        private System.Windows.Forms.Label labelYourDiscountCode;
        private System.Windows.Forms.Label labelLastOrders;
        public System.Windows.Forms.Label labelFirstName;
        public System.Windows.Forms.Label labelDiscountCode;
        public System.Windows.Forms.DataGridView gridLastOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource foodOrderModelBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public System.Windows.Forms.BindingSource orderNumberModelBindingSource3;
    }
}
