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

namespace BookWorm
{
    /// <summary>
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        public AddUser()
        {
            InitializeComponent();
        }
        private void NavigateToMenu(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            menu.Show();
            this.Close();
        }

        private void CloseApp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Minimize(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Minimized;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void UserAddButtonClick(object sender, RoutedEventArgs e)
        {
            Costumer costumer = new Costumer();
            firstName.Text = costumer.firstName;

        }

 

        private void lastNameFocus(object sender, RoutedEventArgs e)
        {
            lastName.SelectAll();

        }

        private void emailFocus(object sender, RoutedEventArgs e)
        {
            userEmail.SelectAll();
        }

        private void postCodeFocus(object sender, RoutedEventArgs e)
        {
            postCode.SelectAll();
        }

        private void cityFocus(object sender, RoutedEventArgs e)
        {
            city.SelectAll();

        }

        private void streetFocus(object sender, RoutedEventArgs e)
        {
            street.SelectAll();
        }

        private void streeNumberFocus(object sender, RoutedEventArgs e)
        {
            streetNumber.SelectAll();
        }

        private void vezetekNevEvent(object sender, MouseButtonEventArgs e)
        {
            firstName.SelectAll();
        }
    }
}
