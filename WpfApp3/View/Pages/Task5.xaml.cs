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

namespace WpfApp3.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task5.xaml
    /// </summary>
    public partial class Task5 : Page
    {
        public Task5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double a = random.NextDouble() * 10;
            int n = random.Next(1, 30);


            double result1 = 0;
            for (int i = 0; i <= n; i++)
            {
                result1 += Math.Pow(a, i);
            }
            MessageBox.Show("задача 1:" + result1);


            double result2 = 0;
            for (int i = 0; i <= n; i++)
            {
                result2 += Math.Pow(-1, i) * Math.Pow(a, i);
            }
            MessageBox.Show("задача 2: " + result2);
        }
    }
}
