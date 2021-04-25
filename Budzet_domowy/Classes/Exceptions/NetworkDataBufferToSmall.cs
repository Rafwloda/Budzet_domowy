using System;
using System.Collections.Generic;
using System.Text;

namespace Budzet_domowy.Classes.Exceptions
{
    public class NetworkDataBufferToSmall : Exception
    {
        public NetworkDataBufferToSmall(string a_sBufferName, int a_iBufferSize, int a_iDataSize) :
            base($"Bufor <{a_sBufferName}> zbyt maly! Rozmiar bufora = {a_iBufferSize}, rozmiar danych = {a_iDataSize}")
        {
        }
    }
}
