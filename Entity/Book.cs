using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWorm
{
    public class Book
    {
        public int bookId { get; set; } 
        public string title { get; set; } 
        public int loanable { get; set; } 
        public int max_loan_days { get; set; } 
        public string barcode { get; set; } 
        public string created_date { get; set; } 
        public string loan_expire { get; set; }
        public string created_by { get; set; }


        public Book(int bookId, string title, int loanable, int max_loan_days, string barcode, string created_date, string loan_expire, string created_by)
        {
            this.bookId = bookId;
            this.title = title;
            this.loanable = loanable;
            this.max_loan_days = max_loan_days;
            this.barcode = barcode;
            this.created_date = created_date;
            this.loan_expire = loan_expire;
            this.created_by = created_by;
        }

        public Book()
        {
        }
    }
}
