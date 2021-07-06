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
    public partial class UCAddProduct : UserControl
    {
        public event EventHandler ButtonAddProduct_FromAddControl;
        public event EventHandler ButtonReturn_FromAddProd;
        public UCAddProduct()
        {
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if (this.ButtonReturn_FromAddProd != null)
                this.ButtonReturn_FromAddProd(this, e);
        }

        private void buttonAddProductLastControl_Click(object sender, EventArgs e)
        {
            if (this.ButtonAddProduct_FromAddControl != null)
                this.ButtonAddProduct_FromAddControl(this, e);
        }
    }
}
