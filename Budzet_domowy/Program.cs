using System;
using System.IO;
using System.Text;
using Budzet_domowy.Classes;
using Budzet_domowy.Classes.BuisnessLogic;

namespace Budzet_domowy
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlStorageTypes.Register<User>();

           
        }
    }
}
