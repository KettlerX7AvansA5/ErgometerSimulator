using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgometerSimulator
{
    class CommandParser
    {
        private Random rand = new Random();
        private DataGenerator dg;

        public CommandParser(DataGenerator dg)
        {
            this.dg = dg;
        }

        public string Parse(string input)
        {
            string response = "";

            switch(input)
            {
                case "CM":
                case "RS":
                    response = "ACK";
                    break;
                case "ST":
                    response += dg.HeartBeat.currentvalue  + "\t"; //Heartbeat
                    response += dg.RPM.currentvalue   + "\t"; //RPM
                    response += dg.Speed.currentvalue  + "\t"; //Speed
                    response += dg.Distance.currentvalue + "\t"; //Distance
                    response += dg.Power.currentvalue  + "\t"; //Power
                    response += dg.Energy.currentvalue    + "\t"; //Energy
                    response += (dg.Time.currentvalue/60)   + ":" + (dg.Time.currentvalue%60) + "\t"; //Time
                    response += dg.ActualPower.currentvalue;         //ActualPower
                    break;
                default:
                    break;
            }

            return response;
        }
    }
}
