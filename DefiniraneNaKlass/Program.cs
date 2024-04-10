using System.Reflection;

namespace DefiniraneNaKlass
{
    internal class Program
    {
        static void Main()
        {
             Person person = new Person();
            Person person1 = new Person();
            Person person2 = new Person();

            person.name = "Pesho";
            person.age = 20;
            person.Persons();

            person1.name = "Gosho";
            person1.age = 18;
            person1.Persons();

            person1.name = "Stamat";
            person1.age = 43;
            person1.Persons();
        }
    }
}
