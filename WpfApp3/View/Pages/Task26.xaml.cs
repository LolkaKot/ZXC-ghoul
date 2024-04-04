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
    /// Логика взаимодействия для Task26.xaml
    /// </summary>
    public partial class Task26 : Page
    {
        public Task26()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Random random = new Random();
            int n = random.Next(10000, 100000);

            if (p(n))
            {
                MessageBox.Show($"Сгенерированное число {n} является семитричным.", "Результат");
            }
            else
            {
                MessageBox.Show($"Сгенерированное число {n} не является семитричным.", "Результат");
            }
        }

        private bool p(int x)
        {
            string z = x.ToString();
            int left = 0;
            int right = z.Length - 1;

            while (left < right)
            {
                if (z[left] != z[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }
    
}
