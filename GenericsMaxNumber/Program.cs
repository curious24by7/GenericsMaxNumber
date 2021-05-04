using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Max Number is ::");
            int Output = MaxNumCheck.MaxIntNum(10, 20, 30);
            Console.WriteLine(Output);
            Console.ReadKey();
        }
    }
}
