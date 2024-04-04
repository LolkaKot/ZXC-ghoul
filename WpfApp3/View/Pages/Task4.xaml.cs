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
    /// Логика взаимодействия для Task4.xaml
    /// </summary>
    public partial class Task4 : Page
    {
        public Task4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int n = random.Next(1, 30);
            int a = random.Next(1, 30);

            for (int i = 1; i <= n; i++)
            {
                int power = 1;
                for (int j = 1; j <= i; j++)
                {
                    power *= a;
                }
                MessageBox.Show($"{a}^{i} = {power}");
            }
        }
    }
}
