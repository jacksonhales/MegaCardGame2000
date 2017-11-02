using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Backstab : SpecialAttack
    {
        public double SuccessRate;
        public bool AttackSucceeds;
        public bool AttackFails;

        public Backstab()
        {
            SuccessRate = 33.33;
            AttackSucceeds = false;
            AttackFails = false;
        }

        public override int GetSpecialAttackDamage()
        {
            int damage;

            Random rand = new Random();

            double r = rand.Next(0, 100);

            if (r <= SuccessRate)
            {
                AttackSucceeds = true;
                AttackFails = false;

                damage = 20;
            }
            else
            {
                AttackSucceeds = false;
                AttackFails = true;

                damage = 5;
            }

            return damage;
        }
    }
}
