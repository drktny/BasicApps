using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_StreetFighter.Model
{
    public abstract class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HP { get; set; }
        public double AttackPower { get; set; }
        public double DefencePower { get; set; }
        public int Energy { get; set; }

        public abstract double Kicking(int value);
        public abstract double Punching(int value);
        public abstract double SpecialAttack(int energy);
        public abstract double Defend(double comingAttack);



    }
}
