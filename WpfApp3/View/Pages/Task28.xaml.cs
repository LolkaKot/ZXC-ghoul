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
    /// Логика взаимодействия для Task28.xaml
    /// </summary>
    public partial class Task28 : Page
    {
        public Task28()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder result = new StringBuilder();
            int z = 0;
            for (int i = 22; i <= 88; i++)
            {
                z -= i * i;
                result.AppendLine($"{i} возведенный в квадрат {i * i}");
            }
            result.AppendLine($"\nРазность квадратов от 22 до 88: {z}");

            MessageBox.Show(result.ToString());
        }
    }
    
}