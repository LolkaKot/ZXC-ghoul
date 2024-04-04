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
    /// Логика взаимодействия для Task9.xaml
    /// </summary>
    public partial class Task9 : Page
    {
        public Task9()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int n = random.Next(1, 15);

            double product = 1.0;

            for (int i = 1; i <= n; i++)
            {
                product *= i;
            }

            MessageBox.Show("произведение от 1 до N: " + product);
        }
    }
}
