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
using FizzBuzzLib;

namespace FizzBuzzWpf
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

        private void RunFizzBuzz(object sender, RoutedEventArgs e)
        {
            var fizzbuzz = new FizzBuzz();

            for (int i = 1; i <= 100; i++)
            {
//                ListBox.AddHandler();
            }

        }
    }
}
