using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class Animal : IClonable
    {
        public string Name { get;  set;}

        public T Copy<T>()
        {
            return (T)this.MemberwiseClone();
        }
    }
}
