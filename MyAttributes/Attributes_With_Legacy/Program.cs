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
            /// typeof сканирует класс kicker и возврашяет весь инфомацию 
            /// о классе kicker и присваивает Type tp.
            Type tp = typeof(kicker);
            
            /// GetCustomAttributes возвращает массив атрибутов принадлежащий классу
            /// MyAttribute катотые писваиваны к классам kicker и Person.
            /// True означает что typeof возвраяет инфрмацию не только о kicker
            /// но и о других классов от кторых класс kicker наследовон,
            /// но True будет работать только тогда когда AllowMultiple присвоено True
            object[] obj = tp.GetCustomAttributes(typeof(MyAttribute), true);

            
            foreach (MyAttribute item in obj)
            {
                Console.WriteLine($"Name {item.Name} \nAge {item.Age}");
            }

            Console.ReadKey();
        }
    }
}
