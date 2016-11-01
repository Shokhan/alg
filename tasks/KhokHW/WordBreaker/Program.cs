using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParser
{
    class Program
    {
        static void Main(string[] args)
        {
            FileParser d = new FileParser();
            string[] dictionary = d.GetWords();
            Console.WriteLine("Enter string.");
            string str = Console.ReadLine();
            WordDivider w = new WordDivider(str, dictionary);
            w.WordsBrake();
        }
    }
}
