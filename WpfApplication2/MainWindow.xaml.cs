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
using System.Globalization;
using Humanizer;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string language = "en";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            box2.Text = Convert.ToInt32(box1.Text).ToWords(new CultureInfo(language));
        }

        private void english_Click(object sender, RoutedEventArgs e)
        {
            language = "en";
        }

        private void french_Click(object sender, RoutedEventArgs e)
        {
            language = "fr";
        }

        private void german_Click(object sender, RoutedEventArgs e)
        {
            language = "de";
        }

        private void spanish_Click(object sender, RoutedEventArgs e)
        {
            language = "es";
        }

        private void rusian_Click(object sender, RoutedEventArgs e)
        {
            language = "ru";
        }

    }
}
