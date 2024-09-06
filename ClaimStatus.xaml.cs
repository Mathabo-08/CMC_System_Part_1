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
using System.Windows.Shapes;

namespace CMC_System
{
    /// <summary>
    /// Interaction logic for ClaimStatus.xaml
    /// </summary>
    public partial class ClaimStatus : Window
    {
        public ClaimStatus()
        {
            InitializeComponent();
        }

        // Conditional form for payment of lecturer
        private void ClaimStatusTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        // Button to navigate to the mainwindow
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow homeWindow = new MainWindow();
            homeWindow.Show();
            this.Close();
        }
    }
}
