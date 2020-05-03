using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            using (var db = new BookStoreDBContext())
            {
                Console.WriteLine(db.Game.Count());
            }
            Console.WriteLine("Hello");
            Console.ReadKey();
        }
    }
}
