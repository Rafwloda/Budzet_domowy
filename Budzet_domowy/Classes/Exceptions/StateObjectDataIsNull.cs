using System;
using System.Collections.Generic;
using System.Text;

namespace Budzet_domowy.Classes.Exceptions
{
    public class StateObjectDataIsNull : Exception
    {
        public StateObjectDataIsNull() : base("Referencja do danych jest null!")
        {
        }
    }
}
