using System;

namespace MyAttributes
{
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
