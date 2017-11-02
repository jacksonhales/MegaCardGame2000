using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Thief : PlayerCharacter
    {
        
        public Thief()
        {
            characterName = "Thief";
            baseDamage = 10;
            currentHealthPoints = 50;
            normalAttack = new NormalAttack();
            specialAttack = new Backstab();
        }
    }
}
