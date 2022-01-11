using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public static class User//class static
    {
        //public int number;//değişken static olmadığı için tanımlamadı!
        //public void yazdir() //static olmayan metot kabul edilmez

        public static void topla(int number1, int number2)
        {
            Console.WriteLine("Toplam:"+(number1+number2));
        }
    }
}
