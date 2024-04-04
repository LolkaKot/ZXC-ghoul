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
    /// Логика взаимодействия для Task11.xaml
    /// </summary>
    public partial class Task11 : Page
    {
        public Task11()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double x = random.NextDouble() * 10;
            int n = random.Next(1, 15);

            double result = 1;
            double term = 1;
            for (int i = 1; i <= n; i++)
            {
                term *= x / i;
                result += term;
            }

            MessageBox.Show("результат: " + result);
        }
    }
}
