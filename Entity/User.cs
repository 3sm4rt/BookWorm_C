using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWorm
{
    public class User
    {
        public int userId { get; set; }
        public int userTitleId { get; set; }
        public string title { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public User()
        {
        }

        public User(int userId, int userTitleId, string title, string username, string email, string password)
        {
            this.userId = userId;
            this.userTitleId = userTitleId;
            this.title = title;
            this.username = username;
            this.email = email;
            this.password = password;
        }
    }
}
