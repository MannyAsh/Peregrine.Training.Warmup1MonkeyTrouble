using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmup1MonkeyTrouble
{
    internal class Program
    {
        static void Main(string[] args) {

            Console.WriteLine(monkeyTrouble(true,true));
            Console.WriteLine(monkeyTrouble(false, false));
            Console.WriteLine(monkeyTrouble(true, false));
            Console.WriteLine(monkeyTrouble(false, true));
            Console.ReadLine();


        }

        static Boolean monkeyTrouble(Boolean aSmile, Boolean bSmile) {

            if (aSmile == true && bSmile == true || aSmile == false && bSmile == false)
            {

                return true;
            }

            else {

                return false;
            
            }

        
        }
    }
}
