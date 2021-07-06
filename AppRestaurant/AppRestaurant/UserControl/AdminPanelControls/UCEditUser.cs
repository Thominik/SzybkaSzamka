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
    public partial class UCEditUser : UserControl
    {
        public event EventHandler ButtonEditClick;
        public event EventHandler ButtonReturnFromEditClick;


        public UCEditUser()
        {
            InitializeComponent();
        }

        private void buttonAddEditUser_Click(object sender, EventArgs e)
        {
            if (this.ButtonEditClick != null)
                this.ButtonEditClick(this, e);
        }

        private void buttonReturnFromEdit_Click(object sender, EventArgs e)
        {
            if (this.ButtonReturnFromEditClick != null)
                this.ButtonReturnFromEditClick(this, e);
        }
    }
}
