using AppRestaurant.Models;
using AppRestaurant.Models.DataSourceDTOs;
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

namespace AppRestaurant
{
    public partial class FormAdminPanel : Form
    {
        public AccountModel globalAccModel = new AccountModel();
        public AccountService globalAccServ = new AccountService();
        private List<AccountModel> accModelList = new List<AccountModel>();
        private MenuService globalMenuServ = new MenuService();
        private AccountService globalAccToUsing = new AccountService();
        private AccountService accountServiceGet = new AccountService();
        private MenuService globalMenuServiceToUsing = new MenuService();
        private string emptyString = string.Empty;

        public FormAdminPanel(AccountModel account)
        {
            InitializeComponent();
            globalAccModel = account;
            accModelList = globalAccServ.GetAll();

            
            ucUsers1.accountModelBindingSource2.DataSource = accountServiceGet.GetAll();

            ucMenuAdminPanel1.menuModelBindingSourceADM.DataSource = globalMenuServ.GetAll();

            ucUsers1.ButtonClickAdd += new EventHandler(ucUsersAddUser_Click);
            ucUsers1.ButtonClickDel += new EventHandler(ucUsersDelUser_Click);
            ucUsers1.ButtonClickEdit += new EventHandler(ucUsersEditUser_Click);
            ucMenuAdminPanel1.ButtonClickAddProd += new EventHandler(ucMenuAddProd_Click);
            ucMenuAdminPanel1.ButtonClickDelProd += new EventHandler(ucMenuDelProd_Click);
            ucMenuAdminPanel1.ButtonClickEditProd += new EventHandler(ucMenuEditProd_Click);
            ucAddUser1.ButtonClickBack_FromAddUser += new EventHandler(ucAddUser_Back_Click);
            ucAddUser1.ButtonClickAddUserDone += new EventHandler(ucAddNewUser_Click);
            ucEditUser1.ButtonEditClick += new EventHandler(ucEditUser_Click);
            ucEditUser1.ButtonReturnFromEditClick += new EventHandler(ucEditReturn_Click);
            ucAddProduct1.ButtonAddProduct_FromAddControl += new EventHandler(ucAddProduct_AddButton);
            ucAddProduct1.ButtonReturn_FromAddProd += new EventHandler(ucAddProduct_ReturnButton);
            ucEditProduct1.ButtonEditProduct_FromEditProductControl += new EventHandler(ucEditProduct_EditClickButton);
            ucEditProduct1.ButtonReturn_FromEditProductControl += new EventHandler(ucEditProduct_ReturnButton);
            
        }

        #region UcMenuAdminPanel
        protected void ucMenuAddProd_Click(object sender, EventArgs e)
        {
            ucAddProduct1.BringToFront();
        }
        protected void ucMenuDelProd_Click(object sender, EventArgs e)
        {
            var prod = ucMenuAdminPanel1.menuModelBindingSourceADM.Current as MenuModel;
            globalMenuServiceToUsing.Delete(prod);
            ucMenuAdminPanel1.menuModelBindingSourceADM.RemoveCurrent();
        }
        protected void ucMenuEditProd_Click(object sender, EventArgs e)
        {
            MenuModel menuModel = new MenuModel();
            var menu = menuModel;
            menu = ucMenuAdminPanel1.menuModelBindingSourceADM.Current as MenuModel;
            ucEditProduct1.textBoxProductNameEdit.Text = menu.ProductName;
            ucEditProduct1.textBoxPriceEdit.Text = menu.Price;

            ucEditProduct1.BringToFront();
        }
        #endregion

        #region Buttons_in_UCUsers


        protected void ucUsersAddUser_Click(object sender, EventArgs e)
        {
            ucAddUser1.BringToFront();
        }

        protected void ucUsersDelUser_Click(object sender, EventArgs e)
        {
            var user = ucUsers1.accountModelBindingSource2.Current as AccountModel;

            globalAccToUsing.Delete(user);
            ucUsers1.accountModelBindingSource2.RemoveCurrent();
        }
        protected void ucUsersEditUser_Click(object sender, EventArgs e)
        {

            AccountModel accountModelUs = new AccountModel();
            var us = accountModelUs;
            us = ucUsers1.accountModelBindingSource2.Current as AccountModel;
            ucEditUser1.textBoxLoginEdit.Text = us.AccountLogin;
            ucEditUser1.textBoxPasswordEdit.Text = us.AccountPassword;
            ucEditUser1.textBoxFirstNameEdit.Text = us.FirstName;
            ucEditUser1.textBoxLastNameEdit.Text = us.LastName;
            ucEditUser1.textBoxDiscountCodeEdit.Text = us.DiscountCode;
            ucEditUser1.checkBoxIsAdminEdit.Checked = us.IsAdmin;

            ucEditUser1.BringToFront();
        }

        #endregion

