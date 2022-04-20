using System;
using System.Collections;

namespace Workshop
{
    class Program
    {
        public bool Display(string val1,string val2)
        {
            if(val1.Length!=val2.Length)
            {
                return false;
            }          
            
            char[] a=val1.ToLower().ToCharArray();
            char[] b=val2.ToLower().ToCharArray();
            Array.Sort(a);
            Array.Sort(b);
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i].ToString() != b[i].ToString())
                {
                    return false;
                }                
            }
            return true;           
        }
        static void Main(string[]args)
        {
            Program program = new Program();
            Console.WriteLine("enter the val1:");
            string val1 = Console.ReadLine();
            Console.WriteLine("enter the val2 :");
            string val2 = Console.ReadLine();            
            if (program.Display(val1, val2) == true)
            {
                Console.WriteLine("It's anagram");
            }
            else
            {
                Console.WriteLine("It's not anagram");
            }
        }
    }
}