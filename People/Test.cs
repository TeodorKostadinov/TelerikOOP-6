using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Test
    {
        static void Main(string[] args)
        {
            Person onePerson = new Person();
            onePerson.Name = "Ivan";
            Console.WriteLine(onePerson);
            onePerson.Age = 50;
            Console.WriteLine(onePerson);
        }
    }
}
