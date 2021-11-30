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

namespace MultiplicationApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int first=0, second=0;
        
        public MainWindow()
        {
            
            InitializeComponent();
            timer_Tick(a);
            
        }
        void timer_Tick(object sender)
        {
            Random md = new Random();
            first = md.Next(1, 100);
            a.Text = "What is ";
            first = md.Next(1, 100);
            a.Text += first.ToString();
            a.Text += " times ";
            second = md.Next(1, 100);
            a.Text += second.ToString() +"?";
        }
        bool checkValue()
        {
            int result = first * second;
            int userResult = 0;
            if (Box.Text != "")
            {
            userResult = int.Parse(Box.Text);
            }
            
            if (result==userResult)
            {
                return true;
            }
            return false;
        }
        private void Ready_Click(object sender, RoutedEventArgs e)
        {
            Result(b);
        }

        void Result(object sender)
        {
            if (checkValue())
            {
                MessageBox.Show("Very good!");
                timer_Tick(a);
                Box.Text = "";
                
            }
            else
            {
                MessageBox.Show("No. Please try again.");
            }
        }
    }
}
