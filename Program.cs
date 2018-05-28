using System;
using System.Net;
using Newtonsoft.Json;

namespace StopFinderTest1
{
    static class Program
    {

        static void Main(string[ ] args)
        {

            try
            {
                var myClient = new WebClient();

                //
                //  This DownloadString could be passed in as an argument to the test application...
                //
                var myString = myClient.DownloadString("https://www.transportnsw.info/web/XML_STOPFINDER_REQUEST?TfNSWSF=true&language=en%20&name_sf=%E2%80%8Bstopname%E2%80%8B&outputFormat=rapidJSON&type_sf=any&version=10.2.2.48");

                //
                //  Convert the JSON to a classes list
                //
                myObjects myobject = JsonConvert.DeserializeObject<myObjects>(myString);
                
                //
                // Initilise variables to be used
                //
                bool bFound = false;
                bool bMultiple = false;

                //
                // Loop the list and test for expected results
                //
                foreach (var stop in myobject.locations)
                {

                    //
                    //  We are only interested in stops.
                    //
                    if (stop.type == "stop")
                    {

                        //
                        // In particular we're interested in Wynyard Station in Sydney  
                        // The following input values could be passed in as an argument to the test application...
                        //
                        if (stop.parent.type == "locality" && stop.parent.type == "Sydney")
                        {

                            if (stop.name.Contains("Wynyard Station") || stop.disassembledName.Contains("Wynyard Station"))
                            {
                                bFound = true;
                            }
                        }

                        //
                        //  Does this stop support multiple forms of transport?
                        //
                        if (stop.modes[0] > 1)
                        {
                            bMultiple = true;
                        }
                    }

                }

                //
                // Print appropriate message - this could be changed to output to a file or online log file.
                //
                if (bFound)
                {
                    Console.WriteLine("Wynyard Station, Sydney stop found");

                    if (bMultiple)
                    {
                        Console.WriteLine("...and it provides more than one mode of transport!!");
                    }
                    else
                    {
                        Console.WriteLine("...and it does not provide more than one mode of transport!!");
                    }
                }
                else
                {
                    Console.WriteLine("Wynyard Station, Sydney stop not found");

                    if (bMultiple)
                    {
                        Console.WriteLine("...but we found a stop that has more than one mode of transport!!");
                    }
                    else
                    {
                        Console.WriteLine("...and none of the stops that were found have more than one mode of transport!!");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception has occurred.  Check the source data!!.  Error Message: " + ex.Message);
            }
            
        }
    }
}
