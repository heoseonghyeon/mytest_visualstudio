﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World  hotfix!" );
            MessageBox.Show("i'm the master!");
            MessageBox.Show("i'm the hotfix");
            MessageBox.Show("modify at github(server)");
            MessageBox.Show("im local~");
            MessageBox.Show("pull test");
        }
    }
}
