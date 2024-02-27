using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Exception
{
    public class CardTypeNotMatch : Exception
    {
        public CardTypeNotMatch(string message) :base(message)
        {
            
        }

    }
}
