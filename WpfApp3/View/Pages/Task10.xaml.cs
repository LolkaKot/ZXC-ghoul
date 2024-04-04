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
    /// Логика взаимодействия для Task10.xaml
    /// </summary>
    public partial class Task10 : Page
    {
        public Task10()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int n = random.Next(1, 30);

            double product = 1.0;

            for (int i = 2; i <= n; i++)
            {
                product *= 1.0 / i;
            }

            MessageBox.Show("произведение 2 * 1/(2) * 1/(3) * ... * 1/( N): " + product);
        }
    }
}
