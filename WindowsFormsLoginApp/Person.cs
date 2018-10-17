using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLoginApp
{
    public class Person
    {
        public int Id { get; private set; }
        public int Age { get; private set; }
        public String Name { get; private set; }
        public String Surname { get; private set; }
        public String Username { get; private set; }
        public String Password { get; private set; }

        public Person(int id, int age, string name, string surname, string username, string password)
        {
            Id = id;
            Age = age;
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
        }

        public override string ToString()
        {
            return $"PERSON Id={Id}, Age={Age}, Name={Name}, Surnme={Surname}";
        }
    }
}
