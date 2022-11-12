using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Access_Modi
{
    internal class Person
    {
        private string _name;
        private string _surname;
        public string Name { get { return _name; } 
            set 
            {
                if (!(value[0].ToString() ==value[0].ToString().ToUpper()))
                {
                    Console.WriteLine("Name boyuk herfle baslamalidi!");
                    return;
                }
                if (value.Length<3 || value.Length>5)
                {
                    Console.WriteLine("Name uzunlugu 3den kicik ve 30 dan boyuk ola bilmez!");
                }
                
                _name = value;
            } 
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (!(value[0].ToString() == value[0].ToString().ToUpper()))
                {
                    Console.WriteLine("Name boyuk herfle baslamalidi!");
                    return;
                }
                if (value.Length < 3 || value.Length > 5)
                {
                    Console.WriteLine("Name uzunlugu 3den kicik ve 30 dan boyuk ola bilmez!");
                }

                _surname = value;
            }
        }

        public byte Age { get; set; }

        public Person(string name, byte age)
        {
            Name = name;
            Age = age;
        }
    }
}
