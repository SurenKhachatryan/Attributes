using System;
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
            ///typeof сканирует класс Person и возврашяет весь инфомацию 
            ///о классе Person и присваивает Type tp.
            Type tp = typeof(Person);

            /// GetCustomAttributes возвращает массив атрибутов принадлежащий классу
            /// MyAttribute катотые писваиваны к классу Person.
            /// false означает что typeof возвращает информацию только о классе Person
            object[] obj = tp.GetCustomAttributes(false);

            foreach (MyAttribute item in obj)
            {
                Console.WriteLine($"Name {item.Name} \nAge {item.Age}");
            }

            /// GetMethod возврашяет инфомацию о методе
            /// ChildhoodCharacter и присваивает MethodInfo method.
            MethodInfo method = tp.GetMethod("ChildhoodCharacter");

            /// GetCustomAttributes возвращает массив атрибутов принадлежащий классу
            /// MyAttribute катотые писваиваны к методу ChildhoodCharacter.
            obj = method.GetCustomAttributes(typeof(MyAttribute),false);

            foreach (MyAttribute item in obj)
            {
                Console.WriteLine($"Name {item.Name} \nAge {item.Age}");
            }

            Console.ReadKey();
        }
    }
}
