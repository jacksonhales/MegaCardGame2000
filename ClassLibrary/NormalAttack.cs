using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class NormalAttack
    {
        public int GetDamage()
        {
            // workaround implemented due to NormalAttack not having access to PC or NPC basedamage
            return 10;
        }

        public void New()
        {
            throw new NotImplementedException();
        }
    }
}
