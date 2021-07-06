using AppRestaurant.Forms;
using AppRestaurant.Models;
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
    public partial class UCOrderSecondPagee : UserControl
    {
        public event EventHandler UCOrderSecond_OrderButton;
        public event EventHandler UCOrderSecond_CheckDiscountCodeButton;

        public List<MenuModel> menuModelList = new List<MenuModel>();
        public UCOrderSecondPagee()
        {
            InitializeComponent();
            textBoxPhoneNumber.Visible = false;
            textBoxAddress.Visible = false;
            textBoxFirstLastName.Visible = false;


            //TotalPriceCount();

        }

        public void TotalPriceCount()
        {
            List<MenuModel> menuModelList = new List<MenuModel>();
            MenuModel menuModels = new MenuModel();
            MenuModel model = dataGridViewSecondOrderPage.DataSource as MenuModel;

            menuModelList = (List<MenuModel>)bsMenuOrderLastPage.DataSource;
            var mCount = menuModelList.Count;

            for (int i = 0; i < mCount; i++)
            {
                int totally = Convert.ToInt32(menuModelList[i].Quantity) * Convert.ToInt32(menuModelList[i].Price);

                textBoxTotalPrice.Text = totally.ToString();
                                
            }

            

            
        }

        private void buttonOrderEnd_Click(object sender, EventArgs e)
        {
            if (this.UCOrderSecond_OrderButton != null)
                this.UCOrderSecond_OrderButton(this, e);

            string totalPriceBox = textBoxTotalPrice.Text;
            bool takeAwayOrder = checkBoxOutOrder.Checked;
            bool creditCard = checkBoxCreditCard.Checked;
            string firstAndLastNameIfChecked = textBoxFirstLastName.Text;
            string addressIfChecked = textBoxAddress.Text;
            string phoneNumberIfChecked = textBoxPhoneNumber.Text;

            if (totalPriceBox == "")
            {
                MessageBox.Show("Nic nie zamówiłeś.");
            }
            else
            {
                FormEndOrder formEndOrder = new FormEndOrder(totalPriceBox, takeAwayOrder, creditCard, firstAndLastNameIfChecked, addressIfChecked, phoneNumberIfChecked);
                formEndOrder.ShowDialog();
            }

            
        }

        private void buttonCheckCode_Click(object sender, EventArgs e)
        {
            if (this.UCOrderSecond_CheckDiscountCodeButton != null)
                this.UCOrderSecond_CheckDiscountCodeButton(this, e);
        }

        private void checkBoxOutOrder_CheckedChanged(object sender, EventArgs e)
        {
            textBoxFirstLastName.Visible = checkBoxOutOrder.Checked;
            textBoxAddress.Visible = checkBoxOutOrder.Checked;
            textBoxPhoneNumber.Visible = checkBoxOutOrder.Checked;
        }

        private void textBoxTotalPrice_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxFirstLastName_Enter(object sender, EventArgs e)
        {
            if (textBoxFirstLastName.Text.Equals("imię i nazwisko"))
            {
                textBoxFirstLastName.Text = "";
            }
        }

        private void textBoxFirstLastName_Leave(object sender, EventArgs e)
        {
            if (textBoxFirstLastName.Text.Equals(""))
            {
                textBoxFirstLastName.Text = "imię i nazwisko";
            }
        }

        private void textBoxAddress_Enter(object sender, EventArgs e)
        {
            if (textBoxAddress.Text.Equals("adres"))
            {
                textBoxAddress.Text = "";
            }
        }

        private void textBoxAddress_Leave(object sender, EventArgs e)
        {
            if (textBoxAddress.Text.Equals(""))
            {
                textBoxAddress.Text = "adres";
            }
        }

        private void textBoxPhoneNumber_Enter(object sender, EventArgs e)
        {
            if (textBoxPhoneNumber.Text.Equals("telefon"))
            {
                textBoxPhoneNumber.Text = "";
            }
        }

        private void textBoxPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (textBoxPhoneNumber.Text.Equals(""))
            {
                textBoxPhoneNumber.Text = "telefon";
            }
        }
    }
}
