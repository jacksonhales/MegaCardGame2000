using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class NonPlayerCharacter : Character
    {
        public string enemyType;

        public NonPlayerCharacter()
        {

        }

        public NonPlayerCharacter(string pCharacterName, int pCurrentHealthPoints, int pBaseDamage) : base (pCharacterName, pCurrentHealthPoints, pBaseDamage)
        {
            this.characterName = pCharacterName;
            this.currentHealthPoints = pCurrentHealthPoints;
            this.baseDamage = pBaseDamage;
        }


        public int ChooseEnemy()
        {
                
            return 0;
        }

        public int ApplyAttack()
        {

            return 0;
        }

        public int GetNPCAttackDamage()
        {
            // Gets the value of the NPC attack damage
            return baseDamage;
        }
    }
}
