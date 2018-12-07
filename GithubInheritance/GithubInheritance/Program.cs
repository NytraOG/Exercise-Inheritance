using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace GithubInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                Person person = new Person(name, age);
                Child child = new Child(name, age);
                child.Introduce();
                child.Walk();
                person.Introduce();
                person.Walk();
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
