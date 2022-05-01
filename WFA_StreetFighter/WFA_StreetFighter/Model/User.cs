using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_StreetFighter.Model
{
    public class User : Character
    {
        public override double Defend(double comingAttack)
        {
            double damage = 0;

            switch (DefencePower)
            {
                case 55:
                    damage = (comingAttack * DefencePower) * 0.02;
                    break;
                case 60:
                    damage = (comingAttack * DefencePower) * 0.016;
                    break;
                case 65:
                    damage = (comingAttack * DefencePower) * 0.012;
                    break;
                case 70:
                    damage = (comingAttack * DefencePower) * 0.008;
                    break;
            }

            damage = Math.Floor(damage);
            damage = HP - Convert.ToInt32(damage);
            return damage;
        }

        public override double Kicking(int value)
        {
            double attack = (AttackPower * value) * 0.1;
            attack = Math.Floor(attack);
            return attack;
        }

        public override double Punching(int value)
        {
            double attack = (AttackPower * value) * 0.1;
            attack = Math.Floor(attack);
            return attack;
        }

        public override double SpecialAttack(int energy)
        {
            double attack = 0;

            Random rdm = new Random();
            int value = rdm.Next(5, 10);

            attack = (AttackPower * value) * 0.1;
            attack = Math.Floor(attack);

            return attack;
        }
    }
}
