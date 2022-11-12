using System;

namespace Task_Access_Modi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Username daxil edin: ");
            string username = Console.ReadLine();
            Console.Write("Age daxil edin: ");
            byte age=Convert.ToByte(Console.ReadLine());
            Console.Write("Password daxil edin: ");
            string password = Console.ReadLine();

            User user = new User(username, age)
            {
                Password = password
            };

            Console.Write("Name daxil edin: ");
            string name = Console.ReadLine();
            Console.Write("Surname daxil edin: ");
            string surname = Console.ReadLine();
            Console.Write("Age daxil edin: ");
            byte age1 = Convert.ToByte(Console.ReadLine());
            Person person = new Person(name, age1)
            {
                Surname = surname
            };
        }

        
    }
}
