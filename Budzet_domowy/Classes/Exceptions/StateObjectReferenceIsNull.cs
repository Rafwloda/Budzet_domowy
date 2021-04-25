using System;
using System.Collections.Generic;
using System.Text;

namespace Budzet_domowy.Classes.Exceptions
{
    public class StateObjectReferenceIsNull : Exception
    {
        public StateObjectReferenceIsNull() : base("Referencja do obiektu jest null!")
        {

        }
    }
}
