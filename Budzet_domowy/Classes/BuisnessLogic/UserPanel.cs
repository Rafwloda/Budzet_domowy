using System;
using System.Collections.Generic;
using System.Text;

namespace Budzet_domowy.Classes.BuisnessLogic
{
    public class UserPanel
    {
        public class NamedObject
        {
            public NamedObject(string name)
            {
                Name = name;
            }

            public string Name
            {
                get;
                set;
            }
        }
    }
}
