using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIC
{
    public class MyDIC
    {
        public MyDIC()
        {

        }
        List<Type> types = new List<Type>();
        public void Add<T>()
        {
            types.Add(typeof(T));
        }
        public T Resolve<T> ()
        {
            object a;
            for (int i = 0; i < types.Count; i++)
            {
                if (typeof(T) == types[i])
                {
                    return (T)Activator.CreateInstance(types[i]);
                }

            }
            throw new Exception($"Add nashode in {typeof(T)} class");


        }
    }
}
