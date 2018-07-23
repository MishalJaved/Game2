using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Puzzle_try
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.a1;
            button2.Image = Properties.Resources.a2;
            button3.Image = Properties.Resources.a3;
            button4.Image = Properties.Resources.a4;
            button5.Image = Properties.Resources.a5;
            button6.Image = Properties.Resources.a6;
            button7.Image = Properties.Resources.a7;
            button8.Image = Properties.Resources.a8;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button2.Image == null)
            {
                this.button2.Image = this.button1.Image;
                this.button1.Image = null;
            }
            if (this.button4.Image == null)
            {
                this.button4.Image = this.button1.Image;
                this.button1.Image = null;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.button1.Image == null)
            {
                this.button1.Image = this.button2.Image;
                this.button2.Image = null;
            }
            if (this.button3.Image == null)
            {
                this.button3.Image = this.button2.Image;
                this.button2.Image = null;
            }
            if (this.button5.Image == null)
            {
                this.button5.Image = this.button2.Image;
                this.button2.Image = null;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (this.button2.Image == null)
            {
                this.button2.Image = this.button3.Image;
                this.button3.Image = null;
            }
            if (this.button6.Image == null)
            {
                this.button6.Image = this.button3.Image;
                this.button3.Image = null;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.button1.Image == null)
            {
                this.button1.Image = this.button4.Image;
                this.button4.Image = null;
            }
            if (this.button5.Image == null)
            {
                this.button5.Image = this.button4.Image;
                this.button4.Image = null;
            }

            if (this.button7.Image == null)
            {
                this.button7.Image = this.button4.Image;
                this.button4.Image = null;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.button2.Image == null)
            {
                this.button2.Image = this.button5.Image;
                this.button5.Image = null;
            }

            if (this.button4.Image == null)
            {
                this.button4.Image = this.button5.Image;
                this.button5.Image = null;
            }

            if (this.button6.Image == null)
            {
                this.button6.Image = this.button5.Image;
                this.button5.Image = null;
            }

            if (this.button8.Image == null)
            {
                this.button8.Image = this.button5.Image;
                this.button5.Image = null;
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.button5.Image == null)
            {
                this.button5.Image = this.button6.Image;
                this.button6.Image = null;
            }

            if (this.button3.Image == null)
            {
                this.button3.Image = this.button6.Image;
                this.button6.Image = null;
            }

            if (this.button9.Image == null)
            {
                this.button9.Image = this.button6.Image;
                this.button6.Image = null;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.button4.Image == null)
            {
                this.button4.Image = this.button7.Image;
                this.button7.Image = null;
            }

            if (this.button8.Image == null)
            {
                this.button8.Image = this.button7.Image;
                this.button7.Image = null;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.button5.Image == null)
            {
                this.button5.Image = this.button8.Image;
                this.button8.Image = null;
            }

            if (this.button7.Image == null)
            {
                this.button7.Image = this.button8.Image;
                this.button8.Image = null;
            }

            if (this.button9.Text == null)
            {
                this.button9.Text = this.button8.Text;
                this.button8.Text = null;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.button6.Text == null)
            {
                this.button6.Text = this.button9.Text;
                this.button9.Text = null;
            }
            if (this.button8.Text == null)
            {
                this.button8.Text = this.button9.Text;
                this.button9.Text = null;
            }

        }
    }
}
