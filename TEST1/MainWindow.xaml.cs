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

namespace TEST1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void B_LEFT_Click(object sender, RoutedEventArgs e)
        {
            _lb1.Content = "Нажата левая кнопка";
        }
        private void B_RIGHT_Click(object sender, RoutedEventArgs e)
        {
            _lb1.Content = "Нажата правая кнопка";
        }
    }
}
