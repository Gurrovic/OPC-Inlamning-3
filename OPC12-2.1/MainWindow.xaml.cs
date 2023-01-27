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

namespace OPC12_2._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double temp = 0;        
        string operation = "";
        string output = "";        
        
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;

            DividedBtn.Content = "\u00F7";
            SquareBtn.Content = "x\u00B2";
            SquareNBtn.Content = "x\u207F";
        }

        private void NumBtnClick(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            switch (name)
            {
                case "OneBtn":                    
                    output += "1";
                    OutputTextBlock.Text = output;
                    break;                   
                    
                    
                case "TwoBtn":
                    output += "2";
                    OutputTextBlock.Text = output;
                    break;
                    
                case "ThreeBtn":
                    output += "3";
                    OutputTextBlock.Text = output;
                    break;

                case "FourBtn":
                    output += "4";
                    OutputTextBlock.Text = output;
                    break;

                case "FiveBtn":
                    output += "5";
                    OutputTextBlock.Text = output;
                    break;

                case "SixBtn":
                    output += "6";
                    OutputTextBlock.Text = output;
                    break;

                case "SevenBtn":
                    output += "7";
                    OutputTextBlock.Text = output;
                    break;

                case "EightBtn":
                    output += "8";
                    OutputTextBlock.Text = output;
                    break;

                case "NineBtn":
                    output += "9";
                    OutputTextBlock.Text = output;
                    break;

                case "ZeroBtn":
                    output += "0";
                    OutputTextBlock.Text = output;
                    break;
            }
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if (output != "")
            {
                temp = Convert.ToDouble(output);
                output = "";

                operation = "Minus";                
            }
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = Convert.ToDouble(output);
                output = "";

                operation = "Plus";
            }
        }

        private void TimesBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = Convert.ToDouble(output);
                output = "";

                operation = "Times";
            }
        }

        private void DividedBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = Convert.ToDouble(output);
                output = "";

                operation = "Divided";
            }
        }

        private void SquareBtn_Click(object sender, RoutedEventArgs e)
        {
            double square = double.Parse(output);
            output = Math.Pow(square, 2).ToString();
            OutputTextBlock.Text = output;
        }

        private void SquareNBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = Convert.ToDouble(output);
                output = "";

                operation = "SquareN";
            }
        }

        private void EqualBtn_Click(object sender, RoutedEventArgs e)
        {
            double outputTemp;
            switch (operation)
            {
                case "Minus":
                    outputTemp = temp - double.Parse(output);
                    output = outputTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;

                case "Plus":
                    outputTemp = temp + double.Parse(output);
                    output = outputTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;

                case "Times":
                    outputTemp = temp * double.Parse(output);
                    output = outputTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;

                case "Divided":
                    if(double.Parse(output) != 0)
                    {
                        outputTemp = Math.Round(temp / double.Parse(output), 5);
                        output = outputTemp.ToString();
                        OutputTextBlock.Text = output;                        
                    }
                    break;                

                case "SquareN":
                    outputTemp = Math.Pow(temp, double.Parse(output));
                    output = outputTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;
            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            output = "";
            OutputTextBlock.Text = "0";            
        }        
    }
}