        #region Buttons_in_UCAddUser
        private void ucAddNewUser_Click(object sender, EventArgs e)
        {

            AccountModel toSaveAccount = new AccountModel();
            toSaveAccount.FirstName = ucAddUser1.textBoxFirstNameAdd.Text;
            toSaveAccount.LastName = ucAddUser1.textBoxLastNameAdd.Text;
            toSaveAccount.AccountLogin = ucAddUser1.textBoxLoginAdd.Text;
            toSaveAccount.AccountPassword = ucAddUser1.textBoxPasswordAdd.Text;
            toSaveAccount.IsAdmin = ucAddUser1.checkBoxIsAdmin.Checked;
            toSaveAccount.DiscountCode = ucAddUser1.textBoxDiscountCode.Text;

            globalAccToUsing.Add(toSaveAccount);
            //ucUsers1.gridUsers.DataSource = globalAccToUsing.GetAll();
            ucUsers1.BringToFront();
            ClearUserBoxes();

            ucUsers1.accountModelBindingSource2.DataSource = accountServiceGet.GetAll();
            ucUsers1.gridUsers.Refresh();
        }

        protected void ucAddUser_Back_Click(object sender, EventArgs e)
        {
            ucUsers1.accountModelBindingSource2.DataSource = accountServiceGet.GetAll();
            ucUsers1.BringToFront();
        }

        #endregion

        #region Buttons_in_UCEditUser
        protected void ucEditUser_Click(object sender, EventArgs e)
        {


            var usc = ucUsers1.accountModelBindingSource2.Current as AccountModel;
            usc.AccountLogin = ucEditUser1.textBoxLoginEdit.Text;
            usc.AccountPassword = ucEditUser1.textBoxPasswordEdit.Text;
            usc.FirstName = ucEditUser1.textBoxFirstNameEdit.Text;
            usc.LastName = ucEditUser1.textBoxLastNameEdit.Text;
            usc.DiscountCode = ucEditUser1.textBoxDiscountCodeEdit.Text;
            usc.IsAdmin = ucEditUser1.checkBoxIsAdminEdit.Checked;

            globalAccToUsing.Add(usc);

            ucUsers1.BringToFront();


            ucUsers1.accountModelBindingSource2.DataSource = accountServiceGet.GetAll();
            ucUsers1.gridUsers.Refresh();
        }

        protected void ucEditReturn_Click(object sender, EventArgs e)
        {
            ucUsers1.BringToFront();
        }


        #endregion

        #region Buttons_in_UCAddProduct
        protected void ucAddProduct_AddButton(object sender, EventArgs e)
        {
            MenuService menuService = new MenuService();
            MenuModel toSaveMenu = new MenuModel();
            toSaveMenu.ProductName = ucAddProduct1.textBoxProductNameAdd.Text;
            toSaveMenu.Price = ucAddProduct1.textBoxPriceAdd.Text;

            menuService.Add(toSaveMenu);
            ucMenuAdminPanel1.BringToFront();
            ClearMenuBoxes();
            ucMenuAdminPanel1.menuModelBindingSourceADM.DataSource = menuService.GetAll();
        }

        protected void ucAddProduct_ReturnButton(object sender, EventArgs e)
        {
            MenuService menuServices = new MenuService();
            ucMenuAdminPanel1.menuModelBindingSourceADM.DataSource = menuServices.GetAll()  ;
            ucMenuAdminPanel1.BringToFront();
        }


        #endregion

        #region Buttons_in_UCEditProduct
        protected void ucEditProduct_EditClickButton(object sender, EventArgs e)
        {
            MenuService menuService = new MenuService();
            var prod = ucMenuAdminPanel1.menuModelBindingSourceADM.Current as MenuModel;
            prod.ProductName = ucEditProduct1.textBoxProductNameEdit.Text;
            prod.Price = ucEditProduct1.textBoxPriceEdit.Text;

            menuService.Add(prod);
            ucMenuAdminPanel1.BringToFront();

            ucMenuAdminPanel1.menuModelBindingSourceADM.DataSource = menuService.GetAll();
        }

        protected void ucEditProduct_ReturnButton(object sender, EventArgs e)
        {
            ucMenuAdminPanel1.BringToFront();
        }
        #endregion



        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            sidePanelButton.Height = buttonUsers.Height;
            sidePanelButton.Top = buttonUsers.Top;
            ucUsers1.BringToFront();
        }

        private void buttonMenu1_Click(object sender, EventArgs e)
        {
            sidePanelButton.Height = buttonMenu1.Height;
            sidePanelButton.Top = buttonMenu1.Top;
            ucMenuAdminPanel1.BringToFront();
        }

        private void ClearUserBoxes()
        {
            ucAddUser1.textBoxFirstNameAdd.Text = emptyString;
            ucAddUser1.textBoxLastNameAdd.Text = emptyString;
            ucAddUser1.textBoxLoginAdd.Text = emptyString;
            ucAddUser1.textBoxPasswordAdd.Text = emptyString;
            ucAddUser1.textBoxDiscountCode.Text = emptyString;
            ucAddUser1.checkBoxIsAdmin.Checked = false;
        }

        private void ClearMenuBoxes()
        {
            ucAddProduct1.textBoxProductNameAdd.Text = emptyString;
            ucAddProduct1.textBoxPriceAdd.Text = emptyString;
        }

    }
}
