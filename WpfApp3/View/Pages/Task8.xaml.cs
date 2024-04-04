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
    /// Логика взаимодействия для Task8.xaml
    /// </summary>
    public partial class Task8 : Page
    {
        public Task8()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double a = random.NextDouble() * 10 + 1;

            int N = 1;
            double sum = 0;

            while (sum <= a)
            {
                sum += 1.0 / N;
                N++;
            }

            MessageBox.Show("минимальный N: " + (N - 1));
            MessageBox.Show("соответствующяя сумма: " + sum);
        }
    }
}
