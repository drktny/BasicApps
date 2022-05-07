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
            if (guna2Panel1.BackColor == Color.Transparent)
            {
                label23.Text = "1";
                label24.Text = "In the UK, the abbreviation NHS stands for National what Service?";
                aOption.Text = "A) Humanity";
                bOption.Text = "B) Health";
                cOption.Text = "C) Honour";
                dOption.Text = "D) Household";
            }


            if (label23.Text == "1")
            {
                panel1.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "2")
            {
                panel1.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "3")
            {
                panel1.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "4")
            {
                panel1.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "5")
            {
                panel1.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "6")
            {
                panel1.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "7")
            {
                panel1.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "8")
            {
                panel1.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "9")
            {
                panel1.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "10")
            {
                panel1.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "11")
            {
                panel1.BackColor = Color.DarkOrange;
            }
            if (label23.Text == "12")
            {
                panel1.BackColor = Color.DarkOrange;
            }
        }
    }
}
