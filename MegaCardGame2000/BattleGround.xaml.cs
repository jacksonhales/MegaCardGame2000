using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibrary;

namespace MegaCardGame2000
{
    /// <summary>
    /// Interaction logic for BattleGround.xaml
    /// </summary>
    public partial class BattleGround : Page
    {

        private string playerClass;
        GameController gameController;
        
        public BattleGround(string pPlayerClass)
        {
            InitializeComponent();

            playerClass = pPlayerClass;
            
            gameController = new GameController(this);
            gameController.ChoosePlayerCharacter(playerClass);
            gameController.StartBattle();
        }

        private void btnAttack_Click(object sender, RoutedEventArgs e)
        {
            if (rdbStandardAttack.IsChecked == true)
            {
                gameController.ChooseAttack(0);
            }
            else if (rdbSpecialAttack.IsChecked == true)
            {
                gameController.ChooseAttack(1);
            }
            else
            {
                throw new Exception("Please select an attack type!");
            }
        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            NewGame();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public void NewGame()
        {
            this.NavigationService.Navigate(new Uri("CharacterSelection.xaml", UriKind.Relative));
        }

    }
}
