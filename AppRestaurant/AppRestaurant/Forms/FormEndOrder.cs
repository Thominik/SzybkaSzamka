using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRestaurant.Forms
{
    public partial class FormEndOrder : Form
    {
        private readonly Random _random = new Random();

        public FormEndOrder(string totalPriceBox, bool takeAwayOrder, bool creditCard, string firstAndLastNameIfChecked, string addressIfChecked, string phonenumberIfChecked)
        {
            InitializeComponent();

            if (takeAwayOrder == true)            
                labelOrderTypeEdit.Text = "Dostawa";            
            else
                labelOrderTypeEdit.Text = "Na miejscu";


            if (creditCard == true)       
                labelPayTypeEdit.Text = "Kartą";
            else
                labelPayTypeEdit.Text = "Gotówką";


            labelPriceEdit.Text = totalPriceBox;

            double a = 50;
            double b = 51;
            double c = 100;
            double d = 300;

            if (Convert.ToDouble(labelPriceEdit.Text) < a)
                labelTimeEdit.Text = "15 min";
            else if (Convert.ToDouble(labelPriceEdit.Text) > b && Convert.ToDouble(labelPriceEdit.Text) < c)
                labelTimeEdit.Text = "30 min";
            else if (Convert.ToDouble(labelPriceEdit.Text) > c && Convert.ToDouble(labelPriceEdit.Text) < d)
                labelTimeEdit.Text = "Do 60 min";
            else
                labelTimeEdit.Text = "Ponad 60 min";
            

            labelOrderNumberEdit.Text = RandomNumber(1000, 9999).ToString();

            if (takeAwayOrder == false)
            {
                labelContactDetails.Visible = false;
                labelFirstLastName.Visible = false;
                labelAddress.Visible = false;
                labelPhoneNumber.Visible = false;
                
            }
            else
            {
                labelContactDetails.Visible = true;
                labelFirstLastName.Visible = true;
                labelAddress.Visible = true;
                labelPhoneNumber.Visible = true;
                

                labelFirstLastName.Text = firstAndLastNameIfChecked;
                labelAddress.Text = addressIfChecked;
                labelPhoneNumber.Text = phonenumberIfChecked;
            }
            
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

    }
}
