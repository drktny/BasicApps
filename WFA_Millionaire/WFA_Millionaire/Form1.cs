using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Millionaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2Button2.Enabled = false;
            guna2Button3.Enabled = false;
            guna2Button4.Enabled = false;
            guna2Button5.Enabled = false;

            if (panel1.BackColor == Color.Transparent)
            {
                panel1.BackColor = Color.DarkOrange;
                label23.Text = "1";
                label24.Text = "In the UK, the abbreviation NHS stands for National what Service?";
                aOption.Text = "A) Humanity";
                bOption.Text = "B) Health";
                cOption.Text = "C) Honour";
                dOption.Text = "D) Household";
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;
            label34.Text = "0%";
            label35.Text = "0%";
            label36.Text = "0%";
            label37.Text = "0%";

            aOption.Visible = true;
            bOption.Visible = true;
            cOption.Visible = true;
            dOption.Visible = true;

            
            


            if (panel1.BackColor == Color.DarkGreen)
            {
                label23.Text = "2";
                label24.Text = "Which Disney character famously leaves a glass slipper behind at a royal ball?";
                aOption.Text = "A) Pocahontas";
                bOption.Text = "B) Sleeping Beauty";
                cOption.Text = "C) Cinderella";
                dOption.Text = "D) Elsa";
                bOption.FillColor = Color.DarkSlateGray;
            }
            if (panel2.BackColor == Color.DarkGreen)
            {
                label23.Text = "3";
                label24.Text = "What name is given to the revolving belt machinery in an airport that delivers checked luggage from the plane to baggage reclaim?";
                aOption.Text = "A) Hangar";
                bOption.Text = "B) Terminal";
                cOption.Text = "C) Concourse";
                dOption.Text = "D) Carousel";
                cOption.FillColor = Color.DarkSlateGray;
            }
            if (panel3.BackColor == Color.DarkGreen)
            {
                label23.Text = "4";
                label24.Text = "Which of these brands was chiefly associated with the manufacture of household locks?";
                aOption.Text = "A) Phillips";
                bOption.Text = "B) Flymo";
                cOption.Text = "C) Chubb";
                dOption.Text = "D) Ronseal";
                dOption.FillColor = Color.DarkSlateGray;
            }
            if (panel4.BackColor == Color.DarkGreen)
            {
                label23.Text = "5";
                label24.Text = "The hammer and sickle is one of the most recognisable symbols of which political ideology?";
                aOption.Text = "A) Republicanism";
                bOption.Text = "B) Communism";
                cOption.Text = "C) Conservatism";
                dOption.Text = "D) Liberalism";
                cOption.FillColor = Color.DarkSlateGray;
            }
            if (panel5.BackColor == Color.DarkGreen)
            {
                label23.Text = "6";
                label24.Text = "Which toys have been marketed with the phrase “robots in disguise”?";
                aOption.Text = "A) Bratz Dolls";
                bOption.Text = "B) Sylvanian Families";
                cOption.Text = "C) Hatchimals";
                dOption.Text = "D) Transformers";
                bOption.FillColor = Color.DarkSlateGray;
            }
            if (panel6.BackColor == Color.DarkGreen)
            {
                label23.Text = "7";
                label24.Text = "What does the word loquacious mean?";
                aOption.Text = "A) Angry";
                bOption.Text = "B) Chatty";
                cOption.Text = "C) Beautiful";
                dOption.Text = "D) Shy";
                dOption.FillColor = Color.DarkSlateGray;
            }
            if (panel7.BackColor == Color.DarkGreen)
            {
                label23.Text = "8";
                label24.Text = "Obstetrics is a branch of medicine particularly concerned with what?";
                aOption.Text = "A) Childbirth";
                bOption.Text = "B) Broken bones";
                cOption.Text = "C) Heart conditions";
                dOption.Text = "D) Old age";
                bOption.FillColor = Color.DarkSlateGray;
            }
            if (panel8.BackColor == Color.DarkGreen)
            {
                label23.Text = "9";
                label24.Text = "In Doctor Who, what was the signature look of the fourth Doctor, as portrayed by Tom Baker?";
                aOption.Text = "A) Bow-tie, braces and tweed jacket";
                bOption.Text = "B) Wide-brimmed hat and extra long scarf";
                cOption.Text = "C) Pinstripe suit and trainers";
                dOption.Text = "D) Cape, velvet jacket and frilly shirt";
                aOption.FillColor = Color.DarkSlateGray;
            }
            if (panel9.BackColor == Color.DarkGreen)
            {
                label23.Text = "10";
                label24.Text = "Which of these religious observances lasts for the shortest period of time during the calendar year?";
                aOption.Text = "A) Ramadan";
                bOption.Text = "B) Diwali";
                cOption.Text = "C) Lent";
                dOption.Text = "D) Hanukkah";
                bOption.FillColor = Color.DarkSlateGray;
            }
            if (panel10.BackColor == Color.DarkGreen)
            {
                label23.Text = "11";
                label24.Text = "At the closest point, which island group is only 50 miles south-east of the coast of Florida?";
                aOption.Text = "A) Bahamas";
                bOption.Text = "B) US Virgin Islands";
                cOption.Text = "C) Turks and Caicos Islands";
                dOption.Text = "D) Bermuda";
                bOption.FillColor = Color.DarkSlateGray;
            }
            if (panel11.BackColor == Color.DarkGreen)
            {
                label23.Text = "12";
                label24.Text = "Construction of which of these famous landmarks was completed first?";
                aOption.Text = "A) Empire State Building";
                bOption.Text = "B) Royal Albert Hall";
                cOption.Text = "C) Eiffel Tower";
                dOption.Text = "D) Big Ben Clock Tower";
                aOption.FillColor = Color.DarkSlateGray;
            }

            

            if (label23.Text == "2")
            {
                panel2.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "3")
            {
                panel3.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "4")
            {
                panel4.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "5")
            {
                panel5.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "6")
            {
                panel6.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "7")
            {
                panel7.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "8")
            {
                panel8.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "9")
            {
                panel9.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "10")
            {
                panel10.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "11")
            {
                panel11.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "12")
            {
                panel12.BackColor = Color.DarkOrange;
            }


        }

        private void bOption_Click(object sender, EventArgs e)
        {
            if(label23.Text == "1" || label23.Text == "5" || label23.Text == "7" || label23.Text == "9" || label23.Text == "10")
            {
                bOption.FillColor = Color.DarkGreen;
                switch (label23.Text)
                {
                    case "1":
                        panel1.BackColor = Color.DarkGreen;
                        break;
                    case "5":
                        panel5.BackColor = Color.DarkGreen;
                        break;
                    case "7":
                        panel7.BackColor = Color.DarkGreen;
                        break;
                    case "9":
                        panel9.BackColor = Color.DarkGreen;
                        break;
                    case "10":
                        panel10.BackColor = Color.DarkGreen;
                        break;
                }
            }
            else
            {
                bOption.FillColor = Color.DarkRed;
                MessageBox.Show("Wrong answer! You lost!");
                Application.Exit();
            }
        }

        private void aOption_Click(object sender, EventArgs e)
        {
            if(label23.Text == "8" || label23.Text == "11")
            {
                aOption.FillColor = Color.DarkGreen;
                switch (label23.Text)
                {
                    case "8":
                        panel8.BackColor = Color.DarkGreen;
                        break;
                    case "11":
                        panel11.BackColor = Color.DarkGreen;
                        break;
         
                }
            }
            else
            {
                aOption.FillColor = Color.DarkRed;
                MessageBox.Show("Wrong answer! You lost!");
                Application.Exit();
            }
        }

        private void cOption_Click(object sender, EventArgs e)
        {
            if(label23.Text == "2" || label23.Text == "4")
            {
                cOption.FillColor = Color.DarkGreen;
                switch (label23.Text)
                {
                    case "2":
                        panel2.BackColor = Color.DarkGreen;
                        break;
                    case "4":
                        panel4.BackColor = Color.DarkGreen;
                        break;
                    
                }
            }
            else
            {
                cOption.FillColor = Color.DarkRed;
                MessageBox.Show("Wrong answer! You lost!");
                Application.Exit();
            }
        }

        private void dOption_Click(object sender, EventArgs e)
        {
            if (label23.Text == "3" || label23.Text == "6" || label23.Text == "12")
            {
                dOption.FillColor = Color.DarkGreen;
                switch (label23.Text)
                {
                    case "3":
                        panel3.BackColor = Color.DarkGreen;
                        break;
                    case "6":
                        panel6.BackColor = Color.DarkGreen;
                        break;
                    case "12":
                        panel12.BackColor = Color.DarkGreen;
                        break;
                    
                }
            }
            else
            {
                dOption.FillColor = Color.DarkRed;
                MessageBox.Show("Wrong answer! You lost!");
                Application.Exit();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (label23.Text == "1" || label23.Text == "5" || label23.Text == "7" || label23.Text == "9" || label23.Text == "10")
            {
                MessageBox.Show("I think the answer is B");
                guna2Button2.Enabled = false;
                guna2Button3.Enabled = false;
                guna2Button4.Enabled = false;
                pictureBox1.Visible = false;
            }
            else if (label23.Text == "2" || label23.Text == "4")
            {
                MessageBox.Show("I think the answer is C");
                guna2Button2.Enabled = false;
                guna2Button3.Enabled = false;
                guna2Button4.Enabled = false;
                pictureBox1.Visible = false;
            }
            else if (label23.Text == "3" || label23.Text == "6" || label23.Text == "12")
            {
                MessageBox.Show("I think the answer is D");
                guna2Button2.Enabled = false;
                guna2Button3.Enabled = false;
                guna2Button4.Enabled = false;
                pictureBox1.Visible = false;
            }
            else if (label23.Text == "8" || label23.Text == "11")
            {
                MessageBox.Show("I think the answer is A");
                guna2Button2.Enabled = false;
                guna2Button3.Enabled = false;
                guna2Button4.Enabled = false;
                pictureBox1.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            guna2Button2.Enabled = true;
            guna2Button3.Enabled = true;
            guna2Button4.Enabled = true;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (label23.Text == "1" || label23.Text == "5" || label23.Text == "7" || label23.Text == "9" || label23.Text == "10")
            {
                MessageBox.Show("I think the answer is B");
                guna2Button2.Enabled = false;
                guna2Button3.Enabled = false;
                guna2Button4.Enabled = false;
                pictureBox1.Visible = false;
            }
            else if (label23.Text == "2" || label23.Text == "4")
            {
                MessageBox.Show("I think the answer is C");
                guna2Button2.Enabled = false;
                guna2Button3.Enabled = false;
                guna2Button4.Enabled = false;
                pictureBox1.Visible = false;
            }
            else if (label23.Text == "3" || label23.Text == "6" || label23.Text == "12")
            {
                MessageBox.Show("I think the answer is D");
                guna2Button2.Enabled = false;
                guna2Button3.Enabled = false;
                guna2Button4.Enabled = false;
                pictureBox1.Visible = false;
            }
            else if (label23.Text == "8" || label23.Text == "11")
            {
                MessageBox.Show("I think the answer is A");
                guna2Button2.Enabled = false;
                guna2Button3.Enabled = false;
                guna2Button4.Enabled = false;
                pictureBox1.Visible = false;
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (label23.Text == "1" || label23.Text == "5" || label23.Text == "7" || label23.Text == "9" || label23.Text == "10")
            {
                MessageBox.Show("I think the answer is B");
                guna2Button2.Enabled = false;
                guna2Button3.Enabled = false;
                guna2Button4.Enabled = false;
                pictureBox1.Visible = false;
            }
            else if (label23.Text == "2" || label23.Text == "4")
            {
                MessageBox.Show("I think the answer is C");
                guna2Button2.Enabled = false;
                guna2Button3.Enabled = false;
                guna2Button4.Enabled = false;
                pictureBox1.Visible = false;
            }
            else if (label23.Text == "3" || label23.Text == "6" || label23.Text == "12")
            {
                MessageBox.Show("I think the answer is D");
                guna2Button2.Enabled = false;
                guna2Button3.Enabled = false;
                guna2Button4.Enabled = false;
                pictureBox1.Visible = false;
            }
            else if (label23.Text == "8" || label23.Text == "11")
            {
                MessageBox.Show("I think the answer is A");
                guna2Button2.Enabled = false;
                guna2Button3.Enabled = false;
                guna2Button4.Enabled = false;
                pictureBox1.Visible = false;
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (label23.Text == "1" || label23.Text == "5" || label23.Text == "7" || label23.Text == "9" || label23.Text == "10")
            {
                progressBar1.Value = 24;
                progressBar2.Value = 53;
                progressBar3.Value = 13;
                progressBar4.Value = 10;
                label34.Text = "24%";
                label35.Text = "53%";
                label36.Text = "13%";
                label37.Text = "10%";
                guna2Button5.Enabled = false;
                pictureBox2.Visible = false;

            }
            else if (label23.Text == "2" || label23.Text == "4")
            {
                progressBar1.Value = 5;
                progressBar2.Value = 15;
                progressBar3.Value = 58;
                progressBar4.Value = 22;
                label34.Text = "5%";
                label35.Text = "15%";
                label36.Text = "58%";
                label37.Text = "22%";
                guna2Button5.Enabled = false;
                pictureBox2.Visible = false;

            }
            else if (label23.Text == "3" || label23.Text == "6" || label23.Text == "12")
            {
                progressBar1.Value = 23;
                progressBar2.Value = 21;
                progressBar3.Value = 15;
                progressBar4.Value = 41;
                label34.Text = "23%";
                label35.Text = "21%";
                label36.Text = "15%";
                label37.Text = "41%";
                guna2Button5.Enabled = false;
                pictureBox2.Visible = false;
            }
            else if (label23.Text == "8" || label23.Text == "11")
            {
                progressBar1.Value = 71;
                progressBar2.Value = 8;
                progressBar3.Value = 12;
                progressBar4.Value = 9;
                label34.Text = "71%";
                label35.Text = "8%";
                label36.Text = "12%";
                label37.Text = "9%";
                guna2Button5.Enabled = false;
                pictureBox2.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            guna2Button5.Enabled = true;
            pictureBox2.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (label23.Text == "1" || label23.Text == "5" || label23.Text == "7" || label23.Text == "9" || label23.Text == "10")
            {
                aOption.Visible = false;
                cOption.Visible = false;
                pictureBox3.Visible = false;

            }
            else if (label23.Text == "2" || label23.Text == "4")
            {
                aOption.Visible = false;
                dOption.Visible = false;
                pictureBox3.Visible = false;

            }
            else if (label23.Text == "3" || label23.Text == "6" || label23.Text == "12")
            {
                aOption.Visible = false;
                bOption.Visible = false;
                pictureBox3.Visible = false;
            }
            else if (label23.Text == "8" || label23.Text == "11")
            {
                cOption.Visible = false;
                dOption.Visible = false;
                pictureBox3.Visible = false;
            }
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            if(panel12.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Congratulations!! You are a millonaire now!!");
                Application.Exit();
            }
            
        }
    }
}
