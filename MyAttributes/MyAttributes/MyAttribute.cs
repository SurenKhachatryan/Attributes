using System;

namespace MyAttributes
{
    /// <summary>
    /// AttributeTargets.All говорит о том, что наш атрибут можно использовать везде с методомы , с переменноми и т.г.д.
    /// AllowMultiple = false говорит о том, что наш атрибут можно использовать 1 раз 
    /// к примеру класс(и не только) может иметь 1 атрибут.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]

    class MyAttribute : Attribute
    {
        private readonly string name;

        public MyAttribute(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }

        public int Age { get; set; }
    }
}
