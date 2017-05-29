using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beasts;
using Menu;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            TopMenu menu = new TopMenu();

            BeastsZoo beasts = new BeastsZoo();
            DataSource dataSource = new DataSource();
            dataSource.GetBeasts( beasts );

            beasts.PrintAll();
            do
            {
                
            } while (menu.MakeChoice(beasts) != 0);



            Console.ReadKey();
        }
    }
}
