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

namespace BookWorm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<User> users { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            users = new List<User>();

            User user1 = new User();
            user1.userId = 1;
            user1.userTitleId = 1;
            user1.title = "Admin";
            user1.username = "Admin";
            user1.email = "campElek@gmail.com";
            user1.password = "admin";

            User user2 = new User();
            user2.userId = 2;
            user2.userTitleId = 2;
            user2.title = "Könyvtáros";
            user2.username = "Konyvtaros";
            user2.email = "hozdvissza@gmail.com";
            user2.password = "konyvtar";

            User user3 = new User();
            user3.userId = 3;
            user3.userTitleId = 1;
            user3.title = "Admin";
            user3.username = "Adesz";
            user3.email = "nem@gmail.com";
            user3.password = "admin";


            users.Add(user1);
            users.Add(user2);
            users.Add(user3);

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if(txtPassword.Password != "" && txtUsername.Text != "")
            {
                foreach(User user in users)
                {
                    if(txtUsername.Text.Equals(user.username) && txtPassword.Password.Equals(user.password))
                    {
                        if(user.userTitleId == 1)
                        {
                            AdminPage adminPage = new AdminPage();
                            adminPage.Show();
                            this.Close();
                        }
                        else if (user.userTitleId == 2)
                        {
                            MenuWindow menu = new MenuWindow();
                            menu.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Valami gebasz van");
                        }
                    }
                }
            }
        }

        private void txt_Pass(object sender, RoutedEventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void CloseApp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Close();
            }
           catch(Exception ex)
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
    }
}
