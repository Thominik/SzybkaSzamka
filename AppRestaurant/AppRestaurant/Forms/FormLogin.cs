using AppRestaurant.Forms;
using AppRestaurant.Models;
using AppRestaurant.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace AppRestaurant
{
    public partial class FormLogin : Form
    {
        private readonly string connectionString = @"Server=DESKTOP-58DQKAR\MSSQLSERVER2;Database = SzybkaSzamka2;User Id =Duuudi; Password=qwerty123";

        private AccountService globalAccountService = new AccountService();

        private AccountModel userLogged = null;
        public FormLogin()
        {
            InitializeComponent();
            NHService.Init(connectionString);
        }

        private void labelSie_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            var login = textBoxLogin.Text.ToString();
            var pass = textBoxPassword.Text.ToString();
            userLogged = globalAccountService.GetLogin(login, pass);

            if (userLogged == null)
            {
                FormLoginBAD formLoginBAD = new FormLoginBAD();
                formLoginBAD.ShowDialog();
                ClearBadPassword();                
            } 

            if (userLogged != null && userLogged.IsAdmin == false) 
            {
                FormLoginOK formLoginOK = new FormLoginOK();
                formLoginOK.ShowDialog();
                FormDiscount formDiscount = new FormDiscount();
                formDiscount.ShowDialog();
                Form1 form1 = new Form1(userLogged);
                form1.ShowDialog();
                ClearTextBoxes();

            }
            else if (userLogged != null && userLogged.IsAdmin == true)
            {
                FormAdminPanel formAdminPanel = new FormAdminPanel(userLogged);
                formAdminPanel.ShowDialog();
                ClearTextBoxes();
            }


            textBoxLogin.Text = "login";
            textBoxPassword.Text = "hasło";
            buttonLogout.Focus();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textLoginEnter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Equals("login"))
            {
                textBoxLogin.Text = "";
            }
        }

        private void textLoginLeave(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Equals(""))
            {
                textBoxLogin.Text = "login";
            }
        }

        private void textPassEnter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Equals("hasło"))
            {
                textBoxPassword.Text = "";
            }
        }

        private void textPassLeave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Equals(""))
            {
                textBoxPassword.Text = "hasło";
            }
        }

        void ClearBadPassword()
        {
            if (textBoxPassword != null)
            {
                string empty = string.Empty;
                textBoxPassword.Text = empty;
                textBoxLogin.Text = empty;
            }
        }

        void ClearTextBoxes()
        {
            if (textBoxLogin != null && textBoxPassword != null)
            {
                string empty2 = string.Empty;
                textBoxLogin.Text = empty2;
                textBoxPassword.Text = empty2;
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }

        private void textBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }
    }
}
