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
    /// Логика взаимодействия для Task19.xaml
    /// </summary>
    public partial class Task19 : Page
    {
        public Task19()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double d = random.NextDouble();
            double z = 1;
            double x = 2;
            double c = (z + x) / 2;
            int k = 3;

            while (Math.Abs(c - x) >= d)
            {
                z = x;
                x = c;
                c = (z + x) / 2;
                k++;
            }


            MessageBox.Show($"Номер K: {k}\nЧисло AK-1: {x}\nЧисло AK: {c}");
        }
    }
}
