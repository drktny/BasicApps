using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_StreetFighter.Model;

namespace WFA_StreetFighter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void CreateCharacters()
        {
            List<User> userList = new List<User>()
            {
                new User {Id = 1, Name = "Ryu", AttackPower = 55, DefencePower = 60, Energy = 0, HP = 220  },
                new User {Id = 2, Name = "Chun-Li", AttackPower = 43, DefencePower = 53, Energy = 0, HP = 180 },
                new User {Id = 3, Name = "Ken", AttackPower = 52, DefencePower = 70, Energy = 0, HP = 215},
                new User {Id = 4, Name = "Akuma", AttackPower = 51, DefencePower = 60, Energy = 0, HP = 200},
                new User {Id = 5, Name = "Guile", AttackPower = 49, DefencePower = 70, Energy = 0, HP = 210},
                new User {Id = 6, Name = "Balrog", AttackPower = 50, DefencePower = 60, Energy = 0, HP = 210},
                new User {Id = 7, Name = "Sagat", AttackPower = 51, DefencePower = 65, Energy = 0, HP = 215}
            };

            cmbUserCharacter.DataSource = userList;
            cmbUserCharacter.DisplayMember = "Name";
            cmbUserCharacter.ValueMember = "Id";
            cmbUserCharacter.SelectedIndex = -1; //Nothing should be selected when the game started.

            btnFight.Visible = false;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateCharacters();
        }
    }
}
