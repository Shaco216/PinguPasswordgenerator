using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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


namespace PinguPasswordgenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] charactertypes { get; set; }
        private string alphabet = "abcdefghijklmnopqrstuvwxyz";
        private string ALPHABETH = "abcdefghijklmnopqrstuvwxyz".ToUpper();
        private string numbers = "0123456789";
        private string rest = "!$%&&/()=?{[]},.-;:_*-+";


        public MainWindow()
        {
            InitializeComponent();
            //https://www.youtube.com/watch?v=w8eqDakZekk
            charactertypes = new string[] { "only Lowercases", "Lower and Uppercases", "Lower+Uppercases and Numbers", "All Characters" };
            DataContext = this;
            this.Title = "PinguPasswordgenerator";
        }

        private void Dropdownmenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Create_Password_Click(object sender, RoutedEventArgs e)
        {
            
            //MessageBox.Show(CountofCharacters.Text);
            //label1.Content = 
            int lengthOfPassword = int.Parse(CountofCharacters.Text);
            //int lengthOfPassword = Convert.ToInt32(CountofCharacters.Text);
            Random rand = new Random();
            string passphrase = "";
            switch (Dropdownmenu.SelectedItem.ToString())
            {
                case "only Lowercases":
                    for(int i = 0; i < lengthOfPassword; i++)
                    {
                        string allChars = alphabet;
                        int number = rand.Next(0,allChars.Length);
                        passphrase = passphrase + allChars[number];
                    }
                    break;
                case "Lower and Uppercases":
                    for (int i = 0; i < lengthOfPassword; i++)
                    {
                        string allChars = alphabet + ALPHABETH;
                        int number = rand.Next(0, allChars.Length);
                        passphrase = passphrase + allChars[number];
                    }
                    break;
                case "Lower+Uppercases and Numbers":
                    for (int i = 0; i < lengthOfPassword; i++)
                    {
                        string allChars = alphabet + ALPHABETH + numbers;
                        int number = rand.Next(0, allChars.Length);
                        passphrase = passphrase + allChars[number];
                    }
                    break;
                case "All Characters":
                    for (int i = 0; i < lengthOfPassword; i++)
                    {
                        string allChars = alphabet + ALPHABETH + numbers + rest;
                        int number = rand.Next(0, allChars.Length);
                        passphrase = passphrase + allChars[number];
                    }
                    break;

                default:
                    break;
            }
            Password.Text = passphrase;
        }
        private void CountofCharacters_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //https://www.youtube.com/watch?v=uce4AMxkAjg
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void CountofCharacters_GotFocus(object sender, RoutedEventArgs e)
        {
            CountofCharacters.Clear();
            //MessageBox.Show("ja");
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetDataObject(Password.Text);
            //MessageBox.Show(Password.Text);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PasswordCreator_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
