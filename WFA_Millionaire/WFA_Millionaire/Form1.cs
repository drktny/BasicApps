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
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.Transparent)
            {
                label23.Text = "1";
                label24.Text = "In the UK, the abbreviation NHS stands for National what Service?";
                aOption.Text = "A) Humanity";
                bOption.Text = "B) Health";
                cOption.Text = "C) Honour";
                dOption.Text = "D) Household";
            }
            if (panel1.BackColor == Color.DarkOrange)
            {
                label23.Text = "2";
                label24.Text = "Which Disney character famously leaves a glass slipper behind at a royal ball?";
                aOption.Text = "A) Pocahontas";
                bOption.Text = "B) Sleeping Beauty";
                cOption.Text = "C) Cinderella";
                dOption.Text = "D) Elsa";
                bOption.FillColor = Color.DarkSlateGray;
            }
            if (panel2.BackColor == Color.DarkOrange)
            {
                label23.Text = "3";
                label24.Text = "What name is given to the revolving belt machinery in an airport that delivers checked luggage from the plane to baggage reclaim?";
                aOption.Text = "A) Hangar";
                bOption.Text = "B) Terminal";
                cOption.Text = "C) Concourse";
                dOption.Text = "D) Carousel";
                cOption.FillColor = Color.DarkSlateGray;
            }
            if (panel3.BackColor == Color.DarkOrange)
            {
                label23.Text = "4";
                label24.Text = "Which of these brands was chiefly associated with the manufacture of household locks?";
                aOption.Text = "A) Phillips";
                bOption.Text = "B) Flymo";
                cOption.Text = "C) Chubb";
                dOption.Text = "D) Ronseal";
                dOption.FillColor = Color.DarkSlateGray;
            }
            if (panel4.BackColor == Color.DarkOrange)
            {
                label23.Text = "5";
                label24.Text = "The hammer and sickle is one of the most recognisable symbols of which political ideology?";
                aOption.Text = "A) Republicanism";
                bOption.Text = "B) Communism";
                cOption.Text = "C) Conservatism";
                dOption.Text = "D) Liberalism";
                cOption.FillColor = Color.DarkSlateGray;
            }
            if (panel5.BackColor == Color.DarkOrange)
            {
                label23.Text = "6";
                label24.Text = "Which toys have been marketed with the phrase “robots in disguise”?";
                aOption.Text = "A) Bratz Dolls";
                bOption.Text = "B) Sylvanian Families";
                cOption.Text = "C) Hatchimals";
                dOption.Text = "D) Transformers";
                bOption.FillColor = Color.DarkSlateGray;
            }
            if (panel6.BackColor == Color.DarkOrange)
            {
                label23.Text = "7";
                label24.Text = "What does the word loquacious mean?";
                aOption.Text = "A) Angry";
                bOption.Text = "B) Chatty";
                cOption.Text = "C) Beautiful";
                dOption.Text = "D) Shy";
                dOption.FillColor = Color.DarkSlateGray;
            }
            if (panel7.BackColor == Color.DarkOrange)
            {
                label23.Text = "8";
                label24.Text = "Obstetrics is a branch of medicine particularly concerned with what?";
                aOption.Text = "A) Childbirth";
                bOption.Text = "B) Broken bones";
                cOption.Text = "C) Heart conditions";
                dOption.Text = "D) Old age";
                bOption.FillColor = Color.DarkSlateGray;
            }
            if (panel8.BackColor == Color.DarkOrange)
            {
                label23.Text = "9";
                label24.Text = "In Doctor Who, what was the signature look of the fourth Doctor, as portrayed by Tom Baker?";
                aOption.Text = "A) Bow-tie, braces and tweed jacket";
                bOption.Text = "B) Wide-brimmed hat and extra long scarf";
                cOption.Text = "C) Pinstripe suit and trainers";
                dOption.Text = "D) Cape, velvet jacket and frilly shirt";
                aOption.FillColor = Color.DarkSlateGray;
            }
            if (panel9.BackColor == Color.DarkOrange)
            {
                label23.Text = "10";
                label24.Text = "Which of these religious observances lasts for the shortest period of time during the calendar year?";
                aOption.Text = "A) Ramadan";
                bOption.Text = "B) Diwali";
                cOption.Text = "C) Lent";
                dOption.Text = "D) Hanukkah";
                bOption.FillColor = Color.DarkSlateGray;
            }
            if (panel10.BackColor == Color.DarkOrange)
            {
                label23.Text = "11";
                label24.Text = "At the closest point, which island group is only 50 miles south-east of the coast of Florida?";
                aOption.Text = "A) Bahamas";
                bOption.Text = "B) US Virgin Islands";
                cOption.Text = "C) Turks and Caicos Islands";
                dOption.Text = "D) Bermuda";
                bOption.FillColor = Color.DarkSlateGray;
            }
            if (panel11.BackColor == Color.DarkOrange)
            {
                label23.Text = "12";
                label24.Text = "Construction of which of these famous landmarks was completed first?";
                aOption.Text = "A) Empire State Building";
                bOption.Text = "B) Royal Albert Hall";
                cOption.Text = "C) Eiffel Tower";
                dOption.Text = "D) Big Ben Clock Tower";
                aOption.FillColor = Color.DarkSlateGray;
            }


            if (label23.Text == "1")
            {
                panel1.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "2")
            {
                panel1.BackColor = Color.DarkGreen;
                panel2.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "3")
            {
                panel2.BackColor = Color.DarkGreen;
                panel3.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "4")
            {
                panel3.BackColor = Color.DarkGreen;
                panel4.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "5")
            {
                panel4.BackColor = Color.DarkGreen;
                panel5.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "6")
            {
                panel5.BackColor = Color.DarkGreen;
                panel6.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "7")
            {
                panel6.BackColor = Color.DarkGreen;
                panel7.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "8")
            {
                panel7.BackColor = Color.DarkGreen;
                panel8.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "9")
            {
                panel8.BackColor = Color.DarkGreen;
                panel9.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "10")
            {
                panel9.BackColor = Color.DarkGreen;
                panel10.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "11")
            {
                panel10.BackColor = Color.DarkGreen;
                panel11.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "12")
            {
                panel11.BackColor = Color.DarkGreen;
                panel12.BackColor = Color.DarkOrange;
            }
        }

        private void bOption_Click(object sender, EventArgs e)
        {
            if(label23.Text == "1" || label23.Text == "5" || label23.Text == "7" || label23.Text == "9" || label23.Text == "10")
            {
                bOption.FillColor = Color.DarkGreen;
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
            }
            else
            {
                dOption.FillColor = Color.DarkRed;
                MessageBox.Show("Wrong answer! You lost!");
                Application.Exit();
            }
        }
    }
}
