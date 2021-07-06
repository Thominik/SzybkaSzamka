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
    public partial class UCHome : UserControl
    {
        public event EventHandler ButtonClick;
        
        public UCHome()
        {
            InitializeComponent();
        }

        public void buttonOrderNow_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
    }
}
