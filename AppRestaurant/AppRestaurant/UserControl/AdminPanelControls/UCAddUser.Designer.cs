namespace AppRestaurant
{
    partial class UCAddUser
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
            this.labelMenu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFirstNameAdd = new System.Windows.Forms.TextBox();
            this.textBoxLastNameAdd = new System.Windows.Forms.TextBox();
            this.textBoxLoginAdd = new System.Windows.Forms.TextBox();
            this.textBoxPasswordAdd = new System.Windows.Forms.TextBox();
            this.textBoxDiscountCode = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBoxIsAdmin = new System.Windows.Forms.CheckBox();
            this.buttonAddUserLastControl = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(47)))));
            this.labelMenu.Location = new System.Drawing.Point(156, 38);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(78, 33);
            this.labelMenu.TabIndex = 9;
            this.labelMenu.Text = "Imię:";
            this.labelMenu.Click += new System.EventHandler(this.labelMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(91, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nazwisko:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(47)))));
            this.label2.Location = new System.Drawing.Point(142, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Login:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(47)))));
            this.label3.Location = new System.Drawing.Point(139, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hasło:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(47)))));
            this.label4.Location = new System.Drawing.Point(23, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kod rabatowy:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(47)))));
            this.label5.Location = new System.Drawing.Point(126, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 33);
            this.label5.TabIndex = 14;
            this.label5.Text = "Admin:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxFirstNameAdd
            // 
            this.textBoxFirstNameAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFirstNameAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFirstNameAdd.Location = new System.Drawing.Point(240, 48);
            this.textBoxFirstNameAdd.Name = "textBoxFirstNameAdd";
            this.textBoxFirstNameAdd.Size = new System.Drawing.Size(308, 24);
            this.textBoxFirstNameAdd.TabIndex = 16;
            this.textBoxFirstNameAdd.TextChanged += new System.EventHandler(this.textBoxFirstNameAdd_TextChanged);
            // 
            // textBoxLastNameAdd
            // 
            this.textBoxLastNameAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLastNameAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLastNameAdd.Location = new System.Drawing.Point(240, 144);
            this.textBoxLastNameAdd.Name = "textBoxLastNameAdd";
            this.textBoxLastNameAdd.Size = new System.Drawing.Size(308, 24);
            this.textBoxLastNameAdd.TabIndex = 17;
            this.textBoxLastNameAdd.TextChanged += new System.EventHandler(this.textBoxLastNameAdd_TextChanged);
            // 
            // textBoxLoginAdd
            // 
            this.textBoxLoginAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoginAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLoginAdd.Location = new System.Drawing.Point(240, 239);
            this.textBoxLoginAdd.Name = "textBoxLoginAdd";
            this.textBoxLoginAdd.Size = new System.Drawing.Size(308, 24);
            this.textBoxLoginAdd.TabIndex = 18;
            this.textBoxLoginAdd.TextChanged += new System.EventHandler(this.textBoxLoginAdd_TextChanged);
            // 
            // textBoxPasswordAdd
            // 
            this.textBoxPasswordAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPasswordAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPasswordAdd.Location = new System.Drawing.Point(240, 336);
            this.textBoxPasswordAdd.Name = "textBoxPasswordAdd";
            this.textBoxPasswordAdd.Size = new System.Drawing.Size(308, 24);
            this.textBoxPasswordAdd.TabIndex = 19;
            this.textBoxPasswordAdd.TextChanged += new System.EventHandler(this.textBoxPasswordAdd_TextChanged);
            // 
            // textBoxDiscountCode
            // 
            this.textBoxDiscountCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDiscountCode.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDiscountCode.Location = new System.Drawing.Point(240, 432);
            this.textBoxDiscountCode.Name = "textBoxDiscountCode";
            this.textBoxDiscountCode.Size = new System.Drawing.Size(308, 24);
            this.textBoxDiscountCode.TabIndex = 20;
            this.textBoxDiscountCode.TextChanged += new System.EventHandler(this.textBoxDiscountCode_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-15, -15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsAdmin
            // 
            this.checkBoxIsAdmin.AutoSize = true;
            this.checkBoxIsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxIsAdmin.Location = new System.Drawing.Point(280, 510);
            this.checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            this.checkBoxIsAdmin.Size = new System.Drawing.Size(47, 46);
            this.checkBoxIsAdmin.TabIndex = 22;
            this.checkBoxIsAdmin.Text = " ";
            this.checkBoxIsAdmin.UseVisualStyleBackColor = true;
            this.checkBoxIsAdmin.CheckedChanged += new System.EventHandler(this.checkBoxIsAdmin_CheckedChanged);
            // 
            // buttonAddUserLastControl
            // 
            this.buttonAddUserLastControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(106)))));
            this.buttonAddUserLastControl.FlatAppearance.BorderSize = 0;
            this.buttonAddUserLastControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUserLastControl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddUserLastControl.ForeColor = System.Drawing.Color.White;
            this.buttonAddUserLastControl.Location = new System.Drawing.Point(715, 96);
            this.buttonAddUserLastControl.Name = "buttonAddUserLastControl";
            this.buttonAddUserLastControl.Size = new System.Drawing.Size(250, 39);
            this.buttonAddUserLastControl.TabIndex = 23;
            this.buttonAddUserLastControl.Text = "Dodaj";
            this.buttonAddUserLastControl.UseVisualStyleBackColor = false;
            this.buttonAddUserLastControl.Click += new System.EventHandler(this.buttonAddUserLastControl_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(106)))));
            this.buttonReturn.FlatAppearance.BorderSize = 0;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReturn.ForeColor = System.Drawing.Color.White;
            this.buttonReturn.Location = new System.Drawing.Point(715, 209);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(250, 39);
            this.buttonReturn.TabIndex = 24;
            this.buttonReturn.Text = "Powrót";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // UCAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonAddUserLastControl);
            this.Controls.Add(this.checkBoxIsAdmin);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxDiscountCode);
            this.Controls.Add(this.textBoxPasswordAdd);
            this.Controls.Add(this.textBoxLoginAdd);
            this.Controls.Add(this.textBoxLastNameAdd);
            this.Controls.Add(this.textBoxFirstNameAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMenu);
            this.Name = "UCAddUser";
            this.Size = new System.Drawing.Size(1052, 615);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxFirstNameAdd;
        public System.Windows.Forms.TextBox textBoxLastNameAdd;
        public System.Windows.Forms.TextBox textBoxLoginAdd;
        public System.Windows.Forms.TextBox textBoxPasswordAdd;
        public System.Windows.Forms.TextBox textBoxDiscountCode;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.CheckBox checkBoxIsAdmin;
        public System.Windows.Forms.Button buttonAddUserLastControl;
        public System.Windows.Forms.Button buttonReturn;
    }
}
