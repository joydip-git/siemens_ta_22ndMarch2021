﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // public delegate void EventHandler(object sender, EventArgs e);
            //EventHandler eventHandler = new EventHandler(this.ButtonClicked);
            //this.button1.Click += eventHandler;//eventHandler(this.button1,);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi....");
        }
        //private void ButtonClicked(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Hi....");
        //}
    }
}
