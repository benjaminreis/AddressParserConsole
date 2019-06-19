using System;
namespace AddressParserConsole.Engines
{
    internal class AddressEngine
    {
        internal AddressEngine()
        {
        }


        internal string HandleSouthSt(int nHouseNumber)
        {
            if (nHouseNumber <= 1499 && nHouseNumber >= 1300)
            {
                return "19";
            }
            if (nHouseNumber <= 1699 && nHouseNumber >= 1500)
            {
                return "13";
            }
            if (nHouseNumber <= 1999 && nHouseNumber >= 1700)
            {
                return "14";
            }
            if (nHouseNumber <= 2399 && nHouseNumber >= 2000)
            {
                return "15";
            }
            if (nHouseNumber <= 2699 && nHouseNumber >= 2400)
            {
                return "16";
            }
        }

        internal string HandleFranklinSt(int nHouseNumber)
        {
            if (nHouseNumber <= 2399 && nHouseNumber >= 2200)
            {
                return "15";
            }
            if (nHouseNumber <= 2699 && nHouseNumber >= 2400)
            {
                return "16";
            }
        }

        internal string HandleEuclidSt(int nHouseNumber)
        {
            if (nHouseNumber <= 2399 && nHouseNumber >= 2000)
            {
                return "15";
            }
            if (nHouseNumber <= 1999 && nHouseNumber >= 1700)
            {
                return "14";
            }
            if (nHouseNumber <= 1699 && nHouseNumber >= 1600)
            {
                return "13";
            }
        }

        internal string HandlePlumSt(int nHouseNumber)
        {
            if (nHouseNumber <= 1499 && nHouseNumber >= 1300)
            {
                return "19";
            }

        }

        internal string HandlePeachSt(int nHouseNumber)
        {
            if (nHouseNumber <= 1499 && nHouseNumber >= 1300)
            {
                return "19";
            }
        }

        internal string HandleRoseSt(int nHouseNumber)
        {
            if (nHouseNumber <= 1499 && nHouseNumber >= 1300)
            {
                return "19";
            }
            if (nHouseNumber <= 1599 && nHouseNumber >= 1600)
            {
                return "13";
            }

        }

        internal string HandleProspectSt(int nHouseNumber)
        {
            if (nHouseNumber <= 1699 && nHouseNumber >= 1600)
            {
                return "13";
            }
            if (nHouseNumber <= 1999 && nHouseNumber >= 1700)
            {
                return "14";
            }

        }

        internal string HandleSumnerSt(int nHouseNumber)
        {
            if (nHouseNumber <= 1499 && nHouseNumber >= 1300)
            {
                return "19";
            }
            if (nHouseNumber <= 1699 && nHouseNumber >= 1500)
            {
                return "13";
            }
            if (nHouseNumber <= 1999 && nHouseNumber >= 1700)
            {
                if (nHouseNumber % 2 == 0)
                {
                    return "11";
                }
                else
                {
                    return "14";
                }
            }
            if (nHouseNumber <= 2199 && nHouseNumber >= 2000)
            {
                if (nHouseNumber % 2 == 0)
                {
                    return "10";
                }
                else
                {
                    return "15";
                }

            }
            if (nHouseNumber <= 2399 && nHouseNumber >= 2200)
            {
                if (nHouseNumber % 2 == 0)
                {
                    return "18";
                }
                else
                {
                    return "15";
                }
            }
            if (nHouseNumber <= 2499 && nHouseNumber >= 2400)
            {
                if (nHouseNumber % 2 == 0)
                {
                    return "18";
                }
                else
                {
                    return "16";
                }
            }
            if (nHouseNumber <= 2699 && nHouseNumber >= 2500)
            { 
                if (nHouseNumber % 2 == 0)
                {
                    return "12";
                }
                else
                {
                    return "16";
                }
            }

        }

        internal string HandleGarfieldSt(int nHouseNumber)
        {
            if (nHouseNumber <= 1499 && nHouseNumber >= 1300)
            {
                if (nHouseNumber % 2 == 0)
                {
                    return "17";
                }
                else
                {
                    return "19";
                }

            }
            if (nHouseNumber <= 1699 && nHouseNumber >= 1500)
            {
                if (nHouseNumber % 2 == 0)
                {
                    return "9";
                }
                else
                {
                    return "13";
                }
            }
            if (nHouseNumber <= 1999 && nHouseNumber >= 1700)
            {
                return "11";
            }
            if (nHouseNumber <= 2199 && nHouseNumber >= 2000)
            {
                return "10";
            }
            if (nHouseNumber <= 2499 && nHouseNumber >= 2200)
            {
                return "18";
            }
            if (nHouseNumber <= 2699 && nHouseNumber >= 2500)
            {
                return "12";
            }
        }

        internal string HandleEverettSt(int nHouseNumber)
        {
            if (nHouseNumber <= 2699 && nHouseNumber >= 2500)
            {
                return "12";
            }
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

        internal string HandleASt(int nHouseNumber)
        {

        }

        internal string HandleBSt(int nHouseNumber)
        {

        }


        internal string HandleCSt(int nHouseNumber)
        {

        }

        internal string HandleDSt(int nHouseNumber)
        {

        }

        internal string HandleESt(int nHouseNumber)
        {

        }

        internal string HandleFSt(int nHouseNumber)
        {

        }

        internal string HandleGSt(int nHouseNumber)
        {

        }

        internal string HandleRandolph(int nHouseNumber)
        {

        }

        internal string HandleCapital(int nHouseNumber)
        {

        }
    }
}
