﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Focus();
            button1.Text = "";
        }
    }
}
