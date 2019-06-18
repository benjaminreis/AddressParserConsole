using System;
using System.Collections.Generic;

namespace AddressParserConsole.Managers
{
    public class AddressManager
    {
        public AddressManager()
        {
        }

        private Accessors.AddressAccessor _AddressAccessor = new Accessors.AddressAccessor();


        internal List<Models.AddressModel> ProcessAddresses()
        {
            var Addresses = _AddressAccessor.GetAddresses();



            foreach (Models.AddressModel address in Addresses)
            {
                #region "Washington"

                if (address.StreetName.Equals("washington", StringComparison.OrdinalIgnoreCase))
                {
                    if (address.nHouseNumber % 2 == 0 )
                    {
                        //
                    }

                    if (address.nHouseNumber <= 1499 && address.nHouseNumber >= 1300)
                    {
                        address.Section = "17";
                    }
                    if (address.nHouseNumber <= 1699 && address.nHouseNumber >= 1500)
                    {
                        address.Section = "9";
                    }
                    if (address.nHouseNumber <= 1999 && address.nHouseNumber >= 1700)
                    {
                        address.Section = "11";
                    }
                    if (address.nHouseNumber <= 2199 && address.nHouseNumber >= 2000)
                    {
                        address.Section = "10";
                    }
                    if ( address.nHouseNumber <= 2399 && address.nHouseNumber >= 2200)
                    {
                        address.Section = "18";
                    }
                    if (address.nHouseNumber <= 2499 && address.nHouseNumber >= 2400)
                    {
                        if (address.nHouseNumber % 2 == 0)
                        {
                            address.Section = "12";
                        }
                        else
                        {
                            address.Section = "18";
                        }
                    }
                    if (address.nHouseNumber <= 2699 && address.nHouseNumber >= 2500)
                    {
                        address.Section = "12";
                    }

                }
                
                #endregion
                if (address.StreetName.Equals("harwood", StringComparison.OrdinalIgnoreCase))
                {
                    if (address.nHouseNumber <= 1999 && address.nHouseNumber >= 1700)
                    {
                        address.Section = "15";
                    }
                }

            }

            return Addresses;

        }
    }
}
