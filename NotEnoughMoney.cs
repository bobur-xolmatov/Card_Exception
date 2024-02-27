using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Exception
{
    public class NotEnoughMoney : Exception
    {
        public NotEnoughMoney(string message) : base(message)
        {
            
        }

    }
}
