
namespace AppRestaurant
{
    partial class FormAdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelInfo3 = new System.Windows.Forms.Label();
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.sidePanelButton = new System.Windows.Forms.Panel();
            this.buttonMenu1 = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.ucUsers1 = new AppRestaurant.UCUsers();
            this.ucMenuAdminPanel1 = new AppRestaurant.UCMenuAdminPanel();
            this.ucAddUser1 = new AppRestaurant.UCAddUser();
            this.ucAddProduct1 = new AppRestaurant.UCAddProduct();
            this.ucEditUser1 = new AppRestaurant.UCEditUser();
            this.ucAddProduct2 = new AppRestaurant.UCAddProduct();
            this.ucEditProduct1 = new AppRestaurant.UCEditProduct();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelInfo3);
            this.panel1.Controls.Add(this.labelInfo2);
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Controls.Add(this.sidePanelButton);
            this.panel1.Controls.Add(this.buttonMenu1);
            this.panel1.Controls.Add(this.buttonUsers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 681);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(106)))));
            this.label2.Location = new System.Drawing.Point(60, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "Panel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(53, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelInfo3
            // 
            this.labelInfo3.AutoSize = true;
            this.labelInfo3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfo3.Location = new System.Drawing.Point(3, 661);
            this.labelInfo3.Name = "labelInfo3";
            this.labelInfo3.Size = new System.Drawing.Size(99, 16);
            this.labelInfo3.TabIndex = 6;
            this.labelInfo3.Text = "All rights reserved";
            // 
            // labelInfo2
            // 
            this.labelInfo2.AutoSize = true;
            this.labelInfo2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfo2.Location = new System.Drawing.Point(3, 629);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(130, 16);
            this.labelInfo2.TabIndex = 5;
            this.labelInfo2.Text = "Szybka szamka © 2021 ";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfo.Location = new System.Drawing.Point(3, 645);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(96, 16);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "Dominik Bednarz";
            // 
            // sidePanelButton
            // 
            this.sidePanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(106)))));
            this.sidePanelButton.Location = new System.Drawing.Point(0, 324);
            this.sidePanelButton.Name = "sidePanelButton";
            this.sidePanelButton.Size = new System.Drawing.Size(12, 45);
            this.sidePanelButton.TabIndex = 3;
            // 
            // buttonMenu1
            // 
            this.buttonMenu1.FlatAppearance.BorderSize = 0;
            this.buttonMenu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMenu1.ForeColor = System.Drawing.Color.Black;
            this.buttonMenu1.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenu1.Image")));
            this.buttonMenu1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenu1.Location = new System.Drawing.Point(12, 415);
            this.buttonMenu1.Name = "buttonMenu1";
            this.buttonMenu1.Size = new System.Drawing.Size(200, 45);
            this.buttonMenu1.TabIndex = 1;
            this.buttonMenu1.Text = "      Menu";
            this.buttonMenu1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMenu1.UseVisualStyleBackColor = true;
            this.buttonMenu1.Click += new System.EventHandler(this.buttonMenu1_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.FlatAppearance.BorderSize = 0;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUsers.ForeColor = System.Drawing.Color.Black;
            this.buttonUsers.Image = ((System.Drawing.Image)(resources.GetObject("buttonUsers.Image")));
            this.buttonUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsers.Location = new System.Drawing.Point(12, 324);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(200, 45);
            this.buttonUsers.TabIndex = 0;
            this.buttonUsers.Text = "      Użytkownicy";
            this.buttonUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(106)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(212, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 12);
            this.panel2.TabIndex = 2;
            // 
            // buttonLogout
            // 
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Black;
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(1217, 18);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(35, 45);
            this.buttonLogout.TabIndex = 10;
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // ucUsers1
            // 
            this.ucUsers1.Location = new System.Drawing.Point(212, 66);
            this.ucUsers1.Name = "ucUsers1";
            this.ucUsers1.Size = new System.Drawing.Size(1052, 615);
            this.ucUsers1.TabIndex = 11;
            // 
            // ucMenuAdminPanel1
            // 
            this.ucMenuAdminPanel1.Location = new System.Drawing.Point(212, 66);
            this.ucMenuAdminPanel1.Name = "ucMenuAdminPanel1";
            this.ucMenuAdminPanel1.Size = new System.Drawing.Size(1052, 615);
            this.ucMenuAdminPanel1.TabIndex = 12;
            // 
            // ucAddUser1
            // 
            this.ucAddUser1.Location = new System.Drawing.Point(212, 69);
            this.ucAddUser1.Name = "ucAddUser1";
            this.ucAddUser1.Size = new System.Drawing.Size(1052, 615);
            this.ucAddUser1.TabIndex = 13;
            // 
            // ucAddProduct1
            // 
            this.ucAddProduct1.Location = new System.Drawing.Point(212, 66);
            this.ucAddProduct1.Name = "ucAddProduct1";
            this.ucAddProduct1.Size = new System.Drawing.Size(1052, 615);
            this.ucAddProduct1.TabIndex = 14;
            // 
            // ucEditUser1
            // 
            this.ucEditUser1.Location = new System.Drawing.Point(212, 66);
            this.ucEditUser1.Name = "ucEditUser1";
            this.ucEditUser1.Size = new System.Drawing.Size(1052, 615);
            this.ucEditUser1.TabIndex = 15;
            // 
            // ucAddProduct2
            // 
            this.ucAddProduct2.Location = new System.Drawing.Point(212, 66);
            this.ucAddProduct2.Name = "ucAddProduct2";
            this.ucAddProduct2.Size = new System.Drawing.Size(1052, 615);
            this.ucAddProduct2.TabIndex = 16;
            // 
            // ucEditProduct1
            // 
            this.ucEditProduct1.Location = new System.Drawing.Point(212, 66);
            this.ucEditProduct1.Name = "ucEditProduct1";
            this.ucEditProduct1.Size = new System.Drawing.Size(1052, 615);
            this.ucEditProduct1.TabIndex = 17;
            // 
            // FormAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucUsers1);
            this.Controls.Add(this.ucMenuAdminPanel1);
            this.Controls.Add(this.ucAddUser1);
            this.Controls.Add(this.ucAddProduct1);
            this.Controls.Add(this.ucEditUser1);
            this.Controls.Add(this.ucEditProduct1);
            this.Controls.Add(this.ucAddProduct2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdminPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelInfo3;
        private System.Windows.Forms.Label labelInfo2;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Panel sidePanelButton;
        private System.Windows.Forms.Button buttonMenu1;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UCUsers ucUsers1;
        private UCMenuAdminPanel ucMenuAdminPanel1;
        private UCAddUser ucAddUser1;
        private UCAddProduct ucAddProduct1;
        private UCEditUser ucEditUser1;
        private UCAddProduct ucAddProduct2;
        private UCEditProduct ucEditProduct1;
    }
}