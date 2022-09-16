using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float row1;
        float row2;
        bool rowDot = false;
        bool needClearrow1 = false;
        bool isNegative = false;
        char operation;
        float tempRow;
        public MainWindow()
        {
            InitializeComponent();
            Row1.Content = "0";
        }

        private bool CheckLength()
        {
            if (Row1.Content.ToString().Length > 12) return false;
            return true;
        }
        private bool FirstZero()
        {
            if (Row1.Content == "0") return true;
            return false;
        }
        private void OneBut_Click(object sender, RoutedEventArgs e)
        {
            if (CheckLength())
                if (!needClearrow1 && !FirstZero())
                    Row1.Content += "1";
                else
                {
                    Row1.Content = "1";
                    needClearrow1 = false;
                }
        }

        private void TwoBut_Click(object sender, RoutedEventArgs e)
        {
            if (CheckLength())
                if (!needClearrow1 && !FirstZero())
                    Row1.Content += "2";
                else
                {
                    Row1.Content = "2";
                    needClearrow1 = false;
                }
        }

        private void ThreeBut_Click(object sender, RoutedEventArgs e)
        {
            if (CheckLength())
                if (!needClearrow1 && !FirstZero())
                    Row1.Content += "3";
                else
                {
                    Row1.Content = "3";
                    needClearrow1 = false;
                }
        }

        private void FourBut_Click(object sender, RoutedEventArgs e)
        {
            if (CheckLength())
                if (!needClearrow1 && !FirstZero())
                    Row1.Content += "4";
                else
                {
                    Row1.Content = "4";
                    needClearrow1 = false;
                }
        }

        private void FiveBut_Click(object sender, RoutedEventArgs e)
        {
            if (CheckLength())
                if (!needClearrow1 && !FirstZero())
                    Row1.Content += "5";
                else
                {
                    Row1.Content = "5";
                    needClearrow1 = false;
                };
        }

        private void SixBut_Click(object sender, RoutedEventArgs e)
        {
            if (CheckLength())
                if (!needClearrow1 && !FirstZero())
                    Row1.Content += "6";
                else
                {
                    Row1.Content = "6";
                    needClearrow1 = false;
                }
        }

        private void SevenBut_Click(object sender, RoutedEventArgs e)
        {
            if (CheckLength())
                if (!needClearrow1 && !FirstZero())
                    Row1.Content += "7";
                else
                {
                    Row1.Content = "7";
                    needClearrow1 = false;
                }
        }

        private void EightBut_Click(object sender, RoutedEventArgs e)
        {
            if (CheckLength())
                if (!needClearrow1 && !FirstZero())
                    Row1.Content += "8";
                else
                {
                    Row1.Content = "8";
                    needClearrow1 = false;
                }
        }

        private void NineBut_Click(object sender, RoutedEventArgs e)
        {
            if (CheckLength())
                if (!needClearrow1 && !FirstZero())
                    Row1.Content += "9";
                else
                {
                    Row1.Content = "9";
                    needClearrow1 = false;
                }
        }

        private void ZeroBut_Click(object sender, RoutedEventArgs e)
        {
            if (CheckLength() && (rowDot || Row1.Content.ToString()[0] != '0'))
                if(!needClearrow1)
                    Row1.Content += "0";
                else
                    Row1.Content = "0";
        }           

        private void DotBut_Click(object sender, RoutedEventArgs e)
        {
            if (needClearrow1)
            {
                Row1.Content = "";
                needClearrow1 = false;
            }
            if (CheckLength() && !rowDot)
            {
                if (Row1.Content.ToString().Length == 0) Row1.Content += "0";
                Row1.Content += ",";
                rowDot = true;
            }
        }
        private bool CreateRow2()
        {
            
            if (row2 != 0 && operation != '√' && operation != '^' && operation != '#')
            {
                row1 = float.Parse(Row1.Content.ToString(), new CultureInfo("ru-ru"));
                needClearrow1 = true;
                tempRow = row2;
                {
                    
                    switch (operation)
                    {
                        case '+':
                            row2 += row1;
                            break;
                        case '-':
                            row2 -= row1;
                            break;
                        case '×':
                            row2 *= row1;
                            break;
                        case '÷':
                            row2 /= row1;
                            break;
                    }
                }
                return true;
            }
            else
                row2 = float.Parse(Row1.Content.ToString(), new CultureInfo("ru-ru"));
            needClearrow1 = true;
            rowDot = false;
            return false;
        }


        private void EnterBut_Click(object sender, RoutedEventArgs e)
        {
            if (!CreateRow2())
            {
                Row2.Content = row2 + "=";
                Row1.Content = row2;
            }
            else
            {
                Row1.Content = row2;
                Row2.Content = tempRow + operation.ToString() + row1 + "=";
            }

        }

        private void PlusBut_Click(object sender, RoutedEventArgs e)
        {
            operation = '+';
            CreateRow2();
            Row2.Content = row2 + "+";
        }

        private void MinusBut_Click(object sender, RoutedEventArgs e)
        {
            operation = '-';
            CreateRow2();
            Row2.Content = row2 + "-";
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            operation = '×';
            CreateRow2();
            Row2.Content = row2 + "×";
        }

        private void Divine_Click(object sender, RoutedEventArgs e)
        {
            operation = '÷';
            CreateRow2();
            Row2.Content = row2 + "÷";
        }

        private void ClearLine_Click(object sender, RoutedEventArgs e)
        {
            row1 = 0;
            Row1.Content = "0";
            isNegative = false;
            needClearrow1 = false;
            rowDot = false;
        }

        private void ClearAllLines_Click(object sender, RoutedEventArgs e)
        {
            row2 = 0;
            row1 = 0;
            Row1.Content = "0";
            Row2.Content = "0";
            isNegative = false;
            needClearrow1 = false;
            rowDot = false;
        }

        private void Erase_Click(object sender, RoutedEventArgs e)
        {
            if( Row1.Content.ToString().Length != 0)
            {
                Row1.Content = Row1.Content.ToString().Remove(Row1.Content.ToString().Length - 1, 1);
                row1 = float.Parse(Row1.Content.ToString(), new CultureInfo("ru-ru"));
                if (Row1.Content.ToString().Length == 0)
                {
                    Row1.Content = "0";
                    row1 = 0;
                }
            }
        }

        private void PlusMinusBut_Click(object sender, RoutedEventArgs e)
        {
            if (Row1.Content.ToString() != "0")
            {
                if (!isNegative)
                    Row1.Content = Row1.Content.ToString().Insert(0, "-");
                else
                    Row1.Content = Row1.Content.ToString().Replace("-", "");
                isNegative = !isNegative;
                row1 = -row1;
            }
        }

        private void RootOfX_Click(object sender, RoutedEventArgs e)
        {
            operation = '√';
            CreateRow2();
            Row2.Content = "sqrt(" + row2 + ")";
            row1 = (float)Math.Sqrt(row2);
            //if (row1 != Math.Truncate(row1))
            //    rowDot = true;
            Row1.Content = row1;
        }

        private void XInRank2_Click(object sender, RoutedEventArgs e)
        {
            operation = '^';
            CreateRow2();
            Row2.Content = "sqr(" + row2 + ")";
            row1 = (float)Math.Pow(row2,2);
            Row1.Content = row1;
        }

        private void OneDivideX_Click(object sender, RoutedEventArgs e)
        {
            operation = '#';
            CreateRow2();
            Row2.Content = "1/(" + row2 + ")";
            row1 = 1/row2;
            //if (row1 != Math.Truncate(row1))
            //    rowDot = true;
            Row1.Content = row1;
        }
    }
}
