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
    /// Interaction logic for SubmitClaim.xaml
    /// </summary>
    public partial class SubmitClaim : Window
    {
        public SubmitClaim()
        {
            InitializeComponent();
        }

        // Button to navigate to the claim status window
        public void CliamStatusButton_Click(object sender, RoutedEventArgs e) 
        {
            ClaimStatus claimStatusWindow = new ClaimStatus();
            claimStatusWindow.Show();
            this.Close();
        }

    }
}
