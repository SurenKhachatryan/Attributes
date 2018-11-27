using System;

namespace Attributes_With_Legacy
{
    [My("Tomi", Age = 55)]
    class Person
    {
        [My("Tomi", Age = 18)]
        public void ChildhoodCharacter()
        {
            Console.WriteLine("Childhood Character");
        }
    }

    [My("Heno", Age = 28)]
    [My("Messi", Age = 31)]
    class kicker : Person
    {

    }

    class Program
    {
        static void Main(string[] args)
        {

            Type tp = typeof(kicker);

            object[] obj = tp.GetCustomAttributes(typeof(MyAttribute),true);

            foreach (MyAttribute item in obj)
            {
                Console.WriteLine($"Name {item.Name} \nAge {item.Age}");
            }

            Console.ReadKey();
        }
    }
}
