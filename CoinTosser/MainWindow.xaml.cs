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

namespace CoinTossing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string side;
        int headCounter = 0;
        int tossCounter = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Toss_Click(object sender, RoutedEventArgs e)
        {
            Random sideNumber = new Random();
            int number = sideNumber.Next(1, 100);
            if (number % 2 == 0)
            {
                side = "heads";
                headCounter++;
                coin.Visibility.Equals("Visible");
            }
            else
            {
                side = "toss";
                tossCounter++;
                toss.Visibility.Equals("Visible");
            }
        }
        private bool Flip()
        {
            if (side == "heads")
            {
                return true;
            }
            return false;
        }
    }
}
