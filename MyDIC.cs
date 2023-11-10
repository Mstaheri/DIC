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
        public T Resolve<T>()
        {
            return (T)Resolve(typeof(T));
        }
        bool flag = false;
        public object Resolve (Type interfaceType)
        {
            object a;
            for (int i = 0; i < types.Count; i++)
            {
                if (interfaceType == types[i])
                {
                    flag = true;
                    break;
                }
            }
            if (flag == true)
            {
                var ctr = interfaceType.GetConstructors().First();
                var ctrParametr = ctr.GetParameters();

                if (!ctrParametr.Any())
                {
                    return Activator.CreateInstance(interfaceType);
                }
                else
                {
                    List<object> parametr = new List<object>();
                    foreach (var item in ctrParametr)
                    {
                        var c = item.ParameterType;
                        parametr.Add(Resolve(c));
                    }

                    return ctr.Invoke(parametr.ToArray());
                }
            }
            else
            {
                throw new Exception($"Add nashode in {interfaceType} class");
            }
            


        }
    }
}
