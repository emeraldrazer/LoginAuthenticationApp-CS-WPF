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
using System.Net;
using LoginAuthenticationApp.Http;

namespace LoginAuthenticationApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //WebRequest.DefaultWebProxy = new WebProxy(Properties.Settings.Default.ProxyAddress);
            InitializeComponent();
        }

        private async void LoginBTN(object sender, RoutedEventArgs e)
        {
            if (username.Text == "Full Name" || password.Password == "Password")
            {
                MessageBox.Show("Please enter your credentials.", caption: "Login Authentication App", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }

            bool verifyUserInfo = Verify.LoginInfo(username.Text, password.Password);
            if (!verifyUserInfo)
            {
                MessageBox.Show("Invalid Credentials, Please check your inputs.", caption: "Login Authentication App", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            try
            {
                bool @login = await Send.Login(username.Text, password.Password);

                if (login)
                {
                    MessageBox.Show("Login Successful!", caption: "Login Authentication App", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Login Failed.", caption: "Login Authentication App", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login Failed: {ex.Message}", caption: "Login Authentication App", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RegisterBTN(object sender, RoutedEventArgs e)
        {
            username.Text = "Full Name";
            username.Foreground = Brushes.Gray;

            password.Password = "Password";
            password.Foreground = Brushes.Gray;

            this.Hide();
            new RegisterWindow().ShowDialog();
            this.Show();
        }

        #region Placeholders

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Username")
            {
                textBox.Text = "";
                textBox.Foreground = Brushes.White;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "")
            {
                textBox.Text = "Username";
                textBox.Foreground = Brushes.Gray;
            }
        }

        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = (PasswordBox)sender;
            if (passwordBox.Password == "Password")
            {
                passwordBox.Password = "";
                passwordBox.Foreground = Brushes.White;
            }
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = (PasswordBox)sender;
            if (passwordBox.Password == "")
            {
                passwordBox.Password = "Password";
                passwordBox.Foreground = Brushes.Gray;
            }
        }

        #endregion

    }
}
