using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using MegaCardGame2000;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void CharacterConstructor()
        {
            // Arrange
            Character vCharacter = new Character("Warrior", 50, 10);

            // Act

            // Assert
            Assert.AreEqual(vCharacter.characterName, "Warrior");
            Assert.AreEqual(vCharacter.currentHealthPoints, 50);
            Assert.AreEqual(vCharacter.baseDamage, 10);

        }

        [TestMethod]
        public void NonPlayerCharacterConstructor()
        {
            // Arrange
            NonPlayerCharacter vNonPlayerCharacter = new NonPlayerCharacter("Goblin", 160, 15);

            // Act

            // Assert
            Assert.AreEqual(vNonPlayerCharacter.characterName, "Goblin");
            Assert.AreEqual(vNonPlayerCharacter.currentHealthPoints, 160);
            Assert.AreEqual(vNonPlayerCharacter.baseDamage, 15);
        }

        [TestMethod]
        public void WarriorConstructor()
        {
            // Arrange
            SpecialAttack vSpecialAttack = new Berserk();
            PlayerCharacter vPlayerCharacter = new PlayerCharacter("Warrior", 50, 10, vSpecialAttack);

            // Act

            // Assert
            Assert.AreEqual(vPlayerCharacter.characterName, "Warrior");
            Assert.AreEqual(vPlayerCharacter.currentHealthPoints, 50);
            Assert.AreEqual(vPlayerCharacter.baseDamage, 10);
            Assert.IsInstanceOfType(vSpecialAttack, typeof(Berserk));
        }

        [TestMethod]
        public void ThiefConstructor()
        {
            // Arrange
            SpecialAttack vSpecialAttack = new Backstab();
            PlayerCharacter vPlayerCharacter = new PlayerCharacter("Thief", 50, 10, vSpecialAttack);

            // Act

            // Assert
            Assert.AreEqual(vPlayerCharacter.characterName, "Thief");
            Assert.AreEqual(vPlayerCharacter.currentHealthPoints, 50);
            Assert.AreEqual(vPlayerCharacter.baseDamage, 10);
            Assert.IsInstanceOfType(vSpecialAttack, typeof(Backstab));
        }

        [TestMethod]
        public void MageConstructor()
        {
            // Arrange
            SpecialAttack vSpecialAttack = new Fireball();
            PlayerCharacter vPlayerCharacter = new PlayerCharacter("Mage", 50, 10, vSpecialAttack);

            // Act

            // Assert
            Assert.AreEqual(vPlayerCharacter.characterName, "Mage");
            Assert.AreEqual(vPlayerCharacter.currentHealthPoints, 50);
            Assert.AreEqual(vPlayerCharacter.baseDamage, 10);
            Assert.IsInstanceOfType(vSpecialAttack, typeof(Fireball));
        }

        [TestMethod]
        public void WarriorSelection()
        {
            // Arrange
            CharacterSelection vCharacterSelectionPage = new CharacterSelection();

            // Act
            //vCharacterSelectionPage.

            // Assert
            
        }

        [TestMethod]
        public void ThiefSelection()
        {
            // Arrange
            CharacterSelection vCharacterSelectionPage = new CharacterSelection();

            // Act
            //vCharacterSelectionPage.

            // Assert
        }

        [TestMethod]
        public void MageSelection()
        {
            // Arrange
            CharacterSelection vCharacterSelectionPage = new CharacterSelection();

            // Act
            //vCharacterSelectionPage.

            // Assert
        }

        [TestMethod]
        public void DBConnect()
        {
            // Unable to implement as requested
        }

        [TestMethod]
        public void SelectNPC()
        {
            // Arrange
            DatabaseHandler vDatabaseHandler = new DatabaseHandler();
            string[] sNPC = vDatabaseHandler.SelectNPC(1);
            NonPlayerCharacter vNPC= new NonPlayerCharacter();

            // Act
            vNPC.characterName = sNPC[0];
            vNPC.currentHealthPoints = Convert.ToInt32(sNPC[1]);
            vNPC.baseDamage = Convert.ToInt32(sNPC[2]);

            // Assert
            Assert.AreEqual(vNPC.characterName, "Troll");
            Assert.AreEqual(vNPC.currentHealthPoints, 80);
            Assert.AreEqual(vNPC.baseDamage, 20);

        }

        [TestMethod]
        public void GameControllerTakeDamage()
        {
            // Arrange
            NonPlayerCharacter vNPC = new NonPlayerCharacter();
            vNPC.currentHealthPoints = 50;

            // Act
            vNPC.TakeDamage(10);

            // Assert
            Assert.AreEqual(vNPC.currentHealthPoints, 40);
        }



    }
}
