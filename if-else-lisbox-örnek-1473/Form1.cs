﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else_lisbox_örnek_1473
{
    public partial class txtSayi : Form
    {
        public txtSayi()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int sayı = Convert.ToInt32(txtSayı.Text);

             if(sayı%2 == 0)
             {
                lbCıft.Items.Add(txtSayı.Text);
            }
            else
            {
                lbTek.Items.Add(txtSayı.Text);
            }
        }
    }
}
