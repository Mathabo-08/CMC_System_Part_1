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

namespace CMC_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Buttons to navigate around the web app
        private void ICLecturerButton_Click(object sender, RoutedEventArgs e)
        {
            LoginAsLecturer loginWindow = new LoginAsLecturer();
            loginWindow.Show();
            this.Close(); // Optional: Close the current window if needed
        }
        private void ContractorButton_Click(object sender, RoutedEventArgs e)
        {
            LoginAsContractor loginWindow = new LoginAsContractor();
            loginWindow.Show();
            this.Close(); // Optional: Close the current window if needed
        }

    }
}
