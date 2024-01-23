
using System;

namespace MySpace
{
    class Program
    {
        public static void Main(string[] args) {

           

            List<Person> persons = new List<Person>();
            persons.Add(new Person("Artyr", 16));
            persons.Add(new Person("Ostap", 36));
            persons.Add(new Person("Nazar", 29));
            persons.Add(new Person("Igor", 31));

            List<Person> persons2 = persons.FindAll((person) => person.Age < 30);

            persons2.ForEach((person) => Console.WriteLine(person.Name + " " + person.Age));

        }

    }
}