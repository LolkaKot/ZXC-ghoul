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
    /// Логика взаимодействия для Task18.xaml
    /// </summary>
    public partial class Task18 : Page
    {
        public Task18()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double d = random.NextDouble();

            double x = 2;
            double y = 2 + 1 / x;
            int k = 2;

            while (Math.Abs(y - x) >= d)
            {
                x = y;
                y = 2 + 1 / x;
                k++;
            }


            MessageBox.Show($"Номер K: {k}\nЧисло AK-1: {x}\nЧисло AK: {y}");
        }
    }
}
