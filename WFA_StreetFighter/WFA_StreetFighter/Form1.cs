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

        private void cmbUserCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Everytime changing user character index results in changing opponent id!
            if (cmbUserCharacter.SelectedItem != null)
            {
                User user = (User)cmbUserCharacter.SelectedItem;

                lblUserName.Text = user.Name;
                lblUserAttack.Text = user.AttackPower.ToString();
                lblUserDefence.Text = user.DefencePower.ToString();
                lblUserHP.Text = user.HP.ToString();
                lblUserEnergy.Text = user.Energy.ToString();

                CPU cpu = new CPU();
                Random rdm = new Random();

                cpu.Id = rdm.Next(1, 8);

                switch (cpu.Id)
                {
                    case 1:
                        cpu = new CPU { Id = 1, Name = "Ryu", AttackPower = 55, DefencePower = 60, Energy = 0, HP = 220 };
                        break;
                    case 2:
                        cpu = new CPU { Id = 2, Name = "Chun-Li", AttackPower = 43, DefencePower = 53, Energy = 0, HP = 180 };
                        break;
                    case 3:
                        cpu = new CPU { Id = 3, Name = "Ken", AttackPower = 52, DefencePower = 70, Energy = 0, HP = 215 };
                        break;
                    case 4:
                        cpu = new CPU { Id = 4, Name = "Akuma", AttackPower = 51, DefencePower = 60, Energy = 0, HP = 200 };
                        break;
                    case 5:
                        cpu = new CPU { Id = 5, Name = "Guile", AttackPower = 49, DefencePower = 70, Energy = 0, HP = 210 };
                        break;
                    case 6:
                        cpu = new CPU { Id = 6, Name = "Balrog", AttackPower = 50, DefencePower = 60, Energy = 0, HP = 210 };
                        break;
                    case 7:
                        cpu = new CPU { Id = 7, Name = "Sagat", AttackPower = 51, DefencePower = 65, Energy = 0, HP = 215 };
                        break;

                }

                lblCPUName.Text = cpu.Name;
                lblCPUAttack.Text = cpu.AttackPower.ToString();
                lblCPUDefence.Text = cpu.DefencePower.ToString();
                lblCPUHp.Text = cpu.HP.ToString();
                lblCPUEnergy.Text = cpu.Energy.ToString();
                btnFight.Visible = true;
                lblCPUCharacter.Tag = cpu; //boxing

            }
        }

        private void btnFight_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            User user = cmbUserCharacter.SelectedItem as User;
            CPU cpu = lblCPUCharacter.Tag as CPU; //unboxing

            lblCPUCharacter.Text = lblCPUCharacter.Name;

            double userDamage = 0;
            double cpuDamage = 0;

            Random rdm = new Random();
            int turn = rdm.Next(1, 3);

            if (turn == 1)
            {
                user.Energy++;
                if (cpu.Energy >= 1)
                {
                    cpu.Energy--;
                }
                lblUserEnergy.Text = user.Energy.ToString();
            }
            else
            {
                cpu.Energy++;
                if (user.Energy >= 1)
                {
                    user.Energy--;
                }
                lblCPUEnergy.Text = cpu.Energy.ToString();

            }

            UserGroupBox.BackColor = Color.White;
            CPUGroupBox.BackColor = Color.White;

            if (turn == 1)
            {
                UserGroupBox.BackColor = Color.Red;
                int choice = rdm.Next(1, 3);
                if (user.Energy == 3)
                {
                    cpu.HP = Convert.ToInt32(cpu.Defend(user.SpecialAttack(user.Energy)));
                    lblCPUHp.Text = cpu.HP.ToString();
                    user.Energy = 0;
                }

                else if (choice == 2)
                {
                    int value = rdm.Next(1, 5);
                    userDamage = user.Punching(value);
                    lblUResult.Text = $"A left hook and {userDamage} damage dealt.";
                    cpu.HP = Convert.ToInt32(cpu.Defend(userDamage));
                    lblCPUHp.Text = cpu.HP.ToString();
                }
                else if (choice == 1)
                {
                    int value = rdm.Next(1, 5);
                    userDamage = user.Kicking(value);
                    lblUResult.Text = $"A spin kick and {userDamage} damage dealt.";
                    cpu.HP = Convert.ToInt32(cpu.Defend(userDamage));
                    lblCPUHp.Text = cpu.HP.ToString();
                }

            }
            else
            {
                CPUGroupBox.BackColor = Color.Red;

                int choice = rdm.Next(1, 3);
                if (cpu.Energy == 3)
                {
                    user.HP = Convert.ToInt32(user.Defend(cpu.SpecialAttack(cpu.Energy)));
                    lblUserHP.Text = user.HP.ToString();
                    cpu.Energy = 0;
                }
                else if (choice == 2)
                {
                    int value = rdm.Next(1, 5);
                    cpuDamage = cpu.Punching(value);
                    lblCPUResult.Text = $"A right hook and {cpuDamage} damage dealt.";
                    user.HP = Convert.ToInt32(user.Defend(cpuDamage));
                    lblUserHP.Text = user.HP.ToString();
                }
                else if (choice == 1)
                {
                    int value = rdm.Next(1, 5);
                    cpuDamage = cpu.Kicking(value);
                    lblCPUResult.Text = $"A spin kick and {cpuDamage} damage dealt.";
                    user.HP = Convert.ToInt32(user.Defend(cpuDamage));
                    lblUserHP.Text = user.HP.ToString();
                }
            }

            if (user.HP <= 0)
            {
                timer1.Stop();
                MessageBox.Show("You were defeated");

            }
            else if (cpu.HP <= 0)
            {
                timer1.Stop();
                MessageBox.Show("You WON");

            }
        }
    }
}
