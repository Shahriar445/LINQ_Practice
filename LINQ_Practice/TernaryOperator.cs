using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace LINQ_Practice
{
    public  class TernaryOperator
    {
        public TernaryOperator()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = list.Select(n => n%2==0 ? "even" : "Odd");
            foreach (var s in result)
            {
                Console.WriteLine(s);
            }
        }
        public void simple_linq()
        {
            List<int> list = new List<int> { 12, 123, 13, 14, 15, 16, 17, 18, };

            var result = from obj in list // store item in a object file 
                         where obj % 2 == 0 // condition 
                         select obj;

            foreach (var s in result )
            {
                Console.WriteLine(s); // print the values 
            }
        }

    }
}
