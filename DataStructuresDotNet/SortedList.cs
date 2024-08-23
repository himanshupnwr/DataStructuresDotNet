using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresDotNet
{
    internal class SortedList
    {
        public void SortedListExample()
        {
            var people = new SortedList<string, Person>();

            people.Add("Marcin", new Person() { Name = "Marcin", Country = "USA" });
            people.Add("Andrew", new Person() { Name = "Andrew", Country = "Canada" });
            people.Add("Muller", new Person() { Name = "Muller", Country = "Germany" });
            people.Add("Fransesco", new Person() { Name = "Fransesco", Country = "Italy" });

            foreach (var item in people)
            {
                Console.WriteLine($"{item.Value.Name} {item.Value.Country}");
            }

            LinkedList<string> list = new LinkedList<string>(); 
        }
    }

    internal class Person
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
