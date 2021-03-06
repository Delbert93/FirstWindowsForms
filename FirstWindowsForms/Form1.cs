﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Am I alive?", "Singularity", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dialogResult = MessageBox.Show("It begins!" , "Run", MessageBoxButtons.OK);
                if(dialogResult == DialogResult.OK)
                {
                    timer1.Start();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                dialogResult = MessageBox.Show("Oh ok, i'll just go back to work.", "phew", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {
                    return;
                }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.025;
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }
    }
}
