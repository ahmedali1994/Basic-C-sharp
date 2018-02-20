using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you name");
            string Userinpt = Console.ReadLine();
            Userinpt = Userinpt.ToUpper();
            char[] inputtochar = Userinpt.ToCharArray();
            Array.Reverse(inputtochar);
            string Reverse = new string(inputtochar);
            


            foreach (char A in Reverse )
            {
                Console.Write("{0} ", A);


                
            }
            Console.ReadKey();
            








        }
        
    }
}
