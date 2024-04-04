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
    /// Логика взаимодействия для Task14.xaml
    /// </summary>
    public partial class Task14 : Page
    {
        public Task14()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double x = random.NextDouble();
            int n = random.Next(1, 30);

            double result = 0;

            for (int i = 1; i <= n; i++)
            {
                result += Math.Pow(-1, i - 1) * Math.Pow(x, i) / i;
            }

            MessageBox.Show("результат: " + result);
        }
    }
}
