using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgometerSimulator
{
    class CommandParser
    {
        private static Random rand = new Random();

        public static string Parse(string input)
        {
            string response = "";

            switch(input)
            {
                case "CM":
                case "RS":
                    response = "ACK";
                    break;
                case "ST":
                    response += rand.Next(90, 140)  + "\t"; //Heartbeat
                    response += rand.Next(20, 40)   + "\t"; //RPM
                    response += rand.Next(50, 350)  + "\t"; //Speed
                    response += rand.Next(10, 999)  + "\t"; //Distance
                    response += rand.Next(25, 400)  + "\t"; //Power
                    response += rand.Next(5, 55)    + "\t"; //Energy
                    response += rand.Next(0, 24)    + ":" + rand.Next(0, 60) + "\t"; //Time
                    response += rand.Next(25, 400);         //ActualPower
                    break;
                default:
                    break;
            }

            return response;
        }
    }
}
