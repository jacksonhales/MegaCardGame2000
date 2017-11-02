using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Character
    {

        public int currentHealthPoints;
        public int baseDamage;
        public string characterName;
        public NormalAttack normalAttack;

        public Character()
        {

        }

        public Character(string pCharacterName, int pCurrentHealthPoints, int pBaseDamage)
        {
            this.characterName = pCharacterName;
            this.currentHealthPoints = pCurrentHealthPoints;
            this.baseDamage = pBaseDamage;
        }

        public int GetNormalAttackDamage()
        {
            return normalAttack.GetDamage();
        }

        public void TakeDamage(int pDamage)
        {
            currentHealthPoints -= pDamage;
        }
    }
}
