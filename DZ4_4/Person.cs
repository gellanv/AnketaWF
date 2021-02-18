using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4_4
{
    public class Person
    {
        public string surname { get; set; }
        public string name { get; set; }        
        public string phone { get; set; }
        public string email { get; set; }
        public string picture { get; set; }
        public  int number { get; set; }

        public static int count = 0;
        public Person(string _surname, string _name, string _phone, string _email)
        {
            surname = _surname;
            name = _name;
            phone = _phone;
            email = _email;
            count++;
            number = count;
            picture = "";
        }
        public Person(string _surname, string _name, string _phone, string _email, string _picture)
        {
            surname = _surname;
            name = _name;
            phone = _phone;
            email = _email;
            count++;
            number = count;
            picture = _picture;
        }

    }
}
