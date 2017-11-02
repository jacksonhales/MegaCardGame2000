using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassLibrary
{
    public class GameController
    {

        public PlayerCharacter Player { get; set; }
        public NonPlayerCharacter Enemy { get; set; }

        public void ChoosePlayerCharacter(string pPlayerClass)
        {
            switch (pPlayerClass)
            {
                case "Warrior":
                    Player = new Warrior();
                    break;
                case "Thief":
                    Player = new Thief();
                    break;
                case "Mage":
                    Player = new Mage();
                    break;
            }
        }

        public void AttackNPC(string attackType)
        {
            
        }

        public void StartBattle()
        {
            // Call GetEnemyData - Selects which Enemy the Player will be fighting
            GetEnemyData();
            // Instatiate NPC

            // Delete DataBaseHandler instance?

            // Call SetGameDetails
            SetGameDetails();
        }

        public void ChooseAttack(int attType)
        {
            // Loops to check current health points for each player.
            // If a normal attack is selected (attType = 0), it calls GetNormalAttackDamage() to determine the value of the damage and then calls TakeDamage(int Damage) to apply the damage to the Non - Player Character.It then calls UpdateGameDetails() to refresh the screen.
            // If a special attack is selected (attType = 1), it calls GetSpecialAttackDamage() to determine the value of the damage.It calls TakeSpecialDamage(int Damage) and applies the damage to the Non - Player character if Damage is greater than or equal to zero or applies it to the player character if the damage is less than zero
            // It then calls UpdateGameDetails() to refresh the screen
            UpdateGameDetails();
            // When the loop ends, it displays either a victory message box with or a defeat message box
            // It resets all the remaining instances of classes to null
        }

        public string GetEnemyData()
        {
            // Randomly generate a number within the range of possible Non-Player Characters

            // Instantiates a Database Handler
            DatabaseHandler databaseHandler = new DatabaseHandler();

            // Runs NPCSelect using the randomly generated number as the parameter, randomNr
            Random rnd = new Random();
            int randomNr = rnd.Next(3);

            string[] NPC = databaseHandler.SelectNPC(randomNr);

            // Instantiates the Non Player Character
            Enemy = new NonPlayerCharacter();

            Enemy.CharacterName = NPC[0];
            Enemy.CurrentHealthPoints = Convert.ToInt32(NPC[1]);
            Enemy.BaseDamage = Convert.ToInt32(NPC[2]);

            // Deletes the instance of the Database Handler

            // Opens Page 2 - Battleground


            return "";
        }

        public int SetGameDetails()
        {
            // Populates Title with Player Character vs Non-Player Character names (eg “Mage vs Goblin”)
            
            // Loads images of Player Character and Non-Player Character in image boxes

            // Sets character descriptions with starting health points & normal attack damage and special attack details for Player Character only

            // Calls UpdateGameDetails()
            UpdateGameDetails();
            return 0;
        }

        public void UpdateGameDetails()
        {
            // Updates progress bar with Health Points details
            // Updates Health Points labels for both Player Character and Non - Player Character with current Health Point values

        }
    }
}
