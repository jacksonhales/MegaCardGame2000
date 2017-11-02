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

namespace MegaCardGame2000
{
    /// <summary>
    /// Interaction logic for CharacterSelection.xaml
    /// </summary>
    public partial class CharacterSelection : Page
    {

        private string selectedClass;

        public CharacterSelection()
        {
            InitializeComponent();

            bdrWarriorImage.BorderBrush = System.Windows.Media.Brushes.Red;
            bdrThiefImage.BorderBrush = System.Windows.Media.Brushes.Black;
            bdrMageImage.BorderBrush = System.Windows.Media.Brushes.Black;

            selectedClass = "Warrior";
        }

        private void btnStartGame_Click(object sender, RoutedEventArgs e)
        {
            BattleGround battleGround = new BattleGround(selectedClass);
            NavigationService.Navigate(battleGround);
        }

        private void btnWarrior_Click(object sender, RoutedEventArgs e)
        {
            bdrWarriorImage.BorderBrush = System.Windows.Media.Brushes.Red;
            bdrThiefImage.BorderBrush = System.Windows.Media.Brushes.Black;
            bdrMageImage.BorderBrush = System.Windows.Media.Brushes.Black;

            selectedClass = "Warrior";

        }

        private void btnThief_Click(object sender, RoutedEventArgs e)
        {
            bdrWarriorImage.BorderBrush = System.Windows.Media.Brushes.Black;
            bdrThiefImage.BorderBrush = System.Windows.Media.Brushes.Red;
            bdrMageImage.BorderBrush = System.Windows.Media.Brushes.Black;

            selectedClass = "Thief";
        }

        private void btnMage_Click(object sender, RoutedEventArgs e)
        {
            bdrWarriorImage.BorderBrush = System.Windows.Media.Brushes.Black;
            bdrThiefImage.BorderBrush = System.Windows.Media.Brushes.Black;
            bdrMageImage.BorderBrush = System.Windows.Media.Brushes.Red;

            selectedClass = "Mage";
        }
    }
}
