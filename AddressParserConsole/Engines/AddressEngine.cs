using System;
namespace AddressParserConsole.Engines
{
    internal class AddressEngine
    {
        internal AddressEngine()
        {
        }


        internal string HandleWashingtonSt(int nHouseNumber)
        {
            if (nHouseNumber <= 1499 && nHouseNumber >= 1300)
            {
                return "17";
            }
            if (nHouseNumber <= 1699 && nHouseNumber >= 1500)
            {
                return "9";
            }
            if (nHouseNumber <= 1999 && nHouseNumber >= 1700)
            {
                return "11";
            }
            if (nHouseNumber <= 2199 && nHouseNumber >= 2000)
            {
                return "10";
            }
            if (nHouseNumber <= 2399 && nHouseNumber >= 2200)
            {
                return "18";
            }
            if (nHouseNumber <= 2499 && nHouseNumber >= 2400)
            {
                if (nHouseNumber % 2 == 0)
                {
                    return "12";
                }
                else
                {
                    return "18";
                }
            }
            if (nHouseNumber <= 2699 && nHouseNumber >= 2500)
            {
                return "12";
            }
            return "washington section unknown";
        }


        internal string HandleHarwood(int nHouseNumber)
        {

            if (nHouseNumber <= 1699 && nHouseNumber > -1600)
            {
                return "13";
            }
            if (nHouseNumber <= 1999 && nHouseNumber >= 1700)
            {
                return "14";
            }
            if (nHouseNumber < 2399 && nHouseNumber >= 2000)
            {
                return "15";
            }

            return "harwood section unknown";
        }
    }
}
