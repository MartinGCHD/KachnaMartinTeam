﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zakladkachny
{
    public partial class Form1 : Form
    {

        Button prvni;

        int pocetTicku = 0;

        public Form1()
        {
            InitializeComponent();
            prvni = new Button();
            prvni.Text = "Kachna";
            prvni.Left = 100;
            prvni.Top = 10;
            prvni.Click += this.Clicked;
            this.Controls.Add(prvni);
        }

        public void Clicked(object sender, EventArgs args)
        {
            prvni.Text = "Kliknuto";
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            prvni.Text = "Tick " + pocetTicku++;
        }
    }
}
