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
using System.Windows.Shapes;

namespace CMC_System
{
    /// <summary>
    /// Interaction logic for LoginAsLecturer.xaml
    /// </summary>
    public partial class LoginAsLecturer : Window
    {
        public LoginAsLecturer()
        {
            InitializeComponent();
        }

        // Button to navigate on the web app
        public void HomeButton_Click(object sender, RoutedEventArgs e) 
        {
            MainWindow homeWindow = new MainWindow();
            homeWindow.Show();
            this.Close();
        }
    }
}
