﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Mage : PlayerCharacter
    {

        public Mage()
        {
            characterName = "Mage";
            baseDamage = 10;
            currentHealthPoints = 50;
            normalAttack = new NormalAttack();
            specialAttack = new Fireball();
        }

    }
}
