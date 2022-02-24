using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWorm
{
    public class Costumer
    {
        public int costumerId { get; set; }
        public string firstName {get; set;}
        public string lastName { get; set; }
        public string costumerEmail { get; set; }
        public string costumerPhone { get; set; }
        public string costumerPostCode { get; set; }
        public string costumerCity { get; set; }
        public string costumerCityStreet { get; set; }
        public int costumerStreetNumber { get; set; }
        public DateTime costumerBirthDate { get; set; }

        public Costumer()
        {
        }

        public Costumer(int costumerId, string firstName, string lastName, string costumerEmail, string costumerPhone, string costumerPostCode, string costumerCity, string costumerCityStreet, int costumerStreetNumber, DateTime costumerBirthDate)
        {
            this.costumerId = costumerId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.costumerEmail = costumerEmail;
            this.costumerPhone = costumerPhone;
            this.costumerPostCode = costumerPostCode;
            this.costumerCity = costumerCity;
            this.costumerCityStreet = costumerCityStreet;
            this.costumerStreetNumber = costumerStreetNumber;
            this.costumerBirthDate = costumerBirthDate;
        }
    }
}
