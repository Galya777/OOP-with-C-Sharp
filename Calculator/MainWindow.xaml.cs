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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        string first=string.Empty;
        string second=string.Empty;
        private char operation='0';
        double result=0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void FillArguments(string value)
        {
            if (first == string.Empty)
            {
                first = value;
            } else
            {
                if (operation != 0)
                {
                    second += value; 
                }
                else
                {
                 first += value;
                }
            }
        }
        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
            FillArguments("1");
        }

        private void doubkeZero_Click(object sender, RoutedEventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "00";
            }
            else
            {
                textBox1.Text = textBox1.Text + "00";
            }
            FillArguments("00");
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
            FillArguments("4");
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
            FillArguments("7");
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
            FillArguments("0");
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
            FillArguments("5");
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
            FillArguments("2");
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
            FillArguments("8");
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
            FillArguments("3");
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
            FillArguments("6");
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
            FillArguments("9");
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0+";
            }
            else
            {
                textBox1.Text = textBox1.Text + "+";
            }
            operation = '+';
        }

        private void dot_Click(object sender, RoutedEventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0.";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }

        }

        private void devide_Click(object sender, RoutedEventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0/";
            }
            else
            {
                textBox1.Text = textBox1.Text + "/";
            }
            operation = '/';
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            double one = Convert.ToDouble(first);
            double two = Convert.ToDouble(second);
            if (operation == '+')
            {
                result = one + two;
                
            } else if (operation == '/')
            {
                if (two != 0)
                {
                    result = one / two;
                } else
                {
                    textBox1.Text = "ERORR";
                }
            }
            else if (operation == '-')
            {
                result = one - two;
            }
            else if (operation == '*')
            {
                result = one* two;
            }
            textBox1.Text =result.ToString();
            first=sexond;
            second=0;
            operation='0';
        }

        private void off_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = " ";
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void clearAll_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "0";
        }

        private void multiplication_Click(object sender, RoutedEventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0*";
            }
            else
            {
                textBox1.Text = textBox1.Text + "*";
            }
            operation = '*';
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0-";
            }
            else
            {
                textBox1.Text = textBox1.Text + "-";
            }
            operation = '-';
        }
    }
}
