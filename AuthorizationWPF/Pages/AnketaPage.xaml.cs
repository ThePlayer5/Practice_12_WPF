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

namespace AuthorizationWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для AnketaPage.xaml
    /// </summary>
    public partial class AnketaPage : Page
    {
        public AnketaPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Добро пожаловать, {LoginTb.Text}!");
        }
    }
}
