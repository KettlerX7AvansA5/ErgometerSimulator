using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgometerSimulator
{
    class DataGenerator
    {
        Random rand;

        public ValueSetting HeartBeat { get; set; }
        public ValueSetting RPM { get; set; }
        public ValueSetting Speed { get; set; }
        public ValueSetting Distance { get; set; }
        public ValueSetting Power { get; set; }
        public ValueSetting Energy { get; set; }
        public ValueSetting ActualPower { get; set; }
        public ValueSetting Time { get; set; }

        public DataGenerator()
        {
            rand = new Random();
            HeartBeat = new ValueSetting(false, 0, 0);
            RPM = new ValueSetting(false, 0, 0);
            Speed = new ValueSetting(false, 0, 0);
            Distance = new ValueSetting(false, 0, 0);
            Power = new ValueSetting(false, 0, 0);
            Energy = new ValueSetting(false, 0, 0);
            ActualPower = new ValueSetting(false, 0, 0);
            Time = new ValueSetting(false, 0, 0);
        }

        

        public void Update()
        {
            //Hearbeat
            if(HeartBeat.random)
            {

            }
        }
    }
}
