using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitalUI
{
    public class User
    {
        public string username { get; set; }
        private string password { get; set; }
        public float progress { get; set; }

        public User(string Uname, string PWord)
        {
            username = Uname;
            password = PWord;
            progress = 0;
        }
    }
}
