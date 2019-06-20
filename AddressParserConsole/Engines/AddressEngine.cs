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
            if (nHouseNumber <= 2399 && nHouseNumber >= 2000)
            {
                return "15";
            }

            return "harwood section unknown";
        }

        internal string HandleASt(int nHouseNumber)
        {
            if (nHouseNumber <= 1499 && nHouseNumber >= 1300)
            {
                return "17";
            }
            if (nHouseNumber <= 1699 && nHouseNumber >= 1500)
            {
                return "9";
            }
            if (nHouseNumber <= 1899 && nHouseNumber >= 1700)
            {
                if (nHouseNumber % 2 == 0)
                {
                    return "5";

                }
                else
                {
                    return "11";
                }
            }
            if (nHouseNumber <= 1999 && nHouseNumber >= 1900)
            {
                if (nHouseNumber % 2 == 0)
                {
                    return "6";
                }
                else
                {
                    return "11";
                }
            }

            if (nHouseNumber <= 2199 && nHouseNumber >= 2000)
            {
                if (nHouseNumber % 2 == 0)
                {
                    return "6";
                }
                else
                {
                    return "10";
                }
            }
            if (nHouseNumber <= 2399 && nHouseNumber >= 2200)
            {
                if (nHouseNumber % 2 == 0)
                {
                    return "7";
                }
                else
                {
                    return "18";
                }
            }
            if (nHouseNumber <= 2499 && nHouseNumber >= 2400)
            {
                if (nHouseNumber % 2 == 0)
                {
                    return "7";
                }
                else
                {
                    return "12";
                }
            }
            if (nHouseNumber <= 2699 && nHouseNumber >= 2500)
            {
                return "12";
            }
        }

        internal string HandleBSt(int nHouseNumber)
        {
            if (nHouseNumber <= 1499 && nHouseNumber >= 1300)
            {
                return "17";
            }
            if (nHouseNumber <= 1699 && nHouseNumber >= 1500)
            {
                return "9";
            }
            if (nHouseNumber <= 1899 && nHouseNumber >= 1700)
            {
                return "5";
            }
            if (nHouseNumber <= 2199 && nHouseNumber >= 1900)
            {
                return "6";
            }
            if (nHouseNumber <= 2499 && nHouseNumber >= 2200)
            {
                return "6";
            }
            if (nHouseNumber <= 2699 && nHouseNumber >= 2500)
            {
                if (nHouseNumber % 2 == 0)
                {
                    return "8";
                }
                else
                {
                    return "12";
                }
            }
        }


        internal string HandleCSt(int nHouseNumber)
        {
            if (nHouseNumber <= 1499 && nHouseNumber >= 1300)
            {
                return "17";
            }
            if (nHouseNumber <= 1699 && nHouseNumber >= 1500)
            {
                return "9";
            }
            if (nHouseNumber <= 1899 && nHouseNumber >= 1700)
            {
                return "5";
            }
            if (nHouseNumber <= 2199 && nHouseNumber >= 1900)
            {
                return "6";
            }
            if (nHouseNumber <= 2499 && nHouseNumber >= 2200)
            {
                return "6";
            }
            if (nHouseNumber <= 2699 && nHouseNumber >= 2500)
            {
                return "8";

            }
        }

        internal string HandleDSt(int nHouseNumber)
        {
            if (nHouseNumber <= 1499 && nHouseNumber >= 1300)
            {
                if (nHouseNumber % 2 == 0)
                {
                    return "1";
                }
                else
                {
                    return "17";
                }
            }
            if (nHouseNumber <= 1599 && nHouseNumber >= 1500)
            {
                if (nHouseNumber % 2 == 0)
                {
                    return "1";
                }
                else
                {
                    return "9";
                }
            }
            if (nHouseNumber <= 1699 && nHouseNumber >= 1600)
            {
                if (nHouseNumber % 2 == 0)
                {
                    return "2";
                }
                else
                {
                    return "9";
                }
            }

            if (nHouseNumber <= 1899 && nHouseNumber >= 1700)
            {
                if (nHouseNumber % 2 == 0)
                {
                    return "2";

                }
                else
                {
                    return "5";
                }
            }
            if (nHouseNumber <= 2199 && nHouseNumber >= 1900)
            {
                if (nHouseNumber % 2 == 0)
                {
                    return "3";
                }
                else
                {
                    return "6";
                }
            }

            if (nHouseNumber <= 2499 && nHouseNumber >= 2200)
            {
                if (nHouseNumber % 2 == 0)
                {
                    return "4";
                }
                else
                {
                    return "7";
                }
            }

            if (nHouseNumber <= 2699 && nHouseNumber >= 2500)
            {
                return "8";
            }
        }

        internal string HandleESt(int nHouseNumber)
        {
            if (nHouseNumber <= 1599 && nHouseNumber >= 1300)
            {
                return "1";
            }
            if (nHouseNumber <= 1899 && nHouseNumber >= 1600)
            {
                return "2";
            }
            if (nHouseNumber <= 2199 && nHouseNumber >= 1900)
            {
                return "3";
            }
            if (nHouseNumber <= 2499 && nHouseNumber >= 2200)
            {
                return "4";
            }
            if (nHouseNumber <= 2699 && nHouseNumber >= 2500)
            {
                return "8";

            }
        }

        internal string HandleFSt(int nHouseNumber)
        {
            if (nHouseNumber <= 1599 && nHouseNumber >= 1300)
            {
                return "1";
            }
            if (nHouseNumber <= 1799 && nHouseNumber >= 1600)
            {
                return "2";
            }
            if (nHouseNumber <= 1899 && nHouseNumber >= 1800)
            {
                if (nHouseNumber % 2 == 0)
                {
                    return "3"
                }
                else
                {
                    return "2";
                }
            }
            if (nHouseNumber <= 2199 && nHouseNumber >= 1900)
            {
                return "3";
            }
            if (nHouseNumber <= 2499 && nHouseNumber >= 2200)
            {
                return "4";
            }
            if (nHouseNumber <= 2699 && nHouseNumber >= 2500)
            {
                return "8";
            }
        }

        internal string HandleGSt(int nHouseNumber)
        {
            if (nHouseNumber <= 1599 && nHouseNumber >= 1300)
            {
                return "1";
            }
            if (nHouseNumber <= 1799 && nHouseNumber >= 1600)
            {
                return "2";
            }

            if (nHouseNumber <= 2199 && nHouseNumber >= 1800)
            {
                return "3";
            }
            if (nHouseNumber <= 2499 && nHouseNumber >= 2200)
            {
                return "4";
            }
            if (nHouseNumber <= 2699 && nHouseNumber >= 2500)
            {
                return "8";
            }
        }

        internal string HandleRandolph(int nHouseNumber)
        {
            return "4"; //this one is weird, the entire street seems to be in this section
        }

        internal string HandleCapital(int nHouseNumber)
        {
            if (nHouseNumber < 999)
            {
                return "4"; //only two houses on this street...
            }
            else
            {
                return "8";
            }
        }

        internal string Handle13th(int nHouseNumber)
        {


        }

        internal string Handle14th(int nHouseNumber)
        {


        }

        internal string Handle15th(int nHouseNumber)
        {


        }

        internal string Handle16th(int nHouseNumber)
        {


        }

        internal string Handle17th(int nHouseNumber)
        {


        }

        internal string Handle18th(int nHouseNumber)
        {


        }

        internal string Handle19th(int nHouseNumber)
        {


        }

        internal string Handle20th(int nHouseNumber)
        {


        }

        internal string Handle21st(int nHouseNumber)
        {


        }

        internal string Handle22nd(int nHouseNumber)
        {


        }

        internal string Handle23rd(int nHouseNumber)
        {


        }

        internal string HandleLosGros(int nHouseNumber)
        {


        }

        internal string Handle24th(int nHouseNumber)
        {


        }

        internal string Handle25th(int nHouseNumber)
        {


        }

        internal string Handle26th(int nHouseNumber)
        {


        }

        internal string HandlePepper(int nHouseNumber)
        {


        }

        internal string Handle27th(int nHouseNumber)
        {


        }
    }
}
