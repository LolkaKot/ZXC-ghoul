﻿using System;
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
    /// Логика взаимодействия для Task13.xaml
    /// </summary>
    public partial class Task13 : Page
    {
        public Task13()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double x = random.NextDouble() * 10;
            int n = random.Next(1, 30);

            double result = 0;

            for (int i = 0; i <= n; i++)
            {
                result = Math.Pow(-1, i) * (Math.Pow(x, 2 * i) / (2 * i));
            }

            MessageBox.Show("результат: " + result);
        }
    }
}
