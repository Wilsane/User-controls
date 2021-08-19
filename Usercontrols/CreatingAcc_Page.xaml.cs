using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for CreatingAcc_Page.xaml
    /// </summary>
    public partial class CreatingAcc_Page : UserControl
    {
        public CreatingAcc_Page()
        {
            InitializeComponent();
        }

        private void loadLogo_btn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            bool? response = fileDialog.ShowDialog();

            if (response == true)
            {
                string filepath = fileDialog.FileName;//To show the filepath in the textbox

                Stream stream = File.OpenRead(fileDialog.FileName);
                stream = File.OpenRead(fileDialog.FileName);
                byte[] binaryImage = new byte[stream.Length];
                stream.Read(binaryImage, 0, (int)stream.Length);
               // imgPhoto.Source = new BitmapImage(new Uri(fileDialog.FileName));//imgPhoto is the name of an image input

                //displaying the filepath in the textbox as confirmation 
                CompLogo_txt.Text = filepath;



            }
        }
    }
}
