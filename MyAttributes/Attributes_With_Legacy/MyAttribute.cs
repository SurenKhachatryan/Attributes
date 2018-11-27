using System;

namespace Attributes_With_Legacy
{
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
