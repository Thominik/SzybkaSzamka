
namespace AppRestaurant
{
    partial class UCOrderSecondPagee
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
            this.dataGridViewSecondOrderPage = new System.Windows.Forms.DataGridView();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCheckCode = new System.Windows.Forms.Button();
            this.buttonOrderEnd = new System.Windows.Forms.Button();
            this.checkBoxCreditCard = new System.Windows.Forms.CheckBox();
            this.checkBoxOutOrder = new System.Windows.Forms.CheckBox();
            this.labelDiscountCode = new System.Windows.Forms.Label();
            this.textBoxDiscountCode = new System.Windows.Forms.TextBox();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.textBoxFirstLastName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.idMenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMenuOrderLastPage = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecondOrderPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMenuOrderLastPage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSecondOrderPage
            // 
            this.dataGridViewSecondOrderPage.AutoGenerateColumns = false;
            this.dataGridViewSecondOrderPage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSecondOrderPage.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSecondOrderPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSecondOrderPage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMenuDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.Quantity,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridViewSecondOrderPage.DataSource = this.bsMenuOrderLastPage;
            this.dataGridViewSecondOrderPage.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewSecondOrderPage.Name = "dataGridViewSecondOrderPage";
            this.dataGridViewSecondOrderPage.Size = new System.Drawing.Size(415, 569);
            this.dataGridViewSecondOrderPage.TabIndex = 0;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Ilość";
            this.Quantity.Name = "Quantity";
            // 
            // buttonCheckCode
            // 
            this.buttonCheckCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.buttonCheckCode.FlatAppearance.BorderSize = 0;
            this.buttonCheckCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCheckCode.ForeColor = System.Drawing.Color.White;
            this.buttonCheckCode.Location = new System.Drawing.Point(820, 160);
            this.buttonCheckCode.Name = "buttonCheckCode";
            this.buttonCheckCode.Size = new System.Drawing.Size(96, 41);
            this.buttonCheckCode.TabIndex = 69;
            this.buttonCheckCode.Text = "Sprawdź kod!";
            this.buttonCheckCode.UseVisualStyleBackColor = false;
            this.buttonCheckCode.Click += new System.EventHandler(this.buttonCheckCode_Click);
            // 
            // buttonOrderEnd
            // 
            this.buttonOrderEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.buttonOrderEnd.FlatAppearance.BorderSize = 0;
            this.buttonOrderEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderEnd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOrderEnd.ForeColor = System.Drawing.Color.White;
            this.buttonOrderEnd.Location = new System.Drawing.Point(606, 550);
            this.buttonOrderEnd.Name = "buttonOrderEnd";
            this.buttonOrderEnd.Size = new System.Drawing.Size(268, 39);
            this.buttonOrderEnd.TabIndex = 68;
            this.buttonOrderEnd.Text = "Zamów!";
            this.buttonOrderEnd.UseVisualStyleBackColor = false;
            this.buttonOrderEnd.Click += new System.EventHandler(this.buttonOrderEnd_Click);
            // 
            // checkBoxCreditCard
            // 
            this.checkBoxCreditCard.AutoSize = true;
            this.checkBoxCreditCard.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxCreditCard.Location = new System.Drawing.Point(532, 228);
            this.checkBoxCreditCard.Name = "checkBoxCreditCard";
            this.checkBoxCreditCard.Size = new System.Drawing.Size(251, 28);
            this.checkBoxCreditCard.TabIndex = 67;
            this.checkBoxCreditCard.Text = "  Płatność zbliżeniowa";
            this.checkBoxCreditCard.UseVisualStyleBackColor = true;
            // 
            // checkBoxOutOrder
            // 
            this.checkBoxOutOrder.AutoSize = true;
            this.checkBoxOutOrder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxOutOrder.Location = new System.Drawing.Point(532, 262);
            this.checkBoxOutOrder.Name = "checkBoxOutOrder";
            this.checkBoxOutOrder.Size = new System.Drawing.Size(132, 28);
            this.checkBoxOutOrder.TabIndex = 66;
            this.checkBoxOutOrder.Text = "  Dostawa";
            this.checkBoxOutOrder.UseVisualStyleBackColor = true;
            this.checkBoxOutOrder.CheckedChanged += new System.EventHandler(this.checkBoxOutOrder_CheckedChanged);
            // 
            // labelDiscountCode
            // 
            this.labelDiscountCode.AutoSize = true;
            this.labelDiscountCode.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDiscountCode.Location = new System.Drawing.Point(531, 122);
            this.labelDiscountCode.Name = "labelDiscountCode";
            this.labelDiscountCode.Size = new System.Drawing.Size(159, 24);
            this.labelDiscountCode.TabIndex = 65;
            this.labelDiscountCode.Text = "Kod rabatowy:";
            // 
            // textBoxDiscountCode
            // 
            this.textBoxDiscountCode.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDiscountCode.Location = new System.Drawing.Point(537, 160);
            this.textBoxDiscountCode.Name = "textBoxDiscountCode";
            this.textBoxDiscountCode.Size = new System.Drawing.Size(246, 41);
            this.textBoxDiscountCode.TabIndex = 64;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTotalPrice.Location = new System.Drawing.Point(531, 29);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(189, 24);
            this.labelTotalPrice.TabIndex = 63;
            this.labelTotalPrice.Text = "Całkowita kwota:";
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTotalPrice.Location = new System.Drawing.Point(537, 67);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(246, 41);
            this.textBoxTotalPrice.TabIndex = 62;
            this.textBoxTotalPrice.TextChanged += new System.EventHandler(this.textBoxTotalPrice_TextChanged);
            // 
            // textBoxFirstLastName
            // 
            this.textBoxFirstLastName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFirstLastName.Location = new System.Drawing.Point(532, 331);
            this.textBoxFirstLastName.Name = "textBoxFirstLastName";
            this.textBoxFirstLastName.Size = new System.Drawing.Size(384, 31);
            this.textBoxFirstLastName.TabIndex = 70;
            this.textBoxFirstLastName.Text = "imię i nazwisko";
            this.textBoxFirstLastName.Enter += new System.EventHandler(this.textBoxFirstLastName_Enter);
            this.textBoxFirstLastName.Leave += new System.EventHandler(this.textBoxFirstLastName_Leave);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAddress.Location = new System.Drawing.Point(532, 387);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(384, 31);
            this.textBoxAddress.TabIndex = 71;
            this.textBoxAddress.Text = "adres";
            this.textBoxAddress.Enter += new System.EventHandler(this.textBoxAddress_Enter);
            this.textBoxAddress.Leave += new System.EventHandler(this.textBoxAddress_Leave);
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(532, 443);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(384, 31);
            this.textBoxPhoneNumber.TabIndex = 72;
            this.textBoxPhoneNumber.Text = "telefon";
            this.textBoxPhoneNumber.Enter += new System.EventHandler(this.textBoxPhoneNumber_Enter);
            this.textBoxPhoneNumber.Leave += new System.EventHandler(this.textBoxPhoneNumber_Leave);
            // 
            // idMenuDataGridViewTextBoxColumn
            // 
            this.idMenuDataGridViewTextBoxColumn.DataPropertyName = "IdMenu";
            this.idMenuDataGridViewTextBoxColumn.HeaderText = "Pozycja z menu";
            this.idMenuDataGridViewTextBoxColumn.Name = "idMenuDataGridViewTextBoxColumn";
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
            // bsMenuOrderLastPage
            // 
            this.bsMenuOrderLastPage.DataSource = typeof(AppRestaurant.Models.MenuModel);
            // 
            // UCOrderSecondPagee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxFirstLastName);
            this.Controls.Add(this.buttonCheckCode);
            this.Controls.Add(this.buttonOrderEnd);
            this.Controls.Add(this.checkBoxCreditCard);
            this.Controls.Add(this.checkBoxOutOrder);
            this.Controls.Add(this.labelDiscountCode);
            this.Controls.Add(this.textBoxDiscountCode);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.dataGridViewSecondOrderPage);
            this.Name = "UCOrderSecondPagee";
            this.Size = new System.Drawing.Size(1052, 615);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecondOrderPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMenuOrderLastPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewSecondOrderPage;
        public System.Windows.Forms.BindingSource bsMenuOrderLastPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button buttonCheckCode;
        public System.Windows.Forms.Button buttonOrderEnd;
        public System.Windows.Forms.CheckBox checkBoxCreditCard;
        public System.Windows.Forms.CheckBox checkBoxOutOrder;
        public System.Windows.Forms.Label labelDiscountCode;
        public System.Windows.Forms.TextBox textBoxDiscountCode;
        public System.Windows.Forms.Label labelTotalPrice;
        public System.Windows.Forms.TextBox textBoxTotalPrice;
        public System.Windows.Forms.TextBox textBoxFirstLastName;
        public System.Windows.Forms.TextBox textBoxAddress;
        public System.Windows.Forms.TextBox textBoxPhoneNumber;
    }
}
