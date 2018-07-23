using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dice_Roll_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "DICE ROLLER";
            this.button1.Text="START";
            this.button2.Text = "ABOUT";
            this.button3.Text = "EXIT";

            this.CancelButton = this.button3;
            this.AcceptButton = this.button1;

            this.MaximizeBox = false;

            this.BackColor = Color.LightPink;
            this.button1.BackColor = Color.DeepPink;
            this.button2.BackColor = Color.DeepPink;
            this.button3.BackColor = Color.DeepPink;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Develpor:  MISHAL-E-EMAN"+Environment.NewLine+"                   Student of BSCS-3A");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
