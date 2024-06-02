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
       
        public void method_Syntax()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = list.Select(n => n%2==0 ? "even" : "Odd");  // return true and false 

            foreach (var s in result)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine("-----------------------Method syntax -------------------------");
            var MethodSyntax = list.Where(obj => obj%2==0);
            foreach (var s in MethodSyntax)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("-----------------------Max syntax -------------------------");
            var _Max = (from obj in list
                        select obj).Max();

            Console.WriteLine(_Max);


            Console.WriteLine("-----------------------Query syntax -------------------------");


            var query = from obj in list // store item in a object file 
                        where obj % 2 == 0 // condition 
                        select obj;

            foreach (var s in query)
            {
                Console.WriteLine(s); // print the values 
            }

        }



    }
}
