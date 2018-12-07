using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual string Name
        {
            get => name;
            protected set => name = value;
        }

        public virtual int Age
        {
            get => age;
            protected set => age = value;
        }

        public void Introduce()
        {
            Console.WriteLine($"Heyo, my name is {name} and I am {age} years old.");
        }

        public void Walk()
        {
            Console.WriteLine("I am walking, because I'm grown-up.");
        }

    }
}
