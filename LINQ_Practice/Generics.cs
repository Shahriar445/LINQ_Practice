using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    public class Generics<T>
    {
        private T _value;

        public Generics(T value)
        {
            _value = value;
        }
        public T? GetValue()
        {
            return _value;
        }
        public void SetValue(T value)
        {
            _value = value;
        }
    }
}
