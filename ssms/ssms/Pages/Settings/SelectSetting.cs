﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ssms.Pages.Settings
{
    public partial class SelectSetting : UserControl
    {
        public SelectSetting()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ((Main)this.Parent.Parent).ChangeView<Settings>();
        }
    }
}
