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
    public partial class UCMenuAdminPanel : UserControl
    {
        public event EventHandler ButtonClickAddProd;
        public event EventHandler ButtonClickDelProd;
        public event EventHandler ButtonClickEditProd;

        public UCMenuAdminPanel()
        {
            InitializeComponent();
        }

        private void buttonAddProd_Click(object sender, EventArgs e)
        {
            if (this.ButtonClickAddProd != null)
                this.ButtonClickAddProd(this, e);
        }

        private void buttonDeleteProd_Click(object sender, EventArgs e)
        {
            if (this.ButtonClickDelProd != null)
                this.ButtonClickDelProd(this, e);
        }

        private void buttonEditProd_Click(object sender, EventArgs e)
        {
            if (this.ButtonClickEditProd != null)
                this.ButtonClickEditProd(this, e);
        }
    }
}
