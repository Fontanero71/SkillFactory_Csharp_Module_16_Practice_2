using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_Csharp_Module_16_Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = new Calculator();
            Console.WriteLine(result.Division(88, 11));
            Console.ReadKey();
        }
    }
}
