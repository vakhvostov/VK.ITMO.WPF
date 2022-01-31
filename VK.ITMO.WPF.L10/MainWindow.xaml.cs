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

namespace VK.ITMO.WPF._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnSet.IsEnabled = false;
            btnRet.IsEnabled = false;
        }

  
        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            using(System.IO.StreamWriter sw = new System.IO.StreamWriter("..\\username.txt"))
            {
                sw.WriteLine(tbName.Text);                
            }
            btnRet.IsEnabled = true;
        }

        private void btnRet_Click(object sender, RoutedEventArgs e)
        {
            using(System.IO.StreamReader sr = new System.IO.StreamReader("..\\username.txt"))
            {
                lbName.Content = $"Hello, {sr.ReadToEnd()}";
            }
        }

        private void tbName_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnSet.IsEnabled = true;
        }
    }
}
