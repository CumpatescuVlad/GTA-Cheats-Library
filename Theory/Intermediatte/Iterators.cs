using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediatte
{
    public class Iterators
    {
        //Iterators reffres to IEnumerale<T> generic interface 
        //You can define some members and iterate trough them with a freach loop 
        public  IEnumerable<int> ShowNumbers()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
            yield return 7;
            yield return 8;
            yield return 9;
            yield return 10;
            yield return 11;
            yield return 12;

        }

        public static void Execute()
        {
            Iterators iterate = new Iterators();

            foreach (var num in iterate.ShowNumbers())
            {
                Console.WriteLine(num);
            }
        }



    }
}
