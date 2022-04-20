using System;
using System.Collections;

namespace Workshop
{
    class Program
    {
        public void Display()
        {
            string val1 = "abcd";
            string val2 = "dcba";
            char[] a=val1.ToCharArray();
            
            if (val1.Contains(val2))
            {
                Console.WriteLine("It's anagram");
            }
            else
            {
                Console.WriteLine("It's not anagram");
            }
        }
        static void Main(string[]args)
        {
            Program program = new Program();
            program.Display();
        }
    }
}