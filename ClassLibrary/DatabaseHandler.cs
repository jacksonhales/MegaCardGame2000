using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class DatabaseHandler
    {

        public void dbConnect()
        {
            // Unsure how to implement as specified
            throw new NotImplementedException();
        }

        public void delete()
        {
            // Unsure how to implement as specified
            throw new NotImplementedException();
        }

        public string[] GetEnemyData()
        {
            // Unsure how to implement as specified
            throw new NotImplementedException();

            string[] enemies;

            enemies = new string[3];

            return enemies;
        }

        public string[] SelectNPC(int randomNr)
        {
            // dbConnect();

            // clear xdoc
            XDocument xdoc = null;

            // load XML into xdoc
            using (XmlReader xr = XmlReader.Create(@"NonPlayerCharacters.xml"))
            {
                xdoc = XDocument.Load(xr);
            }

            // LINQ query values in xdoc for selected NPC data, based on randomNr
            var query = from NPCAttribute in xdoc.Descendants("NonPlayerCharacters")
                        where NPCAttribute.Element("NPCID").Value == Convert.ToString(randomNr)
                        select new
                        {
                            NPCName = NPCAttribute.Element("NPCName").Value,
                            NPCHealthPoints = NPCAttribute.Element("NPCHealthPoints").Value,
                            NPCBaseDamage = NPCAttribute.Element("NPCBaseDamage").Value
                        };
            // instantiate array to hold NPC details
            string[] NPC = new string[3];

            // apply query results to array
            foreach (var NPCAttribute in query)
            {
                NPC[0] = NPCAttribute.NPCName;
                NPC[1] = NPCAttribute.NPCHealthPoints;
                NPC[2] = NPCAttribute.NPCBaseDamage;
            }        

            return NPC;
        }

    }
}
