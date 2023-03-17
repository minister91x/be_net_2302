using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoban
{
    public class GenericClass<T>
    {
        private T genericField;

        public T genericProperty { get; set; }

        // Constructor
        public GenericClass(T val)
        {
            genericField = val;
        }

        public T genericMethod(T genericParameter)
        {
            T rtn = default(T);

            Console.WriteLine("Field type: {0}, value: {1}", typeof(T).ToString(), genericField);
            Console.WriteLine("Property type: {0}, value: {1}", typeof(T).ToString(), genericProperty);
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);

            Console.WriteLine("Return type: {0}", typeof(T).ToString());

            return rtn;
        }

    }

    public struct MyStruct<T>
    {
        public T val;
        public T genericMethod(T genericParameter)
        {
            T rtn = default(T);
            return rtn;

        }
    }
}
