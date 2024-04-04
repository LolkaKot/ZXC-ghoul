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
    /// Логика взаимодействия для Task17.xaml
    /// </summary>
    public partial class Task17 : Page
    {
        public Task17()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double b = random.NextDouble();
            double a = random.NextDouble();
            int n = random.Next(1, 30);

            double step = (b - a) / n;

            List<double> functionValues = new List<double>();
            for (int i = 0; i <= n; i++)
            {
                double x = a + i * step;
                double fx = 1 - Math.Sin(x);
                functionValues.Add(fx);
            }

            
            MessageBox.Show($"Значения функции F(X) в равноотстоящих точках: {string.Join(", ", functionValues)}");
        }
    }
}
