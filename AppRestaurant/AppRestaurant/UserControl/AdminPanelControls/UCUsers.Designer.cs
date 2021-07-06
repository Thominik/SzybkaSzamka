namespace AppRestaurant
{
    partial class UCUsers
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
            this.gridUsers = new System.Windows.Forms.DataGridView();
            this.labelUsers = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.accountLoginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.discountCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountModelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.accountModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountModelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountModelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUsers
            // 
            this.gridUsers.AllowUserToAddRows = false;
            this.gridUsers.AllowUserToDeleteRows = false;
            this.gridUsers.AutoGenerateColumns = false;
            this.gridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUsers.BackgroundColor = System.Drawing.Color.White;
            this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountLoginDataGridViewTextBoxColumn,
            this.accountPasswordDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.isAdminDataGridViewCheckBoxColumn,
            this.discountCodeDataGridViewTextBoxColumn});
            this.gridUsers.DataSource = this.accountModelBindingSource2;
            this.gridUsers.Location = new System.Drawing.Point(28, 77);
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.ReadOnly = true;
            this.gridUsers.Size = new System.Drawing.Size(643, 514);
            this.gridUsers.TabIndex = 0;
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(47)))));
            this.labelUsers.Location = new System.Drawing.Point(20, 15);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(254, 44);
            this.labelUsers.TabIndex = 7;
            this.labelUsers.Text = "Użytkownicy:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DiscountCodeModel";
            this.dataGridViewTextBoxColumn1.HeaderText = "DiscountCodeModel";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DiscountCodeModel";
            this.dataGridViewTextBoxColumn2.HeaderText = "Kod promocyjny";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(106)))));
            this.buttonAddUser.FlatAppearance.BorderSize = 0;
            this.buttonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddUser.ForeColor = System.Drawing.Color.White;
            this.buttonAddUser.Location = new System.Drawing.Point(707, 77);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(300, 39);
            this.buttonAddUser.TabIndex = 8;
            this.buttonAddUser.Text = "Dodaj";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(106)))));
            this.buttonDeleteUser.FlatAppearance.BorderSize = 0;
            this.buttonDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteUser.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteUser.Location = new System.Drawing.Point(707, 154);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(300, 39);
            this.buttonDeleteUser.TabIndex = 9;
            this.buttonDeleteUser.Text = "Usuń";
            this.buttonDeleteUser.UseVisualStyleBackColor = false;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(106)))));
            this.buttonEditUser.FlatAppearance.BorderSize = 0;
            this.buttonEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditUser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEditUser.ForeColor = System.Drawing.Color.White;
            this.buttonEditUser.Location = new System.Drawing.Point(707, 231);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(300, 39);
            this.buttonEditUser.TabIndex = 10;
            this.buttonEditUser.Text = "Edytuj";
            this.buttonEditUser.UseVisualStyleBackColor = false;
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);
            // 
            // accountLoginDataGridViewTextBoxColumn
            // 
            this.accountLoginDataGridViewTextBoxColumn.DataPropertyName = "AccountLogin";
            this.accountLoginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.accountLoginDataGridViewTextBoxColumn.Name = "accountLoginDataGridViewTextBoxColumn";
            this.accountLoginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountPasswordDataGridViewTextBoxColumn
            // 
            this.accountPasswordDataGridViewTextBoxColumn.DataPropertyName = "AccountPassword";
            this.accountPasswordDataGridViewTextBoxColumn.HeaderText = "Hasło";
            this.accountPasswordDataGridViewTextBoxColumn.Name = "accountPasswordDataGridViewTextBoxColumn";
            this.accountPasswordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Imię";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isAdminDataGridViewCheckBoxColumn
            // 
            this.isAdminDataGridViewCheckBoxColumn.DataPropertyName = "IsAdmin";
            this.isAdminDataGridViewCheckBoxColumn.HeaderText = "Prawa admina";
            this.isAdminDataGridViewCheckBoxColumn.Name = "isAdminDataGridViewCheckBoxColumn";
            this.isAdminDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // discountCodeDataGridViewTextBoxColumn
            // 
            this.discountCodeDataGridViewTextBoxColumn.DataPropertyName = "DiscountCode";
            this.discountCodeDataGridViewTextBoxColumn.HeaderText = "Kod rabatowy";
            this.discountCodeDataGridViewTextBoxColumn.Name = "discountCodeDataGridViewTextBoxColumn";
            this.discountCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountModelBindingSource2
            // 
            this.accountModelBindingSource2.DataSource = typeof(AppRestaurant.Models.AccountModel);
            // 
            // accountModelBindingSource
            // 
            this.accountModelBindingSource.DataSource = typeof(AppRestaurant.Models.AccountModel);
            // 
            // accountModelBindingSource1
            // 
            this.accountModelBindingSource1.DataSource = typeof(AppRestaurant.Models.AccountModel);
            // 
            // UCUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonEditUser);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.gridUsers);
            this.Name = "UCUsers";
            this.Size = new System.Drawing.Size(1052, 615);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountModelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountModelBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView gridUsers;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public System.Windows.Forms.Button buttonAddUser;
        public System.Windows.Forms.Button buttonDeleteUser;
        public System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.BindingSource accountModelBindingSource1;
        public System.Windows.Forms.BindingSource accountModelBindingSource2;
        private System.Windows.Forms.BindingSource accountModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountLoginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAdminDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountCodeDataGridViewTextBoxColumn;
    }
}
