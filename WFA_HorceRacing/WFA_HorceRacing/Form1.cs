using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_HorceRacing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //First we derived rdm from Random Class.
        //When start screen loaded, start button will be deactivated.
        Random rdm = new Random();
        int randomColor;
        Color background;
        private void Form1_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            randomColor = rdm.Next(1, 5);

            if(randomColor == 1)
            {
                background = Color.Blue;
            }
            else if(randomColor == 2)
            {
                background = Color.Green;
            }
            else if(randomColor == 3)
            {
                background = Color.Gray;
            }

            txtOddRatio1.Text = ((Double)rdm.Next(1, 4) + rdm.NextDouble()).ToString("N2");
            txtOddRatio2.Text = ((Double)rdm.Next(1, 4) + rdm.NextDouble()).ToString("N2");
            txtOddRatio3.Text = ((Double)rdm.Next(1, 4) + rdm.NextDouble()).ToString("N2");
        }

        double earnedMoney1;
        double earnedMoney2;
        double earnedMoney3;
        string message = "Please enter a valid odd ratio..";

        private void btnBet1_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            try
            {
                earnedMoney1 = double.Parse(txtOddRatio1.Text) * (Convert.ToDouble(nmr1.Value));
                earnedMoney2 = double.Parse(txtOddRatio2.Text) * (Convert.ToDouble(nmr2.Value));
                earnedMoney3 = double.Parse(txtOddRatio3.Text) * (Convert.ToDouble(nmr3.Value));

            }
            catch (Exception)
            {

                MessageBox.Show(message);
            }
        }

        private void btnBet2_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            try
            {
                earnedMoney1 = double.Parse(txtOddRatio1.Text) * (Convert.ToDouble(nmr1.Value));
                earnedMoney2 = double.Parse(txtOddRatio2.Text) * (Convert.ToDouble(nmr2.Value));
                earnedMoney3 = double.Parse(txtOddRatio3.Text) * (Convert.ToDouble(nmr3.Value));
            }
            catch (Exception)
            {

                MessageBox.Show(message);
            }
        }

        private void btnBet3_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            try
            {
                earnedMoney1 = double.Parse(txtOddRatio1.Text) * (Convert.ToDouble(nmr1.Value));
                earnedMoney2 = double.Parse(txtOddRatio2.Text) * (Convert.ToDouble(nmr2.Value));
                earnedMoney3 = double.Parse(txtOddRatio3.Text) * (Convert.ToDouble(nmr3.Value));
            }
            catch (Exception)
            {

                MessageBox.Show(message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (randomColor == 1)
            {
                this.BackColor = Color.Blue;
                pbHorse1.Left += rdm.Next(30, 40);
                pbHorse2.Left += rdm.Next(10, 30);
                pbHorse3.Left += rdm.Next(10, 30);
            }
            else if (randomColor == 2)
            {
                this.BackColor = Color.Green;
                pbHorse1.Left += rdm.Next(10, 30);
                pbHorse2.Left += rdm.Next(30, 40);
                pbHorse3.Left += rdm.Next(10, 30);
            }
            else if (randomColor == 3)
            {
                this.BackColor = Color.Gray;
                pbHorse1.Left += rdm.Next(10, 30);
                pbHorse2.Left += rdm.Next(10, 30);
                pbHorse3.Left += rdm.Next(30, 40);
            }


            if (pbHorse1.Right > pbHorse2.Right && pbHorse1.Right > pbHorse3.Right)
            {
                lblCommentator.Text = "1st Horse is leading";
            }
            else if (pbHorse2.Right > pbHorse1.Right && pbHorse2.Right > pbHorse3.Right)
            {
                lblCommentator.Text = "2nd Horse is leading";
            }
            else if (pbHorse3.Right > pbHorse1.Right && pbHorse3.Right > pbHorse2.Right)
            {
                lblCommentator.Text = "3rd Horse is leading";
            }

            if (randomColor == 1)
            {
                this.BackColor = Color.Blue;
                pbHorse1.Left += rdm.Next(30, 40);
                pbHorse2.Left += rdm.Next(10, 30);
                pbHorse3.Left += rdm.Next(10, 30);
            }
            else if (randomColor == 2)
            {
                this.BackColor = Color.Green;
                pbHorse1.Left += rdm.Next(10, 30);
                pbHorse2.Left += rdm.Next(30, 40);
                pbHorse3.Left += rdm.Next(10, 30);
            }
            else if (randomColor == 3)
            {
                this.BackColor = Color.Gray;
                pbHorse1.Left += rdm.Next(10, 30);
                pbHorse2.Left += rdm.Next(10, 30);
                pbHorse3.Left += rdm.Next(30, 40);
            }

            if (pbHorse1.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult result = MessageBox.Show("First Horse Win! \nEarned money: " + earnedMoney1.ToString() + " TL \nWould you like to play again? ", "Game is Ended", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    pbHorse1.Left = 5;
                    pbHorse2.Left = 5;
                    pbHorse3.Left = 5;
                    randomColor = rdm.Next(1, 4);

                    txtOddRatio1.Text = ((Double)rdm.Next(1, 4) + rdm.NextDouble()).ToString("N2");
                    txtOddRatio2.Text = ((Double)rdm.Next(1, 4) + rdm.NextDouble()).ToString("N2");
                    txtOddRatio3.Text = ((Double)rdm.Next(1, 4) + rdm.NextDouble()).ToString("N2");
                }
                else
                {
                    Application.Exit();
                }


            }
            else if (pbHorse2.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult result = MessageBox.Show("Second Horse Win! \nEarned money: " + earnedMoney2.ToString() + " TL \nWould you like to play again? ", "Game is Ended", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    pbHorse1.Left = 5;
                    pbHorse2.Left = 5;
                    pbHorse3.Left = 5;
                    randomColor = rdm.Next(1, 4);

                    txtOddRatio1.Text = ((Double)rdm.Next(1, 4) + rdm.NextDouble()).ToString("N2");
                    txtOddRatio2.Text = ((Double)rdm.Next(1, 4) + rdm.NextDouble()).ToString("N2");
                    txtOddRatio3.Text = ((Double)rdm.Next(1, 4) + rdm.NextDouble()).ToString("N2");
                }
                else
                {
                    Application.Exit();
                }


            }
            else if (pbHorse3.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult result = MessageBox.Show("Third Horse Win! \nEarned money: " + earnedMoney3.ToString() + " TL \nWould you like to play again? ", "Game is Ended", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    pbHorse1.Left = 5;
                    pbHorse2.Left = 5;
                    pbHorse3.Left = 5;
                    randomColor = rdm.Next(1, 4);

                    txtOddRatio1.Text = ((Double)rdm.Next(1, 4) + rdm.NextDouble()).ToString("N2");
                    txtOddRatio2.Text = ((Double)rdm.Next(1, 4) + rdm.NextDouble()).ToString("N2");
                    txtOddRatio3.Text = ((Double)rdm.Next(1, 4) + rdm.NextDouble()).ToString("N2");
                }
                else
                {
                    Application.Exit();

                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
