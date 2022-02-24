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
    /// Interaction logic for BorrowPage.xaml
    /// </summary>
    public partial class BorrowPage : Window
    {
        public List<Book> myBook { get; set; }

        public List<Costumer> costumers { get; set; }
        public int day;
        public BorrowPage()
        {
            InitializeComponent();
            
            


            myBook = new List<Book>();

            Book book1 = new Book();
            book1.bookId = 1;
            book1.title = "kisfaszom";
            book1.loanable = 1;
            book1.max_loan_days = 10;
            book1.created_date = DateTime.Now.ToString("yyyy/MM/dd");
            book1.loan_expire = DateTime.Now.AddDays(day).ToString("yyyy/MM/dd");
            book1.barcode = "try123";
            book1.created_by = "Béla";

            Book book2 = new Book();
            book2.bookId = 2;
            book2.title = "ValamiamiNem Béla";
            book2.loanable = 1;
            book2.max_loan_days = 30;
            book2.created_date = DateTime.Now.ToString("yyyy/MM/dd");
            book2.loan_expire = DateTime.Now.AddDays(day).ToString("yyyy/MM/dd");
            book2.barcode = "try234";
            book2.created_by = "Józsi";

            myBook.Add(book1);
            myBook.Add(book2);


            

            costumers = new List<Costumer>();
            Costumer costumer1 = new Costumer();
            costumer1.costumerId = 1;
            costumer1.firstName = "Kiss";
            costumer1.lastName = "Pista";
            costumer1.costumerEmail = "csakegyjozsi@gmail.com";
            costumer1.costumerPhone = "06307528586";
            costumer1.costumerCity = "Szeged";
            costumer1.costumerCityStreet = "Hullám utca";
            costumer1.costumerStreetNumber = 2;
            

            Costumer costumer2 = new Costumer();
            costumer2.costumerId = 2;
            costumer2.firstName = "Tóth";
            costumer2.lastName = "Béla";
            costumer2.costumerEmail = "csakegybela@gmail.com";
            costumer2.costumerPhone = "07428458697";
            costumer1.costumerCity = "Szolnok";
            costumer1.costumerCityStreet = "Hunyadi János utca";
            costumer1.costumerStreetNumber = 3;

            costumers.Add(costumer1);
            costumers.Add(costumer2);

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
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

        private void Enter(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Return)
            {
                foreach (Book book in myBook)
                {
                     

                    if (book.barcode.Equals(Barcode.Text))
                    {
                      
                        DataGrid.Items.Add(book);
                        Barcode.Clear();
                    }

                }
            }
            
        }

        private void searchCos(object sender, RoutedEventArgs e)
        {
            
            foreach(Costumer costumer in costumers)
            {
                if ((Convert.ToInt32(userId.Text)) == costumer.costumerId)
                {
            
                    userName.Text = costumer.firstName +" "+ costumer.lastName;
                    userEmail.Text = costumer.costumerEmail;
                    userPhone.Text = costumer.costumerPhone;
                    userAddress.Text = costumer.costumerCity + " " +costumer.costumerCityStreet + " " + costumer.costumerStreetNumber;
                }
            }
        }

        private void userIdFocused(object sender, MouseButtonEventArgs e)
        {
            userId.SelectAll();
        }

       
    }
}
