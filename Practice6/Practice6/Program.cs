using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace practicework5
{
    class programm
    {
        public static void Main(string[] args)
        {
          
            int a = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            int c = 1;
            while (k != n)
            {
                k = k + 1;
                c = Convert.ToInt32(Math.Pow(c, a));
                Console.WriteLine(c);
            }
           



        }
    }


}


