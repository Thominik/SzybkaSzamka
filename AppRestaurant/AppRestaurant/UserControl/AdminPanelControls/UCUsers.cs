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
    public partial class UCUsers : UserControl
    {
        public event EventHandler ButtonClickAdd;
        public event EventHandler ButtonClickDel;
        public event EventHandler ButtonClickEdit;

        public UCUsers()
        {
            InitializeComponent();
            
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (this.ButtonClickAdd != null)
                this.ButtonClickAdd(this, e);
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (this.ButtonClickDel != null)
                this.ButtonClickDel(this, e);
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            if (this.ButtonClickEdit != null)
                this.ButtonClickEdit(this, e);
        }
    }
}
