﻿using System;
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
    public partial class FormLoginBAD : Form
    {
        public FormLoginBAD()
        {
            InitializeComponent();
        }

        private void buttonTryAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
