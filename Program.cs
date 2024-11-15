using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubTest
{
    internal class Program
    {

        private static string SayMyName(string name)
        {
            return name;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Github!! T");
            Console.WriteLine("Hello " + SayMyName("Tariq"));

            Console.ReadKey();
        }
    }
}

