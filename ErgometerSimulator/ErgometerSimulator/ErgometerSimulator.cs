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

        public ErgometerSimulator()
        {
            InitializeComponent();
            comPort = new ComPort(this);
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
            string response = CommandParser.Parse(command);
            string display = command + " :_: " + response;
            Console.WriteLine(display);
            comPort.Write(response);
        }
    }
}
