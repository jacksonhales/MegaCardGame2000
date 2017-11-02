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
    /// Interaction logic for GameResult.xaml
    /// </summary>
    public partial class GameResult : Window
    {
        public GameResult(string pTitle, string pResult, string pResultMessage)
        {
            InitializeComponent();
            this.Title = pTitle;
            this.lblResult.Content = pResult;
            this.lblResultMessage.Content = pResultMessage;
        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public bool NewGameSelected
        {
            get { return true; }
        }
    }
}
