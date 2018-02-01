using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class Cloner
    {
        public T Clone<T>(T obj) where T: IClonable
        {
            return obj.Copy<T>();
        }
    }
}
