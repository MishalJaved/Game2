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
    public partial class Form2 : Form
    {
        bool check = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button4();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button5();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button6();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.button5.Visible = false;
            this.button6.Visible = false;
            this.button8.Visible = false;
            this.button9.Visible = false;

            this.button1.Text = "";
            this.button2.Text = "";
            this.button3.Text = "";
            this.button4.Text = "Roll it!";
            this.button5.Text = "Roll it!";
            this.button6.Text = "Roll it!";
            this.button7.Text = "Check!";
            this.button8.Text = "Check!";
            this.button9.Text = "Check!";
           
            this.button11.Text = "MAIN";
            this.button12.Text = "EXIT";

            this.label1.Text = "1st TURN:";
            this.label2.Text = "2nd TURN:";
            this.label3.Text = "3rd TURN:";
            this.label5.Text = "";
            this.label6.Text = "";
            this.label7.Text = "";
            this.label4.Text = "";

            this.BackColor = Color.LightPink;
            this.button1.BackColor = Color.DeepPink;
            this.button2.BackColor = Color.DeepPink;
            this.button3.BackColor = Color.DeepPink;
            this.button4.BackColor = Color.DeepPink;
            this.button5.BackColor = Color.DeepPink;
            this.button6.BackColor = Color.DeepPink;
            this.button7.BackColor = Color.DeepPink;
            this.button8.BackColor = Color.DeepPink;
            this.button9.BackColor = Color.DeepPink;
            this.button11.BackColor = Color.DeepPink;
            this.button12.BackColor = Color.DeepPink;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.button1.Text == this.button2.Text && this.button1.Text == this.button3.Text)
            {
               this.label4.Text = "YOU WIN";
                this.label5.Text = "1";
                
             
            }
            else
            {
                this.button4.Enabled = true;
                this.button5.Enabled = true;
                this.button6.Enabled = true;

               //this.button4.Visible = true;
               //this.button5.Visible = true;
               //this.button6.Visible = true;

                this.button1.Text = "";
                this.button2.Text = "";
                this.button3.Text = "";
                this.button7.Visible = false;
                this.button8.Visible = true;

                this.label5.Text = "0";
            }





            /*int i;
            for (i = 1; i <= 3; i++)
            {
                if (this.button1.Text == this.button2.Text && this.button1.Text == this.button3.Text)
                {
                    check = true;
                }
            }
            if (check == true)
            {
                MessageBox.Show("YOU WIN!");
            }
            else 
            {
                MessageBox.Show("YOU LOOSE!");
            }*/

        }
        //Methods for buttons..............................................
        private void Button4()
        {
            this.button4.Visible = true;
            Random r = new Random();

            int rno;
            rno = r.Next(1, 7);

            if (rno == 1)
            {
                this.button1.Text = Convert.ToString(rno);
            }
            if (rno == 2)
            {
                this.button1.Text = Convert.ToString(rno);
            }
            if (rno == 3)
            {
                this.button1.Text = Convert.ToString(rno);
            }
            if (rno == 4)
            {
                this.button1.Text = Convert.ToString(rno);
            }
            if (rno == 5)
            {
                this.button1.Text = Convert.ToString(rno);
            }
            if (rno == 6)
            {
                this.button1.Text = Convert.ToString(rno);
            }
           
            this.button5.Visible = true;
            this.button4.Enabled = false;
        }

        private void Button5()
        {
            Random r = new Random();

            int rno;
            rno = r.Next(1, 7);

            if (rno == 1)
            {
                this.button2.Text = Convert.ToString(rno);
            }
            if (rno == 2)
            {
                this.button2.Text = Convert.ToString(rno);
            }
            if (rno == 3)
            {
                this.button2.Text = Convert.ToString(rno);
            }
            if (rno == 4)
            {
                this.button2.Text = Convert.ToString(rno);
            }
            if (rno == 5)
            {
                this.button2.Text = Convert.ToString(rno);
            }
            if (rno == 6)
            {
                this.button2.Text = Convert.ToString(rno);
            }

            this.button6.Visible = true;
            this.button5.Enabled = false;

        }

        private void Button6()
        {
            Random r = new Random();

            int rno;
            rno = r.Next(1, 7);


            if (rno == 1)
            {
                this.button3.Text = Convert.ToString(rno);
            }
            if (rno == 2)
            {
                this.button3.Text = Convert.ToString(rno);
            }
            if (rno == 3)
            {
                this.button3.Text = Convert.ToString(rno);
            }
            if (rno == 4)
            {
                this.button3.Text = Convert.ToString(rno);
            }
            if (rno == 5)
            {
                this.button3.Text = Convert.ToString(rno);
            }
            if (rno == 6)
            {
                this.button3.Text = Convert.ToString(rno);
            }
            this.button6.Enabled = false;

        }  //End of Methods for Buttons..........................................

        private void button8_Click(object sender, EventArgs e)
        {
            /*int j;
            for (j = 1; j <= 3; j++)
            {
                Button4();
                Button5();
                Button6();
            } */
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            

            if (this.button1.Text == this.button2.Text && this.button1.Text == this.button3.Text)
            {
                this.label4.Text = "YOU WIN"; 
                this.label6.Text = "1";
            }
            else
            {
                this.button4.Enabled = true;
                this.button5.Enabled = true;
                this.button6.Enabled = true;

                //this.button4.Visible = true;
                //this.button5.Visible = true;
                //this.button6.Visible = true;

                this.button1.Text = "";
                this.button2.Text = "";
                this.button3.Text = "";
             
                this.button8.Visible = false;
                this.button9.Visible = true;

                this.label6.Text = "0";
            
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (this.button1.Text == this.button2.Text && this.button1.Text == this.button3.Text)
            {
                this.label7.Text = "1";
                this.label4.Text = "YOU WIN";
           }
            else
            {
                this.label7.Text = "0";
                this.label4.Text = "GAME OVER!";
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
      
    }
}