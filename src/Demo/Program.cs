using BanckClassLibrary;
using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Nombre");
            string customerName = Console.ReadLine();

            Console.WriteLine("Fecha de nacimiento : dia, mes, anio");
            int day   = Convert.ToInt32( Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Telefono y Direccion:");
            string phone      = Console.ReadLine();
            string address    = Console.ReadLine();

            Account myAccount = new Account(customerName, new DateTime(year, month, day),phone,address);
            


            Console.ReadKey();
        }
    }
}
