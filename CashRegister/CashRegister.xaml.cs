using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace CashRegister
{
    /// <summary>
    /// Interaction logic for CashRegister.xaml
    /// </summary>
    public partial class CashRegister : UserControl
    {
     
        public event PropertyChangedEventHandler PropertyChanged;

        double subtotal;
        double tax;
        double total;

        public double Subtotal
        {
            get
            {
                return subtotal;
            }
            private set
            {
                subtotal = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Subtotal)));
            }
        }
        public double Tax
        {
            get
            {
                return tax;
            }
            private set
            {
                tax = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Tax)));
            }
        }
        public double Total
        {
            get
            {
                return total;
            }
            private set
            {
                total = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Total)));
            }
        }

        public CashRegister()
        {
            subtotal = tax = total = 0;
            InitializeComponent();
            DataContext = this;
        }

        public void OnAddCharToText(object sender, RoutedEventArgs e)
        {
            string btnTitle = (string)((Button)sender).Content;
            txtBox_Input.Text = txtBox_Input.Text.Equals("0") ? btnTitle : txtBox_Input.Text + btnTitle;
        }
        public void OnEnter(object sender, RoutedEventArgs e)
        {
            string input = txtBox_Input.Text;
            double value;
            if (Double.TryParse(input, out value))
            {
                if (value < 0)
                {
                    Tax = tax - value;
                    txtBox_Tax.Clear();
                    txtBox_Tax.Text += Tax;
                }
                else
                {
                    Subtotal = subtotal + value;
                    txtBox_Subt.Clear();
                    txtBox_Subt.Text += Subtotal;
                }
                txtBox_Input.Text = "0";
            }
            else
            {
                MessageBox.Show("Invalid number entered!");
            }
        }
        public void OnClear(object sender, RoutedEventArgs e)
        {
            Total = Tax = Subtotal = 0;
            txtBox_Input.Text = "0";
        }
        public void OnTotal(object sender, RoutedEventArgs e)
        {
            Total = subtotal - tax;
            txtBox_Total.Text += Total;
        }
        public void OnDelete(object sender, RoutedEventArgs e)
        {
            txtBox_Input.Text = "0";
        }
    }
}

