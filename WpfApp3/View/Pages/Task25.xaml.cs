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
    /// Логика взаимодействия для Task25.xaml
    /// </summary>
    public partial class Task25 : Page
    {
        public Task25()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double n = random.Next(10, 50);
            StringBuilder result = new StringBuilder();
            for (int i = 10; i <= n; i++)
            {
                int x = i;
                int z = 0;
                int c = 0;


                while (x > 0)
                {
                    int digit = x % 10;
                    z += digit;
                    c = digit;
                    x /= 10;

                    
                }

                result.AppendLine($"Для числа {i}: Первая цифра -  {c}, Сумма цифр -  {z}\n");
                
            }
            MessageBox.Show(result.ToString());
        }
    }
}
