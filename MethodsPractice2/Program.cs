using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Scope 
 *  class Program
    {
       static int lol = 0; 
 *    .... }
 * */
namespace MethodsPractice2
{
    class Program
    {
       static int lol = 0;  // makes this var avalible for all methods in the class 
        static void Main(string[] args)
        {
            Console.WriteLine(lol);
           
        }
    }
}
