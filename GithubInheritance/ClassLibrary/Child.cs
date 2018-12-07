using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {
        }

        public override string Name { get; protected set; }

        public override int Age
        {
            get => age;
            protected set
            {
                try
                {
                    if (value > 15)
                    {
                        throw new ArgumentException("You don't seem to be child.");
                    }

                    age = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hey, my name is {Name}");
        }

        public override void Walk()
        {
            Console.WriteLine("I'm crawling because I am just a child");
        }
    }
}
