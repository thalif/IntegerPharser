using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atoi;

namespace ParseStringToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            AtoiFunc Parser = new AtoiFunc();

            int Value = Parser.Parse("2147.48364");
            Console.WriteLine(Value.ToString());
            Console.ReadKey();
        }
    }
}
