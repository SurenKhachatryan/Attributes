using System;

namespace Attributes_With_Legacy
{
    /// <summary>
    /// AttributeTargets.All говорит о том, что наш атрибут можно использовать везде с методомы , с переменноми и т.г.д.
    /// AllowMultiple = true говорит о том, что наш атрибут можно использовать много раз без ограничения 
    /// к примеру класс(и не только) может иметь 1 или 2 или боле атрибутов.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]

    
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
