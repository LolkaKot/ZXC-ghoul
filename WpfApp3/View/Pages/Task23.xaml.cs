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
    /// Логика взаимодействия для Task23.xaml
    /// </summary>
    public partial class Task23 : Page
    {
        public Task23()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double n = random.NextDouble() * 50;

            long x = 1;
                long z = 1;

                for (int i = 1; i <= n; i++)
                {
                    x *= i;
                    z *= 2;
                }

                MessageBox.Show($"{n}! = {x}\n2^{n} = {z}", "Результат");
            

        }
    }
}
