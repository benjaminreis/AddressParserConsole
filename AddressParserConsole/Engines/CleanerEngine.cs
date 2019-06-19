using System;
using System.Collections.Generic;

namespace AddressParserConsole.Engines
{
    internal class CleanerEngine
    {
        internal CleanerEngine()
        {
        }

        internal void CleanAddresses(ref List<Models.AddressModel> addresses)
        {
            foreach (Models.AddressModel address in addresses)
            {
                int nHouseNumber = new int();

                if (int.TryParse(address.HouseNumber.Trim(),out nHouseNumber))
                {
                    address.nHouseNumber =nHouseNumber

                } else
                {
                    address.nHouseNumber = -1;
                }
            }
        }


        private string CleanStreetName(string UncleanStreetName)
        {
            string CleanedStreetName = UncleanStreetName.Replace("st.", "");
            CleanedStreetName = CleanedStreetName.Replace("st", "");
            CleanedStreetName = CleanedStreetName.Replace("street", "");
            CleanedStreetName = CleanedStreetName.Replace("dr.", "");
            CleanedStreetName = CleanedStreetName.Replace("drive.", "");
            CleanedStreetName = CleanedStreetName.Replace("dr", "");
            return CleanedStreetName.Trim();
        }

        private string CleanHouseNumber(string UncleanHouseNumber)
        {
            string CleanedHouseNumber = "";
            CleanedHouseNumber = UncleanHouseNumber.Replace("th", "");
            CleanedHouseNumber = CleanedHouseNumber.Replace("st", "");
            CleanedHouseNumber = CleanedHouseNumber.Replace("nd", "");
            CleanedHouseNumber = CleanedHouseNumber.Replace("rd", "");




            return CleanedHouseNumber.Trim();
        }
    }
}
