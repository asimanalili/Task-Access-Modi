using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Access_Modi
{
    internal class User
    {
        public string Username { get; set; }
        private byte _age;
        public byte Age {
            get { 
                return _age;    
            }
            set {
                if (value<=0)
                {
                    Console.WriteLine("Yas 1den kicik ola bilmez!");
                }
                _age = value;

            } 
        }
        private string _password;
        public string Password {
            get {
                return _password;
            }
            set {
                if (String.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Password bow ola bilmez!");
                }
                else if (!value.Any(char.IsUpper))
                {
                    Console.WriteLine("Password uzunlugu 8 den kicik ola bilmez!");
                }
                else if (!value.Any(char.IsUpper))
                {
                    Console.WriteLine("En azi bir boyuk herf olmalidir!");
                }
                else if (!value.Any(char.IsLower))
                {
                    Console.WriteLine("En azi bir kicik herf olmalidir!");
                }
                else if (!value.Any(char.IsDigit))
                {
                    Console.WriteLine("En azi bir reqem olmalidir!");
                }

                _password = value;
            } 
        }

        public User(string username, byte age)
        {
            
            Username = username;
            Age = age;
        }
       
        
    }
}
