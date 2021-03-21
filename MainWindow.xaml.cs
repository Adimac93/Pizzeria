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

namespace Pizzeria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            gb1.IsEnabled = false;
            gb2.IsEnabled = false;

            bt3.IsEnabled = false;

        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            tb1a.Clear();
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            cb1.SelectedIndex = -1;
            
        }

        private void tb1a_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(tb1a.Text != "" && cb1.SelectedIndex != -1)
            {
                gb1.IsEnabled = true;
                gb2.IsEnabled = true;

                bt3.IsEnabled = true;
            }
            else
            {                
                gb1.IsEnabled = false;
                gb2.IsEnabled = false;
                bt3.IsEnabled = false;
                /*
                chb1.IsChecked = false;
                chb2.IsChecked = false;
                chb3.IsChecked = false;
                chb4.IsChecked = false;

                rb1.IsChecked = false;
                rb2.IsChecked = false;
                rb3.IsChecked = false;
                rb4.IsChecked = false;
                


                tb1.Clear();
                tb2.Clear();
                tb3.Clear();
                tb4.Clear();
                */
            }
        }

        private void cb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(tb1a.Text != "" && cb1.SelectedIndex != -1)
            {
                gb1.IsEnabled = true;
                gb2.IsEnabled = true;

                bt3.IsEnabled = true;
            }
            else
            {
                gb1.IsEnabled = false;
                gb2.IsEnabled = false;
                bt3.IsEnabled = false;
                /*
                chb1.IsChecked = false;
                chb2.IsChecked = false;
                chb3.IsChecked = false;
                chb4.IsChecked = false;

                rb1.IsChecked = false;
                rb2.IsChecked = false;
                rb3.IsChecked = false;
                rb4.IsChecked = false;
                


                tb1.Clear();
                tb2.Clear();
                tb3.Clear();
                tb4.Clear();
                */
            }
        }

        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Anulowałeś zamówienie","Uwaga");
            this.Close();
            

        }

        private void btAccept_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Złożono zamówienie", "Uwaga");
            this.Close();
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            lb1.Items.Insert(0, "ge");
        }
    }
}
