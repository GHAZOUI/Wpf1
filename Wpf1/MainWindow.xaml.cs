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

namespace Wpf1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = label1.Content + "Connect ... \n";
            //textBox.Text = textBox.Text + "12345 \n";

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = label1.Content + "Inisialisation ... \n";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(textBox.Text))
            {
                label1.Content = label1.Content + "Send ... " + textBox.Text + "\n";
            }
        }
    }
}
