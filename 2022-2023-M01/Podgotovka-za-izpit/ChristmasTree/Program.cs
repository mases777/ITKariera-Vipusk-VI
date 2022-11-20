using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.Write(new string('*', i));
                Console.Write(" | ");
                Console.WriteLine(new string('*', i));
            }



// n=11            
//          * | *
//         ** | **
//        *** | ***
//       **** | ****
//      ***** | *****
//     ****** | ******
//    ******* | *******
//   ******** | ********
//  ********* | *********
// ********** | **********
//*********** | ***********
        }
    }
}
