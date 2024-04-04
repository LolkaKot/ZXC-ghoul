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
    /// Логика взаимодействия для Task20.xaml
    /// </summary>
    public partial class Task20 : Page
    {
        public Task20()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int N = random.Next(1, 100);
            List<int> result = new List<int>();

            for (int i = 10; i <= N; i++)
            {
                if (i % 2 != 0 && i % 5 == 0)
                {
                    result.Add(i);
                }
            }

            MessageBox.Show($"Нечетные кратные пяти числа: {string.Join(", ", result)}");
        }
    }
}
