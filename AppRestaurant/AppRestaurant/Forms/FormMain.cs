using AppRestaurant.Forms;
using AppRestaurant.Models;
using AppRestaurant.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace AppRestaurant
{
    public partial class Form1 : Form
    {

        public AccountModel globalAccountModel = new AccountModel();
        OrderNumberService globalOrderNumberService = new OrderNumberService();
        MenuModel globalMenuModel = new MenuModel();
        MenuService globalMenuService = new MenuService();
        List<MenuModel> switchMenu = new List<MenuModel>();
        public Form1(AccountModel accModel)
        {
            InitializeComponent();
            sidePanelButton.Height = buttonHome.Height;
            sidePanelButton.Top = buttonHome.Top;
            ucHome1.BringToFront();

            ucHomePage1.BringToFront();
            ucOrder1.ButtonClick1 += new EventHandler(ucOder_ButtonClick);
            ucOrderFirstPage1.ButtonClickAdd += new EventHandler(ucOrderFirstPage_ButtonAdd);
            ucOrderFirstPage1.ButtonClickDelete += new EventHandler(ucOrderFirstPage_ButtonDelete);
            ucOrderFirstPage1.ButtonClickOrderNextPage += new EventHandler(ucOrderFirstPage_ButtonOrderToNextPage);
            ucOrderSecondPagee1.UCOrderSecond_OrderButton += new EventHandler(ucOrderSecondPage_OrderButton);
            ucOrderSecondPagee1.UCOrderSecond_CheckDiscountCodeButton += new EventHandler(ucOrderSecondPage_DiscountCodeButton);

            globalAccountModel = accModel;

            ucAccount2.orderNumberModelBindingSource3.DataSource = globalOrderNumberService.GetOrders(accModel.IdAccount);
            ucRestaurantMenu1.menuModelBindingSource.DataSource = globalMenuService.GetAll();
            var menu = globalMenuService.GetAll();
            ucOrderFirstPage1.menuModelBindingSourceLeft.DataSource = menu;

        }

        #region UCOrderSecondPage_Buttons
        protected void ucOrderSecondPage_OrderButton(object sender, EventArgs e)
        {

        }

        protected void ucOrderSecondPage_DiscountCodeButton(object sender, EventArgs e)
        {
            if (ucOrderSecondPagee1.textBoxDiscountCode.Text == globalAccountModel.DiscountCode)
            {
                ucOrderSecondPagee1.textBoxTotalPrice.Text = (Convert.ToDouble(ucOrderSecondPagee1.textBoxTotalPrice.Text) * (0.8)).ToString();
            }
        }
        #endregion

        protected void ucOrderFirstPage_ButtonAdd(object sender, EventArgs e)
        {

            var switchProduct = ucOrderFirstPage1.menuModelBindingSourceLeft.Current as MenuModel;
            switchMenu.Add(switchProduct);
            ucOrderFirstPage1.menuModelBindingSourceRight.DataSource = switchMenu;
            ucOrderFirstPage1.menuModelBindingSourceRight.ResetBindings(true);


        }

        protected void ucOrderFirstPage_ButtonDelete(object sender, EventArgs e)
        {
            ucOrderFirstPage1.menuModelBindingSourceRight.RemoveCurrent();
        }

        protected void ucOrderFirstPage_ButtonOrderToNextPage(object sender, EventArgs e)
        {
            ucOrderSecondPagee1.bsMenuOrderLastPage.DataSource = switchMenu;

            List<MenuModel> menuModelsList = new List<MenuModel>();
            menuModelsList = (List<MenuModel>)ucOrderSecondPagee1.bsMenuOrderLastPage.DataSource;

            int totalyPrice = 0;
            for (int i = 0; i < menuModelsList.Count; i++)
            {
                int totally = Convert.ToInt32(menuModelsList[i].Quantity) * Convert.ToInt32(menuModelsList[i].Price);
                totalyPrice = totalyPrice + (Convert.ToInt32(menuModelsList[i].Quantity) * Convert.ToInt32(menuModelsList[i].Price));
            }
            ucOrderSecondPagee1.textBoxTotalPrice.Text = totalyPrice.ToString();

            for (int i = 0; i < menuModelsList.Count; i++)
            {
                if (menuModelsList[i].ProductName == "Kapsalon" || menuModelsList[i].ProductName == "Greko Box")
                {
                    if (menuModelsList[i].ProductName == "Greko Box")
                    {
                        ucOrderSecondPagee1.textBoxTotalPrice.Text = (Convert.ToDouble(ucOrderSecondPagee1.textBoxTotalPrice.Text) * (0.9)).ToString();
                    }
                }
            }

            OrderNumberModel orderToSave = BuildSaveOrderModel(totalyPrice, menuModelsList);


            globalOrderNumberService.SaveOrder(orderToSave);

            ucOrderSecondPagee1.BringToFront();
        }
        private OrderNumberModel BuildSaveOrderModel(int totalPrice, List<MenuModel> menuModelsList)
        {
            OrderNumberModel order = new OrderNumberModel()
            {
                AccountModel = globalAccountModel,
                TotalPrice = totalPrice,

            };

            HashSet<OrderPositionModel> posiotionList = new HashSet<OrderPositionModel>();
            foreach (var elem in menuModelsList)
            {
                OrderPositionModel pos = new OrderPositionModel()
                {
                    MenuModel = elem,
                    Price = Convert.ToInt32(elem.Price),
                    Quantity = elem.Quantity,
                    OrderNumberModel = order
                };

                posiotionList.Add(pos);
            }
            order.OrderPositionModelList1 = posiotionList;

            return order;
        }

        protected void ucOder_ButtonClick(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            sidePanelButton.Height = buttonHome.Height;
            sidePanelButton.Top = buttonHome.Top;
            ucHomePage1.BringToFront();

        }
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            sidePanelButton.Height = buttonMenu.Height;
            sidePanelButton.Top = buttonMenu.Top;

            ucRestaurantMenu1.BringToFront();

        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            sidePanelButton.Height = buttonAccount.Height;
            sidePanelButton.Top = buttonAccount.Top;
            ucAccount2.labelFirstName.Text = globalAccountModel.FirstName;

            if (globalAccountModel.DiscountCode == "")
                ucAccount2.labelDiscountCode.Text = "Nie masz żadnych kodów rabatowych!";
            else
                ucAccount2.labelDiscountCode.Text = globalAccountModel.DiscountCode;

            ucAccount2.BringToFront();
        }
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            sidePanelButton.Height = buttonOrder.Height;
            sidePanelButton.Top = buttonOrder.Top;

            ucOrderFirstPage1.BringToFront();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.Application.ExitThread();
            this.Hide();
        }

        private void buttonFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/dudusiekplay/");
        }

    }
}
