using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // User u1 = new User(); //static olduğu için nesne oluşturmaya izin vermiyor

            User.topla(15, 8);
            Console.ReadKey();

        }
    }
}
