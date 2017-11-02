using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Fireball : SpecialAttack
    {
        public double SuccessRate;
        public bool AttackSucceeds;
        public bool AttackFails;

        public Fireball()
        {
            SuccessRate = 50.0;
            AttackSucceeds = false;
            AttackFails = false;
        }

        public override int GetSpecialAttackDamage()
        {
            int damage = 0;

            Random rand = new Random();
            
            double r = rand.Next(0, 100);

            if (r <= SuccessRate)
            {
                AttackSucceeds = true;
                AttackFails = false;

                damage = 40;
            }
            else
            {
                AttackSucceeds = false;
                AttackFails = true;

                damage = -10;
            }

            return damage;
        }
    }
}
