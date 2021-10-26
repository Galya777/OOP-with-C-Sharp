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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Fields
        private enum Operation { NO_OPERATION, MULTIPLY, PLUS, SUSTRACT, DIVIDE }
        private Operation operation;
        private double input1;
        private double input2;
        private double result;
        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
        } 
        #endregion

        #region Utinity metods
        //Utinity method for prossing digit Button

        private void TypeDigit(string digit)
        {
            if (txtInput.Text.Equals("0"))
            {
                txtInput.Text = digit;
            }
            else
            {
                txtInput.Text += digit;
            }
        }
        
        #endregion

        #region Event handlers
        private void OperationClick(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(txtInput.Text, out input1))
            {
                
                string buttonTitle= (string)((Button)sender).Content;
                switch (buttonTitle)
                {
                    case "+":     operation = Operation.PLUS;  break;
                    case "-":     operation = Operation.SUSTRACT;  break;
                    case "*":     operation = Operation.MULTIPLY;  break;
                    case "/":     operation = Operation.DIVIDE;  break;
                           
                }
            }
            else
            {
                operation = Operation.NO_OPERATION;
                MessageBox.Show("Wrong input!");
            }
            txtInput.Text = "0";
        }
        private void DigitClick(object sender, RoutedEventArgs e)
        {

            string buttonTitle = (string)((Button)sender).Content;
            TypeDigit(buttonTitle);
        }     
        private void ComputeClick(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtInput.Text, out input2))
            {
                switch (operation)
                {
                    case Operation.MULTIPLY:
                        result = input1 * input2;
                        break;
                    case Operation.PLUS:
                        result = input1 + input2;
                        break;
                    case Operation.SUSTRACT:
                        result = input1 - input2;
                        break;
                    case Operation.DIVIDE:
                        result = input1 / input2;
                        break;
                }
                txtInput.Text = "" + result;
                operation = Operation.NO_OPERATION;
            }
            
            }
        
        private void BtnOff_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            input2 = 0;
            txtInput.Text = "0";
            operation = Operation.NO_OPERATION;
        }

        private void btnCA_Click(object sender, RoutedEventArgs e)
        {
            input1 = input2 = 0;
            txtInput.Text = "0";
            operation = Operation.NO_OPERATION;
        }
        #endregion
    }
}
