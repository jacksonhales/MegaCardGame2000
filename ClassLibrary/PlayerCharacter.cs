using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PlayerCharacter : Character
    {

        public SpecialAttack specialAttack;

        public PlayerCharacter()
        {

        }

        public PlayerCharacter(string pCharacterName, int pCurrentHealthPoints, int pBaseDamage, SpecialAttack pSpecialAttack) : base(pCharacterName, pCurrentHealthPoints, pBaseDamage)
        {
            this.characterName = pCharacterName;
            this.currentHealthPoints = pCurrentHealthPoints;
            this.baseDamage = pBaseDamage;
            this.specialAttack = pSpecialAttack;
        }

        public int GetSpecialAttackDamage()
        {
            return specialAttack.GetSpecialAttackDamage();
        }
    }
}
