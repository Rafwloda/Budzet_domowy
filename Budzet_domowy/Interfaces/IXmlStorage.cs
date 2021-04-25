using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Budzet_domowy.Interfaces
{
    interface IXmlStorage
    {
        public interface IXmlStorage
        {
            bool FromXml(Stream Stream);
            MemoryStream ToXml();
        }
    }
}
