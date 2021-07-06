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
    public partial class UCOrderFirstPage : UserControl
    {

        public event EventHandler ButtonClickAdd;
        public event EventHandler ButtonClickDelete;
        public event EventHandler ButtonClickOrderNextPage;
        public UCOrderFirstPage()
        {
            InitializeComponent();

        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (this.ButtonClickAdd != null)
                this.ButtonClickAdd(this, e);
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if(this.ButtonClickDelete != null)
                this.ButtonClickDelete(this, e);
        }

        private void buttonPassToOtherControl_Click(object sender, EventArgs e)
        {
            if (this.ButtonClickOrderNextPage != null)
                this.ButtonClickOrderNextPage(this, e);
        }
    }
}
