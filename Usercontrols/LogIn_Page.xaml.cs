using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Front
{
    /// <summary>
    /// Interaction logic for LogIn_Page.xaml
    /// </summary>
    public partial class LogIn_Page : UserControl
    {
        public LogIn_Page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("you  are logged in");
        }

        private void forgotPass_rdb_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("you forgot your password");

        }

        private void createAcc_rdb_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("you creating account");

        }

    }
}
