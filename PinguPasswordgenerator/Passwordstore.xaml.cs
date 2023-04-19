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

namespace PinguPasswordgenerator
{
    /// <summary>
    /// Interaktionslogik für Passwordstore.xaml
    /// </summary>
    public partial class Passwordstore : Window
    {
        public Passwordstore()
        {
            InitializeComponent();
            this.Title = "PinguPasswordStore";
        }

        private void SaveBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NameTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NameTB_GotFocus(object sender, RoutedEventArgs e)
        {
            NameTB.Clear();
        }

        private void EmailTB_GotFocus(object sender, RoutedEventArgs e)
        {
            EmailTB.Clear();
        }

        private void Username_GotFocus(object sender, RoutedEventArgs e)
        {
            Username.Clear();
        }

        private void PasswordTB_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordTB.Clear();
        }

        private void Window_GotFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
