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

namespace AppRestaurant
{
    public partial class UCOrder : UserControl
    {
        AccountModel globalAccModel = new AccountModel();
        public event EventHandler ButtonClick1;

        public UCOrder()
        {
            InitializeComponent();
        }

        private void buttonPlus1_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBoxQuantity1.Text);
            value++;
            textBoxQuantity1.Text = value.ToString();
            Counting();
        }

        private void buttonMinus1_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBoxQuantity1.Text);
            value--;
            textBoxQuantity1.Text = value.ToString();

            if (value < 0)
            {
                textBoxQuantity1.Text = "0";
            }
            Counting();
        }

        private void buttonPlus2_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBoxQuantity2.Text);
            value++;
            textBoxQuantity2.Text = value.ToString();
            Counting();
        }

        private void buttonMinus2_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBoxQuantity2.Text);
            value--;
            textBoxQuantity2.Text = value.ToString();

            if (value < 0)
            {
                textBoxQuantity2.Text = "0";
            }
            Counting();
        }

        private void buttonPlus3_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBoxQuantity3.Text);
            value++;
            textBoxQuantity3.Text = value.ToString();
            Counting();
        }

        private void buttonMinus3_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBoxQuantity3.Text);
            value--;
            textBoxQuantity3.Text = value.ToString();

            if (value < 0)
            {
                textBoxQuantity3.Text = "0";
            }
            Counting();
        }

        private void buttonPlus4_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBoxQuantity4.Text);
            value++;
            textBoxQuantity4.Text = value.ToString();
            Counting();
        }

        private void buttonMinus4_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBoxQuantity4.Text);
            value--;
            textBoxQuantity4.Text = value.ToString();

            if (value < 0)
            {
                textBoxQuantity4.Text = "0";
            }
            Counting();
        }

        private void buttonPlus5_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBoxQuantity5.Text);
            value++;
            textBoxQuantity5.Text = value.ToString();
            Counting();
        }

        private void buttonMinus5_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBoxQuantity5.Text);
            value--;
            textBoxQuantity5.Text = value.ToString();

            if (value < 0)
            {
                textBoxQuantity5.Text = "0";
            }
            Counting();
        }

        private void buttonPlus6_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBoxQuantity6.Text);
            value++;
            textBoxQuantity6.Text = value.ToString();
            Counting();
        }

        private void buttonMinus6_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBoxQuantity6.Text);
            value--;
            textBoxQuantity6.Text = value.ToString();

            if (value < 0)
            {
                textBoxQuantity6.Text = "0";
            }
            Counting();
        }

        private void buttonPlus7_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBoxQuantity7.Text);
            value++;
            textBoxQuantity7.Text = value.ToString();
            Counting();
        }

        private void buttonMinus7_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBoxQuantity7.Text);
            value--;
            textBoxQuantity7.Text = value.ToString();

            if (value < 0)
            {
                textBoxQuantity7.Text = "0";
            }
            Counting();
        }

        private void buttonPlus8_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBoxQuantity8.Text);
            value++;
            textBoxQuantity8.Text = value.ToString();
            Counting();
        }

        private void buttonMinus8_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBoxQuantity8.Text);
            value--;
            textBoxQuantity8.Text = value.ToString();

            if (value < 0)
            {
                textBoxQuantity8.Text = "0";
            }
            Counting();
        }

        private void Counting()
        {
            MenuService menuService = new MenuService();
            List<MenuModel> menuModelList = menuService.GetAll();

            var txt1 = Convert.ToInt32(textBoxQuantity1.Text);
            var txt2 = Convert.ToInt32(textBoxQuantity2.Text);
            var txt3 = Convert.ToInt32(textBoxQuantity3.Text);
            var txt4 = Convert.ToInt32(textBoxQuantity4.Text);
            var txt5 = Convert.ToInt32(textBoxQuantity5.Text);
            var txt6 = Convert.ToInt32(textBoxQuantity6.Text);
            var txt7 = Convert.ToInt32(textBoxQuantity7.Text);
            var txt8 = Convert.ToInt32(textBoxQuantity8.Text);

            int mMListCount = menuModelList.Count;

            for (int i = 0; i < menuModelList.Count; i++)
            {
                var a = Convert.ToInt32(menuModelList[0].Price) * txt1;
                var b = Convert.ToInt32(menuModelList[1].Price) * txt2;
                var c = Convert.ToInt32(menuModelList[2].Price) * txt3;
                var d = Convert.ToInt32(menuModelList[3].Price) * txt4;
                var e = Convert.ToInt32(menuModelList[4].Price) * txt5;
                var f = Convert.ToInt32(menuModelList[5].Price) * txt6;
                var g = Convert.ToInt32(menuModelList[6].Price) * txt7;
                var h = Convert.ToInt32(menuModelList[7].Price) * txt8;

                textBoxTotalPrice.Text = (a + b + c + d + e + f + g + h).ToString();
            }

        }

        private void textBoxQuantity1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxQuantity2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxQuantity3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxQuantity4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxQuantity5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxQuantity6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxQuantity7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxQuantity8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxTotalPrice_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxQuantity3.Text) == 3)
            {
                this.textBoxTotalPrice.TextChanged -= new System.EventHandler(this.textBoxTotalPrice_TextChanged);
                textBoxTotalPrice.Text = (Convert.ToDouble(textBoxTotalPrice.Text) * (0.8)).ToString();
                this.textBoxTotalPrice.TextChanged += new System.EventHandler(this.textBoxTotalPrice_TextChanged);
            }
        }

        private void buttonCheckCode_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick1 != null)
                this.ButtonClick1(this, e);
        }

        private void buttonOrderEnd_Click(object sender, EventArgs e)
        {
            //string totalPriceBox = textBoxTotalPrice.Text;
            //bool takeAwayOrder = checkBoxOutOrder.Checked;
            //bool creditCard = checkBoxCreditCard.Checked;

            //if (totalPriceBox == "")
            //{
            //    MessageBox.Show("Nic nie zamówiłeś.");
            //}
            //else
            //{
            //   // FormEndOrder formEndOrder = new FormEndOrder(totalPriceBox, takeAwayOrder, creditCard);
            //   // formEndOrder.ShowDialog();
            //}
            
        }

        private void textBoxQuantity3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxQuantity6_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
