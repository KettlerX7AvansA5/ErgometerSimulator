using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErgometerSimulator
{
    public partial class ErgometerSimulator : Form
    {
        ComPort comPort;
        DataGenerator dg;
        CommandParser parser;

        public ErgometerSimulator()
        {
            InitializeComponent();
            comPort = new ComPort(this);
            dg = new DataGenerator();
            parser = new CommandParser(dg);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!comPort.IsOpen())
            {
                if (comPort.Connect(ComPortBox.Text))
                {
                    connectButton.Text = "Disconnect";
                    ComPortBox.Enabled = false;
                }
            }
            else
            {
                if (comPort.Disconnect())
                {
                    connectButton.Text = "Connect";
                    ComPortBox.Enabled = true;

                }
            }
        }

        public void ReceivedCommand(string command)
        {
            string response = parser.Parse(command);
            string display = command + " :_: " + response;
            Console.WriteLine(display);
            comPort.Write(response);
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            dg.Update();
        }

        private void setHeartBeat_Click(object sender, EventArgs e)
        {
            if(text1HeartBeat.Text != "" && text2HeartBeat.Text != "")
            {
                dg.HeartBeat = new ValueSetting(randomHeartBeat.Checked, int.Parse(text1HeartBeat.Text), int.Parse(text2HeartBeat.Text));
            }
        }

        private void setRPM_Click(object sender, EventArgs e)
        {
            if (text1RPM.Text != "" && text2RPM.Text != "")
            {
                dg.RPM = new ValueSetting(randomRPM.Checked, int.Parse(text1RPM.Text), int.Parse(text2RPM.Text));
            }
        }

        private void setSpeed_Click(object sender, EventArgs e)
        {
            if (text1Speed.Text != "" && text2Speed.Text != "")
            {
                dg.Speed = new ValueSetting(randomSpeed.Checked, int.Parse(text1Speed.Text), int.Parse(text2Speed.Text));
            }
        }

        private void setDistance_Click(object sender, EventArgs e)
        {
            if (text1Distance.Text != "" && text2Distance.Text != "")
            {
                dg.Distance = new ValueSetting(randomDistance.Checked, int.Parse(text1Distance.Text), int.Parse(text2Distance.Text));
            }
        }

        private void setPower_Click(object sender, EventArgs e)
        {
            if (text1Power.Text != "" && text2Power.Text != "")
            {
                dg.Power = new ValueSetting(randomPower.Checked, int.Parse(text1Power.Text), int.Parse(text2Power.Text));
            }
        }

        private void setEnergy_Click(object sender, EventArgs e)
        {
            if (text1Energy.Text != "" && text2Energy.Text != "")
            {
                dg.Energy = new ValueSetting(randomEnergy.Checked, int.Parse(text1Energy.Text), int.Parse(text2Energy.Text));
            }
        }

        private void setActualPower_Click(object sender, EventArgs e)
        {
            if (text1ActualPower.Text != "" && text2ActualPower.Text != "")
            {
                dg.ActualPower = new ValueSetting(randomActualPower.Checked, int.Parse(text1ActualPower.Text), int.Parse(text2ActualPower.Text));
            }
        }
    }
}
