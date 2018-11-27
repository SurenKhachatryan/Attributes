﻿using System;
using System.Reflection;

namespace MyAttributes
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

    class Program
    {
        static void Main(string[] args)
        {
            
            Type tp = typeof(Person);

            object[] obj = tp.GetCustomAttributes(false);

            foreach (MyAttribute item in obj)
            {
                Console.WriteLine($"Name {item.Name} \nAge {item.Age}");
            }

            MethodInfo method = tp.GetMethod("ChildhoodCharacter");

            obj = method.GetCustomAttributes(typeof(MyAttribute),false);

            foreach (MyAttribute item in obj)
            {
                Console.WriteLine($"Name {item.Name} \nAge {item.Age}");
            }

            Console.ReadKey();
        }
    }
}
