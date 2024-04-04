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
    /// Логика взаимодействия для Task22.xaml
    /// </summary>
    public partial class Task22 : Page
    {
        public Task22()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double x = random.NextDouble() * 50;
            double r;

            if (x > 0 && x <= 3.14)
            {
                r = Math.Sin(x);
            }
            else if (x >= -3.14 && x < 0)
            {
                r = Math.Pow(x, 3);
            }
            else if (x < -23.14 || x > 23.14)
            {
                r = Math.Pow(x, 2);
            }
            else
            {
                r = 0;
            }

            MessageBox.Show($"Для x = {x}, r = {r}");
        }
    }
}
