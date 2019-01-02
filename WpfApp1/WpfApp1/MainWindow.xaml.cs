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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            days.Text = ""+ int.Parse(want.Text) / (int.Parse(income.Text) - int.Parse(expend.Text));
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Want_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Days_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Income_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
