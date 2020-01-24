using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO
{
    class Program
    {
        static void Main(string[] args)
        {
            var biblioteka = new Biblioteka();

            biblioteka.ListItems();
            var item = biblioteka.Wypozycz(1);

            Console.WriteLine("\n");

            if (item != null)
            {
                Console.WriteLine("Wypożyczone: " + item.ToString());
            }





            Console.WriteLine("\n");
            biblioteka.ListItems();
            Console.WriteLine("\n");
            item.Zwrot();


            biblioteka.ListItems();
        }
    }
}
