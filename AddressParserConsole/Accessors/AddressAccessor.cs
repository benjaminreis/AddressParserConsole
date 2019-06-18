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

            Addresses.Add(new Models.AddressModel() { HouseNumber = "1447", nHouseNumber = 1447, StreetName = "Washington" });

            Addresses.Add(new Models.AddressModel() { HouseNumber = "1980", nHouseNumber=1980, StreetName = "Harwood" });
            Addresses.Add(new Models.AddressModel() { HouseNumber = "1948", nHouseNumber = 1948, StreetName = "Harwood" });

            Addresses.Add(new Models.AddressModel() { HouseNumber = "1501", nHouseNumber=1501, StreetName = "Washington" });


            return Addresses;


        }





        

    }
}
