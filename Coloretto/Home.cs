﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coloretto
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btJouer_Click(object sender, EventArgs e)
        {
            Parametres_nom form = new Parametres_nom();
            this.Hide();
            form.Show();

            
        }

        private void btRegles_Click(object sender, EventArgs e)
        {
            Regles form = new Regles();
            this.Hide();
            form.Show();
        }
    }
}
