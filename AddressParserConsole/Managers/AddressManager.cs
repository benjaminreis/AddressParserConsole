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
        private Engines.AddressEngine _AddressEngine = new Engines.AddressEngine();

        internal List<Models.AddressModel> ProcessAddresses()
        {
            var Addresses = _AddressAccessor.GetAddresses();



            foreach (Models.AddressModel address in Addresses)
            {
                #region "Washington"

                if (address.StreetName.Equals("washington", StringComparison.OrdinalIgnoreCase))
                {
                   address.Section = _AddressEngine.HandleWashingtonSt(address.nHouseNumber);
                }

                #endregion


                #region "harwood"

                if (address.StreetName.Equals("harwood", StringComparison.OrdinalIgnoreCase))
                {
                    address.Section = _AddressEngine.HandleHarwood(address.nHouseNumber);
                }




                #endregion

            }

            return Addresses;

        }
    }
}
