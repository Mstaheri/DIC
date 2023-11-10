using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIC
{
    public class KaveNegar : ISms
    {
        private readonly Translation _t;
        public KaveNegar(Translation t)
        {
            _t = t;
        }
        public void SendSms(string message)
        {
            
        }
    }
}
