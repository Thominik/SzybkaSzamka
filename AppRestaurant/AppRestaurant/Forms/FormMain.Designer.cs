
namespace AppRestaurant
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelInfo3 = new System.Windows.Forms.Label();
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.sidePanelButton = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonFacebook = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.ucHomePage1 = new AppRestaurant.UCHomePage();
            this.ucAccount2 = new AppRestaurant.UCAccount();
            this.ucRestaurantMenu1 = new AppRestaurant.UCRestaurantMenu();
            this.ucOrderFirstPage1 = new AppRestaurant.UCOrderFirstPage();
            this.ucAccount1 = new AppRestaurant.UCAccount();
            this.ucOrder1 = new AppRestaurant.UCOrder();
            this.ucHome1 = new AppRestaurant.UCHome();
            this.ucOrderSecondPagee1 = new AppRestaurant.UCOrderSecondPagee();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelInfo3);
            this.panel1.Controls.Add(this.labelInfo2);
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Controls.Add(this.sidePanelButton);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Controls.Add(this.buttonOrder);
            this.panel1.Controls.Add(this.buttonMenu);
            this.panel1.Controls.Add(this.buttonAccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 681);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 24);
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
            this.sidePanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.sidePanelButton.Location = new System.Drawing.Point(0, 233);
            this.sidePanelButton.Name = "sidePanelButton";
            this.sidePanelButton.Size = new System.Drawing.Size(12, 45);
            this.sidePanelButton.TabIndex = 3;
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHome.ForeColor = System.Drawing.Color.Black;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(12, 233);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(200, 45);
            this.buttonHome.TabIndex = 3;
            this.buttonHome.Text = "      Początek\r\n";
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.FlatAppearance.BorderSize = 0;
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrder.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOrder.ForeColor = System.Drawing.Color.Black;
            this.buttonOrder.Image = ((System.Drawing.Image)(resources.GetObject("buttonOrder.Image")));
            this.buttonOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrder.Location = new System.Drawing.Point(12, 506);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(200, 45);
            this.buttonOrder.TabIndex = 2;
            this.buttonOrder.Text = "      Zamówienie";
            this.buttonOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMenu.ForeColor = System.Drawing.Color.Black;
            this.buttonMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenu.Image")));
            this.buttonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenu.Location = new System.Drawing.Point(12, 415);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(200, 45);
            this.buttonMenu.TabIndex = 1;
            this.buttonMenu.Text = "      Menu";
            this.buttonMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonAccount
            // 
            this.buttonAccount.FlatAppearance.BorderSize = 0;
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAccount.ForeColor = System.Drawing.Color.Black;
            this.buttonAccount.Image = ((System.Drawing.Image)(resources.GetObject("buttonAccount.Image")));
            this.buttonAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccount.Location = new System.Drawing.Point(12, 324);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(200, 45);
            this.buttonAccount.TabIndex = 0;
            this.buttonAccount.Text = "      Konto\r\n";
            this.buttonAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAccount.UseVisualStyleBackColor = true;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(212, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 12);
            this.panel2.TabIndex = 1;
            // 
            // buttonFacebook
            // 
            this.buttonFacebook.FlatAppearance.BorderSize = 0;
            this.buttonFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFacebook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFacebook.ForeColor = System.Drawing.Color.Black;
            this.buttonFacebook.Image = ((System.Drawing.Image)(resources.GetObject("buttonFacebook.Image")));
            this.buttonFacebook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFacebook.Location = new System.Drawing.Point(1164, 24);
            this.buttonFacebook.Name = "buttonFacebook";
            this.buttonFacebook.Size = new System.Drawing.Size(35, 45);
            this.buttonFacebook.TabIndex = 7;
            this.buttonFacebook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFacebook.UseVisualStyleBackColor = true;
            this.buttonFacebook.Click += new System.EventHandler(this.buttonFacebook_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Black;
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(1217, 24);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(35, 45);
            this.buttonLogout.TabIndex = 9;
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // ucHomePage1
            // 
            this.ucHomePage1.Location = new System.Drawing.Point(212, 66);
            this.ucHomePage1.Name = "ucHomePage1";
            this.ucHomePage1.Size = new System.Drawing.Size(1052, 615);
            this.ucHomePage1.TabIndex = 10;
            // 
            // ucAccount2
            // 
            this.ucAccount2.Location = new System.Drawing.Point(212, 66);
            this.ucAccount2.Name = "ucAccount2";
            this.ucAccount2.Size = new System.Drawing.Size(1052, 615);
            this.ucAccount2.TabIndex = 11;
            // 
            // ucRestaurantMenu1
            // 
            this.ucRestaurantMenu1.Location = new System.Drawing.Point(212, 66);
            this.ucRestaurantMenu1.Name = "ucRestaurantMenu1";
            this.ucRestaurantMenu1.Size = new System.Drawing.Size(1052, 615);
            this.ucRestaurantMenu1.TabIndex = 12;
            // 
            // ucOrderFirstPage1
            // 
            this.ucOrderFirstPage1.Location = new System.Drawing.Point(212, 66);
            this.ucOrderFirstPage1.Name = "ucOrderFirstPage1";
            this.ucOrderFirstPage1.Size = new System.Drawing.Size(1052, 615);
            this.ucOrderFirstPage1.TabIndex = 13;
            // 
            // ucAccount1
            // 
            this.ucAccount1.Location = new System.Drawing.Point(212, 153);
            this.ucAccount1.Name = "ucAccount1";
            this.ucAccount1.Size = new System.Drawing.Size(1052, 528);
            this.ucAccount1.TabIndex = 11;
            // 
            // ucOrder1
            // 
            this.ucOrder1.Location = new System.Drawing.Point(212, 153);
            this.ucOrder1.Name = "ucOrder1";
            this.ucOrder1.Size = new System.Drawing.Size(1052, 528);
            this.ucOrder1.TabIndex = 14;
            // 
            // ucHome1
            // 
            this.ucHome1.Location = new System.Drawing.Point(212, 153);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(1052, 528);
            this.ucHome1.TabIndex = 10;
            // 
            // ucOrderSecondPagee1
            // 
            this.ucOrderSecondPagee1.Location = new System.Drawing.Point(212, 66);
            this.ucOrderSecondPagee1.Name = "ucOrderSecondPagee1";
            this.ucOrderSecondPagee1.Size = new System.Drawing.Size(1052, 615);
            this.ucOrderSecondPagee1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ucHomePage1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonFacebook);
            this.Controls.Add(this.ucAccount2);
            this.Controls.Add(this.ucRestaurantMenu1);
            this.Controls.Add(this.ucOrderFirstPage1);
            this.Controls.Add(this.ucOrderSecondPagee1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel sidePanelButton;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonFacebook;
        private System.Windows.Forms.Button buttonLogout;
        private UCHome ucHome1;
        private UCAccount ucAccount1;
       //private UCMenu ucMenu1;
        private UCOrder ucOrder1;
        private System.Windows.Forms.Label labelInfo3;
        private System.Windows.Forms.Label labelInfo2;
        private System.Windows.Forms.Label labelInfo;
        private UCHomePage ucHomePage1;
        private UCAccount ucAccount2;
        private UCRestaurantMenu ucRestaurantMenu1;
        private UCOrderFirstPage ucOrderFirstPage1;
        private UCOrderSecondPagee ucOrderSecondPagee1;
        //private UCOrderSecondPage ucOrderSecondPage1;
    }
}

