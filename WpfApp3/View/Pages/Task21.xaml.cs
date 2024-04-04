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
    /// Логика взаимодействия для Task21.xaml
    /// </summary>
    public partial class Task21 : Page
    {
        public Task21()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 11; i <= 99; i++)
            {
                int X = i * i;
                result.Append($"Квадрат числа {i}: {X}");
            }

            MessageBox.Show(result.ToString());
        }
    }
}
