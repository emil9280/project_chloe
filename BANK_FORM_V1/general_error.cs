﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK_FORM_V1
{
    public partial class general_error : Form
    {
        public general_error()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Close();
        }
    }
}
