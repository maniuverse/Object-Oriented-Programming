using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialization => the process of crating an object for a class
            Vehicles v1 = new Vehicles();
            
                v1.Regno="TN 8567";
                v1.Liters=5;
                v1.Wheels=2;
                Console.WriteLine(v1.getfinalamount(5, 50)); 
                Console.ReadKey();
            
           
        }
    }
}
