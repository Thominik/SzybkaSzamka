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
    public partial class UCEditProduct : UserControl
    {
        public event EventHandler ButtonEditProduct_FromEditProductControl;
        public event EventHandler ButtonReturn_FromEditProductControl;
        public UCEditProduct()
        {
            InitializeComponent();
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            if (this.ButtonEditProduct_FromEditProductControl != null)
                this.ButtonEditProduct_FromEditProductControl(this, e);
        }

        private void buttonReturnFromEditProduct_Click(object sender, EventArgs e)
        {
            if (this.ButtonReturn_FromEditProductControl != null)
                this.ButtonReturn_FromEditProductControl(this, e);
        }
    }
}
