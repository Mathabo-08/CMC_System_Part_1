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
    /// Interaction logic for ClaimRespondPage.xaml
    /// </summary>
    public partial class ClaimRespondPage : Window
    {
        public ClaimRespondPage()
        {
            InitializeComponent();
        }

        // Buttons to navigate on web app
        public void HomeButton_Click(object sender, RoutedEventArgs e) 
        {
            MainWindow homeWindow = new MainWindow();
            homeWindow.Show();
            this.Close();
        }

        public void ContractorLogin_Click(object sender, RoutedEventArgs e) 
        {
            LoginAsContractor loginWindow = new LoginAsContractor();
            loginWindow.Show();
            this.Close(); 
        }
    }
    }

