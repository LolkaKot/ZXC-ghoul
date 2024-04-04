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
    /// Логика взаимодействия для Task30.xaml
    /// </summary>
    public partial class Task30 : Page
    {
        public Task30()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int n = random.Next(-1000, 1000);
            int min = n;
            for (int i = 10; i <= n; i++)
            {
                if (i < min)
                {
                    min = i;
                }

            }
            MessageBox.Show($"Наименьшая цифра в случайно сгенерированном числе от 10 до {n} равна: {min}");
        }
    }
}
