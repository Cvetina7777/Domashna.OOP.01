using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DefiniraneNaKlass
{
    public class Person
    {
        public string name;
        public int age;
        public void Persons() 
        {
            Console.WriteLine($"Az sum {this.name} na {age} godini");
        }
    }
}
