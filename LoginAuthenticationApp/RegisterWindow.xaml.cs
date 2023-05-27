using LoginAuthenticationApp.Http;
using Microsoft.Win32;
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

namespace LoginAuthenticationApp
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        #region Placeholders

        private void fullname_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Full Name")
            {
                textBox.Text = "";
                textBox.Foreground = Brushes.White;
            }
        }

        private void fullname_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "")
            {
                textBox.Text = "Full Name";
                textBox.Foreground = Brushes.Gray;
            }
        }

        private void username_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Username")
            {
                textBox.Text = "";
                textBox.Foreground = Brushes.White;
            }
        }

        private void username_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "")
            {
                textBox.Text = "Username";
                textBox.Foreground = Brushes.Gray;
            }
        }

        private void email_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Email")
            {
                textBox.Text = "";
                textBox.Foreground = Brushes.White;
            }
        }

        private void email_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "")
            {
                textBox.Text = "Email";
                textBox.Foreground = Brushes.Gray;
            }
        }

        private void password_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = (PasswordBox)sender;
            
            if (passwordBox.Password == "Password")
            {
                passwordBox.Password = "";
                passwordBox.Foreground = Brushes.White;
            }
        }

        private void password_LostFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = (PasswordBox)sender;
            if (passwordBox.Password == "")
            {
                passwordBox.Password = "Password";
                passwordBox.Foreground = Brushes.Gray;
            }
        }

        #endregion

        private async void RegisterBTN(object sender, RoutedEventArgs e)
        {
            if (fullname.Text == "Full Name" || username.Text == "Username" || email.Text == "Email" || password.Password == "Password")
            {
                MessageBox.Show("Please fill out the form.", caption: "Login Authentication App - Register");
                return;
            }

            bool verifyUserInfo = Verify.RegisterInfo(fullname.Text, username.Text, email.Text, password.Password);
            if (!verifyUserInfo)
            {
                MessageBox.Show("Invalid Info. Please check your inputs", caption: "Login Authentication App - Register");
                return;
            }

            try
            {
                bool @register = await Send.Register(fullname.Text, username.Text, email.Text, password.Password);

                if (register)
                {
                    MessageBox.Show("Registration Successful!", caption: "Login Authentication App - Register", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registration Failed", caption: "Login Authentication App - Register", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration Failed, Error: {ex.Message}", caption: "Login Authentication App - Register", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LoginBTN(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
