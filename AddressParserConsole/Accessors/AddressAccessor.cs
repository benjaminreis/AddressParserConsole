using System;
using System.Collections.Generic;

namespace AddressParserConsole.Accessors
{
    public class AddressAccessor
    {
        public AddressAccessor()
        {
        }

        internal List<Models.AddressModel> GetAddresses()
        {

            List<Models.AddressModel> Addresses = new List<Models.AddressModel>();

            Addresses.Add(new Models.AddressModel() { HouseNumber = "1441", nHouseNumber = 1441, StreetName = "Washington" });

            Addresses.Add(new Models.AddressModel() { HouseNumber = "1984", nHouseNumber=1984, StreetName = "Harwood" });
            Addresses.Add(new Models.AddressModel() { HouseNumber = "1902", nHouseNumber = 1902, StreetName = "Harwood" });

            Addresses.Add(new Models.AddressModel() { HouseNumber = "1511", nHouseNumber=1511, StreetName = "Washington" });


            return Addresses;


        }





        

    }
}
