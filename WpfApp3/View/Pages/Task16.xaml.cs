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
    /// Логика взаимодействия для Task16.xaml
    /// </summary>
    public partial class Task16 : Page
    {
        public Task16()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double b = random.NextDouble();
            double a = random.NextDouble();
            int n = random.Next(1, 30);

            double h = (b - a) / n;

            List<double> points = new List<double>();
            for (int i = 0; i <= n; i++)
            {
                points.Add(a + i * h);
            }


            MessageBox.Show($"Значение H: {h}\nНабор точек: {string.Join(", ", points)}");
        }
    }
}
