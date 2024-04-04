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
    /// Логика взаимодействия для Task2.xaml
    /// </summary>
    public partial class Task2 : Page
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int b = random.Next(1, 30);
            int a = random.Next(1, 30);
            if (a < b)
            {
                int z = b - a;
                Console.WriteLine("Их кол-во: " + z);
                for (int i = z - 1; i > 0; i--)
                {
                    MessageBox.Show((a + i) + " ");
                }
            }
            else
            {
                MessageBox.Show("A > B");
            }
        }
    }
}
