using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ClassLibrary;
using MegaCardGame2000;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace ClassLibrary
{
    public class GameController
    {

        public BattleGround battleGround;
        public  PlayerCharacter player;
        public NonPlayerCharacter enemy;

        public GameController(BattleGround pBattleGround)
        {
            battleGround = pBattleGround;
        }

        public void ChoosePlayerCharacter(string pPlayerClass)
        {
            switch (pPlayerClass)
            {
                case "Warrior":
                    player = new Warrior();
                    break;
                case "Thief":
                    player = new Thief();
                    break;
                case "Mage":
                    player = new Mage();
                    break;
            }
        }

        public void AttackNPC(string attackType)
        {
            throw new NotImplementedException();
        }

        public void StartBattle()
        {
            // Call GetEnemyData - Selects which Enemy the Player will be fighting
            GetEnemyData();

            // Delete DataBaseHandler instance?

            // Call SetGameDetails
            SetGameDetails();
        }

        public void ChooseAttack(int attType)
        {
            // Check current health points for each player.
            if (player.currentHealthPoints <= 0 || enemy.currentHealthPoints <= 0)
            {
                // Update form with current details and display victory/loss message
                UpdateGameDetails();
            }
            else
            {
                // If a normal attack is selected (attType = 0), it calls GetNormalAttackDamage() to determine the value of the damage and then calls TakeDamage(int Damage) to apply the damage to the Non - Player Character.It then calls UpdateGameDetails() to refresh the screen.
                if (attType == 0)
                {
                    // Player NormalAttack turn
                    enemy.TakeDamage(player.baseDamage);

                    // NPC NormalAttack turn
                    player.TakeDamage(enemy.baseDamage);

                    // Update form with new hitpoints for both Player and Enemy
                    UpdateGameDetails();
                }
                // If a special attack is selected (attType = 1), it calls GetSpecialAttackDamage() to determine the value of the damage.It calls TakeSpecialDamage(int Damage) and applies the damage to the Non - Player character if Damage is greater than or equal to zero or applies it to the player character if the damage is less than zero
                else if (attType == 1)
                {
                    int damage;

                    // Player SpecialAttack turn
                    damage = player.GetSpecialAttackDamage();

                    // Player SpecialAttack turn
                    // MAGE BACKFIRE
                    if (damage < 0)
                    {
                        player.TakeDamage(10);
                    }
                    else
                    {
                        //SUCCESSFUL ATTACK
                        enemy.TakeDamage(player.GetSpecialAttackDamage());
                    }

                    // NPC NormalAttack turn
                    player.TakeDamage(enemy.baseDamage);

                    // It then calls UpdateGameDetails() to refresh the screen
                    UpdateGameDetails();
                    }
            }
            // When the loop ends, it displays either a victory message box with or a defeat message box
            // It resets all the remaining instances of classes to null
        }



        public string GetEnemyData()
        {
            // Instantiates a Database Handler
            DatabaseHandler databaseHandler = new DatabaseHandler();

            // Runs NPCSelect using the randomly generated number as the parameter, randomNr
            Random rnd = new Random();
            int randomNr = rnd.Next(3);

            string[] NPC = databaseHandler.SelectNPC(randomNr);

            // Instantiates the Non Player Character
            enemy = new NonPlayerCharacter();

            enemy.characterName = NPC[0];
            enemy.currentHealthPoints = Convert.ToInt32(NPC[1]);
            enemy.baseDamage = Convert.ToInt32(NPC[2]);

            // Deletes the instance of the Database Handler

            return "";
        }

        public int SetGameDetails()
        {
            var uri = new Uri("pack://siteoforigin:,,,/Resources/warrior.jpg");
            var bitmap = new BitmapImage(uri);

            // Populates Title with Player Character vs Non-Player Character names (eg “Mage vs Goblin”)
            battleGround.lblPlayerName.Content = player.characterName;
            battleGround.lblEnemyName.Content = enemy.characterName;

            // Loads images of Player Character and Non-Player Character in image boxes
            // load player image
            switch (player.characterName)
            {
                case "Warrior":
                    uri = new Uri("pack://siteoforigin:,,,/Resources/warrior.jpg");
                    bitmap = new BitmapImage(uri);
                    battleGround.imgPlayer.Source = bitmap;
                    break;
                case "Thief":
                    uri = new Uri("pack://siteoforigin:,,,/Resources/thief.jpg");
                    bitmap = new BitmapImage(uri);
                    battleGround.imgPlayer.Source = bitmap;
                    break;
                case "Mage":
                    uri = new Uri("pack://siteoforigin:,,,/Resources/mage.jpg");
                    bitmap = new BitmapImage(uri);
                    battleGround.imgPlayer.Source = bitmap;
                    break;
            }

            // load enemy image
            switch (enemy.characterName)
            {
                case "Goblin":
                    uri = new Uri("pack://siteoforigin:,,,/Resources/goblin.jpg");
                    bitmap = new BitmapImage(uri);
                    battleGround.imgEnemy.Source = bitmap;
                    break;
                case "Pixie":
                    uri = new Uri("pack://siteoforigin:,,,/Resources/pixie.jpg");
                    bitmap = new BitmapImage(uri);
                    battleGround.imgEnemy.Source = bitmap;
                    break;
                case "Troll":
                    uri = new Uri("pack://siteoforigin:,,,/Resources/troll.jpg");
                    bitmap = new BitmapImage(uri);
                    battleGround.imgEnemy.Source = bitmap;
                    break;
            }

            // set health bar range with character max health
            battleGround.pgbPlayerHealth.Minimum = 0;
            battleGround.pgbPlayerHealth.Maximum = player.currentHealthPoints;
            battleGround.pgbPlayerHealth.Value = player.currentHealthPoints;
            battleGround.pgbEnemyHealth.Minimum = 0;
            battleGround.pgbEnemyHealth.Maximum = enemy.currentHealthPoints;
            battleGround.pgbEnemyHealth.Value = enemy.currentHealthPoints;

            // set health labels
            battleGround.lblPlayerHealth.Content = player.currentHealthPoints;
            battleGround.lblEnemyHealth.Content = player.currentHealthPoints;

            // Sets character descriptions with starting health points & normal attack damage and special attack details for Player Character only
            // Player descriptions
            switch (player.characterName)
            {
                case "Warrior":
                battleGround.txtPlayerDescription.Text = "Starting health points: \n" +
                                                        "Normal Attack damage: \n" +
                                                        "Special Attack details: \n" +
                                                        "- Berserk \n" +
                                                        "- 1 in 3 success rate \n" +
                                                        "- Sucessful: 3x normal damage \n" +
                                                        "- Unsuccesful: forfeit turn";
                    break;
                case "Thief":
                    battleGround.txtPlayerDescription.Text = "Starting health points: 50 \n" +
                                                        "Normal Attack damage: 10 \n" +
                                                        "Special Attack details: \n" +
                                                        "- Backstab \n" +
                                                        "- 1 in 3 success rate \n" +
                                                        "- Sucessful: 2x normal damage \n" +
                                                        "- Unsuccesful: 1x normal damage";
                    break;
                case "Mage":
                    battleGround.txtPlayerDescription.Text = "Starting health points: 50 \n" +
                                                        "Normal Attack damage: 10 \n" +
                                                        "Special Attack details: \n" +
                                                        "- Fireball \n" +
                                                        "- 1 in 2 success rate \n" +
                                                        "- Sucessful: 4x normal damage \n" +
                                                        "- Unsuccesful: 1x normal damage to self";
                    break;
            }

            // NPC descriptions
            battleGround.txtEnemyDescription.Text = "Starting health points: " + enemy.currentHealthPoints + "\n" +
                                                    "Normal Attack damage: " + enemy.baseDamage;

            // Calls UpdateGameDetails()
            UpdateGameDetails();

            // unsure why method returns anything
            return 0;
        }
        public void UpdateGameDetails()
        {
            // Update health bars
            battleGround.pgbPlayerHealth.Value = player.currentHealthPoints;
            battleGround.pgbEnemyHealth.Value = enemy.currentHealthPoints;

            if (player.currentHealthPoints < 20)
            {
                battleGround.pgbPlayerHealth.Foreground = System.Windows.Media.Brushes.Yellow;
            }
            else if (enemy.currentHealthPoints < 20)
            {
                battleGround.pgbEnemyHealth.Foreground = System.Windows.Media.Brushes.Yellow;
            }

            // Updates HP labels
            battleGround.lblPlayerHealth.Content = player.currentHealthPoints;
            battleGround.lblEnemyHealth.Content = enemy.currentHealthPoints;

            bool newGame = false;

            if (player.currentHealthPoints <= 0)
            {
                GameResult gameResult = new GameResult("The Vanquished", "Commiserations", "The " + enemy.characterName + " has beaten you in battle");
                if (gameResult.ShowDialog() == true)
                {
                    newGame = true;
                }
                
            }
            else if (enemy.currentHealthPoints <= 0)
            {
                GameResult gameResult = new GameResult("The Victor!", "Congratulations!", "You have beaten the " + enemy.characterName + " in battle!");
                if (gameResult.ShowDialog() == true)
                {
                    newGame = true;
                }
            }

            if (newGame == true)
            {
                battleGround.NewGame();
            }

        }
    }
}
