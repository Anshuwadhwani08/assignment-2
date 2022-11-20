using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Program
    {
        public int findLength(string str)
        {
            int len = str.Length;
            return len;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a string : ");
            string str = Console.ReadLine();
            Program program = new Program();
            int len = program.findLength(str);
            Console.WriteLine("Length of the string is : " + len);
            Console.ReadKey();


        }
    }
}
