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
    /// Логика взаимодействия для Task29.xaml
    /// </summary>
    public partial class Task29 : Page
    {
        public Task29()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double a = random.NextDouble() * 100;
            int n = random.Next(1, 100); 

            double z = 0;
            for (int i = 1; i <= n; i++)
            {
                z += Math.Pow(a, 2) - Math.Pow(i, 2);
            }

            MessageBox.Show($"A: {a}\nN: {n}\nСумма разностей квадратов: {z}");
        }
    }
}
