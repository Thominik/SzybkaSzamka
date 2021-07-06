using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRestaurant
{
    public partial class UCAddUser : UserControl
    {

        public event EventHandler ButtonClickAddUserDone;
        public event EventHandler ButtonClickBack_FromAddUser;
        
        public UCAddUser()
        {
            InitializeComponent();
        }

        private void buttonAddUserLastControl_Click(object sender, EventArgs e)
        {
            if (this.ButtonClickAddUserDone != null)
                this.ButtonClickAddUserDone(this, e);
            
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if (this.ButtonClickBack_FromAddUser != null)
                this.ButtonClickBack_FromAddUser(this, e);
        }

        private void checkBoxIsAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDiscountCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPasswordAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLoginAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLastNameAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstNameAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
