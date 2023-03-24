using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
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

namespace kalc1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void click_1(object sender, RoutedEventArgs e)
        {
            t1.Text += "1";
        }

        private void click_2(object sender, RoutedEventArgs e)
        {
            t1.Text += "2";
        }

        private void click_3(object sender, RoutedEventArgs e)
        {
            t1.Text += "3";
        }

        private void click_4(object sender, RoutedEventArgs e)
        {
            t1.Text += "4";
        }

        private void click_5(object sender, RoutedEventArgs e)
        {
            t1.Text += "5";
        }

        private void click_6(object sender, RoutedEventArgs e)
        {
            t1.Text += "6";
        }

        private void click_7(object sender, RoutedEventArgs e)
        {
            t1.Text += "7";
        }

        private void click_8(object sender, RoutedEventArgs e)
        {
            t1.Text += "8";
        }

        private void click_9(object sender, RoutedEventArgs e)
        {
            t1.Text += "9";
        }

        private void click_0(object sender, RoutedEventArgs e)
        {
            t1.Text += "0";
        }

        private void click_delete(object sender, RoutedEventArgs e)
        {
            t1.Text = "";
        }

        private void click_action(object sender, RoutedEventArgs e)
        {
            try
            {
                var action = (sender as Button).Content.ToString();
                if (char.IsDigit(t1.Text[t1.Text.Length - 1]) != false)
                {
                    t1.Text += action;
                }
                else if (char.IsDigit(t1.Text[t1.Text.Length - 1]) == false)
                {
                    t1.Text = t1.Text.Remove(t1.Text.Length - 1);
                    t1.Text += action;
                }
            }
            catch { }
        }
        private void click_plus(object sender, RoutedEventArgs e)
        {
            try
            {
                if (char.IsDigit(t1.Text[t1.Text.Length - 1]) != false)
                {
                    t1.Text += "+";
                }
                else if (char.IsDigit(t1.Text[t1.Text.Length - 1]) == false)
                {
                    t1.Text = t1.Text.Remove(t1.Text.Length - 1);
                    t1.Text += "+";
                }
            }
            catch { }
        }

        private void click_minus(object sender, RoutedEventArgs e)
        {
            try
            {
                if (t1.Text.Length == 0 || char.IsDigit(t1.Text[t1.Text.Length - 1]) != false)
                {
                    t1.Text += "-";
                }
                else if (char.IsDigit(t1.Text[t1.Text.Length - 1]) == false)
                {
                    t1.Text = t1.Text.Remove(t1.Text.Length - 1);
                    t1.Text += "-";
                }
            }
            catch { }
        }

        private void click_unmoj(object sender, RoutedEventArgs e)
        {
            try
            {
                if (char.IsDigit(t1.Text[t1.Text.Length - 1]) != false)
                {
                    t1.Text += "*";
                }
                else if (char.IsDigit(t1.Text[t1.Text.Length - 1]) == false)
                {
                    t1.Text = t1.Text.Remove(t1.Text.Length - 1);
                    t1.Text += "*";
                }
            }
            catch { }
        }

        private void click_delenie(object sender, RoutedEventArgs e)
        {
            try
            {
                if (char.IsDigit(t1.Text[t1.Text.Length - 1]) != false)
                {
                    t1.Text += "/";
                }
                else if (char.IsDigit(t1.Text[t1.Text.Length - 1]) == false)
                {
                    t1.Text = t1.Text.Remove(t1.Text.Length - 1);
                    t1.Text += "/";
                }
            }
            catch { }
        }

        private void click_ravno(object sender, RoutedEventArgs e)
        {
            try
            {
                string value = new DataTable().Compute(t1.Text.Replace(",", "."), null).ToString();

                
                
                if (value == "∞" || value == "-∞" || value == "False")
                {
                    MessageBox.Show("Деление на 0 невозможно");
                }
                else
                {
                    t6.Content = t5.Content;
                    t5.Content = t4.Content;
                    t4.Content = t3.Content;
                    t3.Content = t2.Content;
                    t2.Content = t1.Text + "=" + value;

                    t1.Text = value;
                }
            }
            catch 
            {
//                t6.Content = t5.Content;
//                t5.Content = t4.Content;
//                t4.Content = t3.Content;
//                t3.Content = t2.Content;
//                t2.Content = t1.Text + "=" + value;
            }
        }

        private void click_ydalit_1digit(object sender, RoutedEventArgs e)
        {
            try
            {
                t1.Text = t1.Text.Remove(t1.Text.Length - 1);
            }
            catch
            {

            }
        }



        private void click_skobka1(object sender, RoutedEventArgs e)
        {
            t1.Text += "(";
        }
        private void click_skobka2(object sender, RoutedEventArgs e)
        {
            t1.Text += ")";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            window1.Width = 500;
            t2.Visibility = Visibility.Visible;
            t3.Visibility = Visibility.Visible;
            t4.Visibility = Visibility.Visible;
            t5.Visibility = Visibility.Visible;
            t6.Visibility = Visibility.Visible;
        }

        private void checked1(object sender, RoutedEventArgs e)
        {
            window1.Width = 280;
            t2.Visibility = Visibility.Hidden;
            t3.Visibility = Visibility.Hidden;
            t4.Visibility = Visibility.Hidden;
            t5.Visibility = Visibility.Hidden;
            t6.Visibility = Visibility.Hidden;
        }

        private void mem2(object sender, RoutedEventArgs e)
        {
            string[] content = (sender as Button).Content.ToString().Split('=');
            t1.Text = content[0];
     //       t1.Text = t2.Content.ToString().Split();
        }

    }


        


    }



