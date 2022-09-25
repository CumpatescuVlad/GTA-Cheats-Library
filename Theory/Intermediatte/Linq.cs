using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediatte
{
    public class Linq
    {
        //Linq stands out for Language intergrated querry
        //Linq allows you to make querryes around data
        //in short terms allows you to selectivelly collect data
        //using IEnumerable<T> generic interface

        public void TestingLinq()
        {

            int[] numbers = {0,1,2,3,4,10,53,55,23,51,44,32,91};

            IEnumerable<int> nums =
                from num in numbers
                where num > 10 && num <= 80
                orderby num ascending
                select num;
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }  

        }




    }
}
