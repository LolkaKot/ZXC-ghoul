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
    /// Логика взаимодействия для Task7.xaml
    /// </summary>
    public partial class Task7 : Page
    {
        public Task7()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int n = random.Next(1, 100);


            int maxK = -1;
            int max3K = -1;

            for (int i = 1; i <= n; i++)
            {
                int candidate3K = 3 * i;
                if (candidate3K < n && candidate3K > max3K)
                {
                    maxK = i;
                    max3K = candidate3K;
                }
            }

            MessageBox.Show("максимальный K: " + maxK);
            MessageBox.Show("соответствующий 3K: " + max3K);
        }
    }
}
