using System;
using System.Collections.Generic;

namespace AddressParserConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Managers.AddressManager AddressManager = new Managers.AddressManager();

            var temp = AddressManager.ProcessAddresses();

            foreach (var item in temp)
            {
                Console.WriteLine($"the address {item.nHouseNumber} {item.StreetName} is in section {item.Section}");
            }

        }
    }
}
