using System.IO.Ports;

namespace ErgometerSimulator
{
    partial class ErgometerSimulator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.connectButton = new System.Windows.Forms.Button();
            this.ComPortBox = new System.Windows.Forms.ComboBox();
            this.labelHeartBeat = new System.Windows.Forms.Label();
            this.randomHeartBeat = new System.Windows.Forms.CheckBox();
            this.text1HeartBeat = new System.Windows.Forms.TextBox();
            this.text2HeartBeat = new System.Windows.Forms.TextBox();
            this.setHeartBeat = new System.Windows.Forms.Button();
            this.setRPM = new System.Windows.Forms.Button();
            this.text2RPM = new System.Windows.Forms.TextBox();
            this.text1RPM = new System.Windows.Forms.TextBox();
            this.randomRPM = new System.Windows.Forms.CheckBox();
            this.labelRPM = new System.Windows.Forms.Label();
            this.setSpeed = new System.Windows.Forms.Button();
            this.text2Speed = new System.Windows.Forms.TextBox();
            this.text1Speed = new System.Windows.Forms.TextBox();
            this.randomSpeed = new System.Windows.Forms.CheckBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.setDistance = new System.Windows.Forms.Button();
            this.text2Distance = new System.Windows.Forms.TextBox();
            this.text1Distance = new System.Windows.Forms.TextBox();
            this.randomDistance = new System.Windows.Forms.CheckBox();
            this.labelDistance = new System.Windows.Forms.Label();
            this.setPower = new System.Windows.Forms.Button();
            this.text2Power = new System.Windows.Forms.TextBox();
            this.text1Power = new System.Windows.Forms.TextBox();
            this.randomPower = new System.Windows.Forms.CheckBox();
            this.labelPower = new System.Windows.Forms.Label();
            this.setEnergy = new System.Windows.Forms.Button();
            this.text2Energy = new System.Windows.Forms.TextBox();
            this.text1Energy = new System.Windows.Forms.TextBox();
            this.randomEnergy = new System.Windows.Forms.CheckBox();
            this.labelEnergy = new System.Windows.Forms.Label();
            this.setActualPower = new System.Windows.Forms.Button();
            this.text2ActualPower = new System.Windows.Forms.TextBox();
            this.text1ActualPower = new System.Windows.Forms.TextBox();
            this.randomActualPower = new System.Windows.Forms.CheckBox();
            this.labelActualPower = new System.Windows.Forms.Label();
            this.setTime = new System.Windows.Forms.Button();
            this.text1Time = new System.Windows.Forms.TextBox();
            this.countTime = new System.Windows.Forms.CheckBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(151, 305);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(101, 27);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // ComPortBox
            // 
            this.ComPortBox.FormattingEnabled = true;
            this.ComPortBox.Items.AddRange(new object[] {
            "COM8",
            "COM9"});
            this.ComPortBox.Location = new System.Drawing.Point(15, 308);
            this.ComPortBox.Name = "ComPortBox";
            this.ComPortBox.Size = new System.Drawing.Size(121, 24);
            this.ComPortBox.TabIndex = 1;
            // 
            // labelHeartBeat
            // 
            this.labelHeartBeat.AutoSize = true;
            this.labelHeartBeat.Location = new System.Drawing.Point(12, 27);
            this.labelHeartBeat.Name = "labelHeartBeat";
            this.labelHeartBeat.Size = new System.Drawing.Size(71, 17);
            this.labelHeartBeat.TabIndex = 2;
            this.labelHeartBeat.Text = "Heartbeat";
            // 
            // randomHeartBeat
            // 
            this.randomHeartBeat.AutoSize = true;
            this.randomHeartBeat.Enabled = false;
            this.randomHeartBeat.Location = new System.Drawing.Point(114, 28);
            this.randomHeartBeat.Name = "randomHeartBeat";
            this.randomHeartBeat.Size = new System.Drawing.Size(18, 17);
            this.randomHeartBeat.TabIndex = 3;
            this.randomHeartBeat.UseVisualStyleBackColor = true;
            this.randomHeartBeat.CheckedChanged += new System.EventHandler(this.randomHeartBeat_CheckedChanged);
            // 
            // text1HeartBeat
            // 
            this.text1HeartBeat.Enabled = false;
            this.text1HeartBeat.Location = new System.Drawing.Point(151, 24);
            this.text1HeartBeat.Name = "text1HeartBeat";
            this.text1HeartBeat.Size = new System.Drawing.Size(100, 22);
            this.text1HeartBeat.TabIndex = 4;
            // 
            // text2HeartBeat
            // 
            this.text2HeartBeat.Enabled = false;
            this.text2HeartBeat.Location = new System.Drawing.Point(257, 24);
            this.text2HeartBeat.Name = "text2HeartBeat";
            this.text2HeartBeat.Size = new System.Drawing.Size(100, 22);
            this.text2HeartBeat.TabIndex = 5;
            // 
            // setHeartBeat
            // 
            this.setHeartBeat.Enabled = false;
            this.setHeartBeat.Location = new System.Drawing.Point(363, 24);
            this.setHeartBeat.Name = "setHeartBeat";
            this.setHeartBeat.Size = new System.Drawing.Size(75, 23);
            this.setHeartBeat.TabIndex = 6;
            this.setHeartBeat.Text = "Set";
            this.setHeartBeat.UseVisualStyleBackColor = true;
            this.setHeartBeat.Click += new System.EventHandler(this.setHeartBeat_Click);
            // 
            // setRPM
            // 
            this.setRPM.Enabled = false;
            this.setRPM.Location = new System.Drawing.Point(363, 50);
            this.setRPM.Name = "setRPM";
            this.setRPM.Size = new System.Drawing.Size(75, 23);
            this.setRPM.TabIndex = 11;
            this.setRPM.Text = "Set";
            this.setRPM.UseVisualStyleBackColor = true;
            this.setRPM.Click += new System.EventHandler(this.setRPM_Click);
            // 
            // text2RPM
            // 
            this.text2RPM.Enabled = false;
            this.text2RPM.Location = new System.Drawing.Point(257, 50);
            this.text2RPM.Name = "text2RPM";
            this.text2RPM.Size = new System.Drawing.Size(100, 22);
            this.text2RPM.TabIndex = 10;
            // 
            // text1RPM
            // 
            this.text1RPM.Enabled = false;
            this.text1RPM.Location = new System.Drawing.Point(151, 50);
            this.text1RPM.Name = "text1RPM";
            this.text1RPM.Size = new System.Drawing.Size(100, 22);
            this.text1RPM.TabIndex = 9;
            // 
            // randomRPM
            // 
            this.randomRPM.AutoSize = true;
            this.randomRPM.Enabled = false;
            this.randomRPM.Location = new System.Drawing.Point(114, 54);
            this.randomRPM.Name = "randomRPM";
            this.randomRPM.Size = new System.Drawing.Size(18, 17);
            this.randomRPM.TabIndex = 8;
            this.randomRPM.UseVisualStyleBackColor = true;
            this.randomRPM.CheckedChanged += new System.EventHandler(this.randomRPM_CheckedChanged);
            // 
            // labelRPM
            // 
            this.labelRPM.AutoSize = true;
            this.labelRPM.Location = new System.Drawing.Point(12, 53);
            this.labelRPM.Name = "labelRPM";
            this.labelRPM.Size = new System.Drawing.Size(38, 17);
            this.labelRPM.TabIndex = 7;
            this.labelRPM.Text = "RPM";
            // 
            // setSpeed
            // 
            this.setSpeed.Enabled = false;
            this.setSpeed.Location = new System.Drawing.Point(363, 78);
            this.setSpeed.Name = "setSpeed";
            this.setSpeed.Size = new System.Drawing.Size(75, 23);
            this.setSpeed.TabIndex = 16;
            this.setSpeed.Text = "Set";
            this.setSpeed.UseVisualStyleBackColor = true;
            this.setSpeed.Click += new System.EventHandler(this.setSpeed_Click);
            // 
            // text2Speed
            // 
            this.text2Speed.Enabled = false;
            this.text2Speed.Location = new System.Drawing.Point(257, 78);
            this.text2Speed.Name = "text2Speed";
            this.text2Speed.Size = new System.Drawing.Size(100, 22);
            this.text2Speed.TabIndex = 15;
            // 
            // text1Speed
            // 
            this.text1Speed.Enabled = false;
            this.text1Speed.Location = new System.Drawing.Point(151, 78);
            this.text1Speed.Name = "text1Speed";
            this.text1Speed.Size = new System.Drawing.Size(100, 22);
            this.text1Speed.TabIndex = 14;
            // 
            // randomSpeed
            // 
            this.randomSpeed.AutoSize = true;
            this.randomSpeed.Enabled = false;
            this.randomSpeed.Location = new System.Drawing.Point(114, 82);
            this.randomSpeed.Name = "randomSpeed";
            this.randomSpeed.Size = new System.Drawing.Size(18, 17);
            this.randomSpeed.TabIndex = 13;
            this.randomSpeed.UseVisualStyleBackColor = true;
            this.randomSpeed.CheckedChanged += new System.EventHandler(this.randomSpeed_CheckedChanged);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(12, 81);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(49, 17);
            this.labelSpeed.TabIndex = 12;
            this.labelSpeed.Text = "Speed";
            // 
            // setDistance
            // 
            this.setDistance.Enabled = false;
            this.setDistance.Location = new System.Drawing.Point(363, 108);
            this.setDistance.Name = "setDistance";
            this.setDistance.Size = new System.Drawing.Size(75, 23);
            this.setDistance.TabIndex = 21;
            this.setDistance.Text = "Set";
            this.setDistance.UseVisualStyleBackColor = true;
            this.setDistance.Click += new System.EventHandler(this.setDistance_Click);
            // 
            // text2Distance
            // 
            this.text2Distance.Enabled = false;
            this.text2Distance.Location = new System.Drawing.Point(257, 108);
            this.text2Distance.Name = "text2Distance";
            this.text2Distance.Size = new System.Drawing.Size(100, 22);
            this.text2Distance.TabIndex = 20;
            // 
            // text1Distance
            // 
            this.text1Distance.Enabled = false;
            this.text1Distance.Location = new System.Drawing.Point(151, 108);
            this.text1Distance.Name = "text1Distance";
            this.text1Distance.Size = new System.Drawing.Size(100, 22);
            this.text1Distance.TabIndex = 19;
            // 
            // randomDistance
            // 
            this.randomDistance.AutoSize = true;
            this.randomDistance.Enabled = false;
            this.randomDistance.Location = new System.Drawing.Point(114, 112);
            this.randomDistance.Name = "randomDistance";
            this.randomDistance.Size = new System.Drawing.Size(18, 17);
            this.randomDistance.TabIndex = 18;
            this.randomDistance.UseVisualStyleBackColor = true;
            this.randomDistance.CheckedChanged += new System.EventHandler(this.randomDistance_CheckedChanged);
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Location = new System.Drawing.Point(12, 111);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(63, 17);
            this.labelDistance.TabIndex = 17;
            this.labelDistance.Text = "Distance";
            // 
            // setPower
            // 
            this.setPower.Enabled = false;
            this.setPower.Location = new System.Drawing.Point(363, 137);
            this.setPower.Name = "setPower";
            this.setPower.Size = new System.Drawing.Size(75, 23);
            this.setPower.TabIndex = 26;
            this.setPower.Text = "Set";
            this.setPower.UseVisualStyleBackColor = true;
            this.setPower.Click += new System.EventHandler(this.setPower_Click);
            // 
            // text2Power
            // 
            this.text2Power.Enabled = false;
            this.text2Power.Location = new System.Drawing.Point(257, 137);
            this.text2Power.Name = "text2Power";
            this.text2Power.Size = new System.Drawing.Size(100, 22);
            this.text2Power.TabIndex = 25;
            // 
            // text1Power
            // 
            this.text1Power.Enabled = false;
            this.text1Power.Location = new System.Drawing.Point(151, 137);
            this.text1Power.Name = "text1Power";
            this.text1Power.Size = new System.Drawing.Size(100, 22);
            this.text1Power.TabIndex = 24;
            // 
            // randomPower
            // 
            this.randomPower.AutoSize = true;
            this.randomPower.Enabled = false;
            this.randomPower.Location = new System.Drawing.Point(114, 141);
            this.randomPower.Name = "randomPower";
            this.randomPower.Size = new System.Drawing.Size(18, 17);
            this.randomPower.TabIndex = 23;
            this.randomPower.UseVisualStyleBackColor = true;
            this.randomPower.CheckedChanged += new System.EventHandler(this.randomPower_CheckedChanged);
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Location = new System.Drawing.Point(12, 140);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(47, 17);
            this.labelPower.TabIndex = 22;
            this.labelPower.Text = "Power";
            // 
            // setEnergy
            // 
            this.setEnergy.Enabled = false;
            this.setEnergy.Location = new System.Drawing.Point(363, 166);
            this.setEnergy.Name = "setEnergy";
            this.setEnergy.Size = new System.Drawing.Size(75, 23);
            this.setEnergy.TabIndex = 31;
            this.setEnergy.Text = "Set";
            this.setEnergy.UseVisualStyleBackColor = true;
            this.setEnergy.Click += new System.EventHandler(this.setEnergy_Click);
            // 
            // text2Energy
            // 
            this.text2Energy.Enabled = false;
            this.text2Energy.Location = new System.Drawing.Point(257, 166);
            this.text2Energy.Name = "text2Energy";
            this.text2Energy.Size = new System.Drawing.Size(100, 22);
            this.text2Energy.TabIndex = 30;
            // 
            // text1Energy
            // 
            this.text1Energy.Enabled = false;
            this.text1Energy.Location = new System.Drawing.Point(151, 166);
            this.text1Energy.Name = "text1Energy";
            this.text1Energy.Size = new System.Drawing.Size(100, 22);
            this.text1Energy.TabIndex = 29;
            // 
            // randomEnergy
            // 
            this.randomEnergy.AutoSize = true;
            this.randomEnergy.Enabled = false;
            this.randomEnergy.Location = new System.Drawing.Point(114, 170);
            this.randomEnergy.Name = "randomEnergy";
            this.randomEnergy.Size = new System.Drawing.Size(18, 17);
            this.randomEnergy.TabIndex = 28;
            this.randomEnergy.UseVisualStyleBackColor = true;
            this.randomEnergy.CheckedChanged += new System.EventHandler(this.randomEnergy_CheckedChanged);
            // 
            // labelEnergy
            // 
            this.labelEnergy.AutoSize = true;
            this.labelEnergy.Location = new System.Drawing.Point(12, 169);
            this.labelEnergy.Name = "labelEnergy";
            this.labelEnergy.Size = new System.Drawing.Size(53, 17);
            this.labelEnergy.TabIndex = 27;
            this.labelEnergy.Text = "Energy";
            // 
            // setActualPower
            // 
            this.setActualPower.Enabled = false;
            this.setActualPower.Location = new System.Drawing.Point(363, 196);
            this.setActualPower.Name = "setActualPower";
            this.setActualPower.Size = new System.Drawing.Size(75, 23);
            this.setActualPower.TabIndex = 36;
            this.setActualPower.Text = "Set";
            this.setActualPower.UseVisualStyleBackColor = true;
            this.setActualPower.Click += new System.EventHandler(this.setActualPower_Click);
            // 
            // text2ActualPower
            // 
            this.text2ActualPower.Enabled = false;
            this.text2ActualPower.Location = new System.Drawing.Point(257, 196);
            this.text2ActualPower.Name = "text2ActualPower";
            this.text2ActualPower.Size = new System.Drawing.Size(100, 22);
            this.text2ActualPower.TabIndex = 35;
            // 
            // text1ActualPower
            // 
            this.text1ActualPower.Enabled = false;
            this.text1ActualPower.Location = new System.Drawing.Point(151, 196);
            this.text1ActualPower.Name = "text1ActualPower";
            this.text1ActualPower.Size = new System.Drawing.Size(100, 22);
            this.text1ActualPower.TabIndex = 34;
            // 
            // randomActualPower
            // 
            this.randomActualPower.AutoSize = true;
            this.randomActualPower.Enabled = false;
            this.randomActualPower.Location = new System.Drawing.Point(114, 200);
            this.randomActualPower.Name = "randomActualPower";
            this.randomActualPower.Size = new System.Drawing.Size(18, 17);
            this.randomActualPower.TabIndex = 33;
            this.randomActualPower.UseVisualStyleBackColor = true;
            this.randomActualPower.CheckedChanged += new System.EventHandler(this.randomActualPower_CheckedChanged);
            // 
            // labelActualPower
            // 
            this.labelActualPower.AutoSize = true;
            this.labelActualPower.Location = new System.Drawing.Point(12, 199);
            this.labelActualPower.Name = "labelActualPower";
            this.labelActualPower.Size = new System.Drawing.Size(90, 17);
            this.labelActualPower.TabIndex = 32;
            this.labelActualPower.Text = "Actual Power";
            // 
            // setTime
            // 
            this.setTime.Enabled = false;
            this.setTime.Location = new System.Drawing.Point(363, 262);
            this.setTime.Name = "setTime";
            this.setTime.Size = new System.Drawing.Size(75, 23);
            this.setTime.TabIndex = 41;
            this.setTime.Text = "Set";
            this.setTime.UseVisualStyleBackColor = true;
            this.setTime.Click += new System.EventHandler(this.setTime_Click);
            // 
            // text1Time
            // 
            this.text1Time.Enabled = false;
            this.text1Time.Location = new System.Drawing.Point(151, 262);
            this.text1Time.Name = "text1Time";
            this.text1Time.Size = new System.Drawing.Size(101, 22);
            this.text1Time.TabIndex = 39;
            // 
            // countTime
            // 
            this.countTime.AutoSize = true;
            this.countTime.Enabled = false;
            this.countTime.Location = new System.Drawing.Point(77, 263);
            this.countTime.Name = "countTime";
            this.countTime.Size = new System.Drawing.Size(65, 21);
            this.countTime.TabIndex = 38;
            this.countTime.Text = "Down";
            this.countTime.UseVisualStyleBackColor = true;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(12, 265);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(39, 17);
            this.labelTime.TabIndex = 37;
            this.labelTime.Text = "Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(75, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "Random";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(148, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "Min";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(254, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = "Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Name";
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.Location = new System.Drawing.Point(258, 264);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(44, 17);
            this.labelCurrentTime.TabIndex = 49;
            this.labelCurrentTime.Text = "00:00";
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 200;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // ErgometerSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 344);
            this.Controls.Add(this.labelCurrentTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.setTime);
            this.Controls.Add(this.text1Time);
            this.Controls.Add(this.countTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.setActualPower);
            this.Controls.Add(this.text2ActualPower);
            this.Controls.Add(this.text1ActualPower);
            this.Controls.Add(this.randomActualPower);
            this.Controls.Add(this.labelActualPower);
            this.Controls.Add(this.setEnergy);
            this.Controls.Add(this.text2Energy);
            this.Controls.Add(this.text1Energy);
            this.Controls.Add(this.randomEnergy);
            this.Controls.Add(this.labelEnergy);
            this.Controls.Add(this.setPower);
            this.Controls.Add(this.text2Power);
            this.Controls.Add(this.text1Power);
            this.Controls.Add(this.randomPower);
            this.Controls.Add(this.labelPower);
            this.Controls.Add(this.setDistance);
            this.Controls.Add(this.text2Distance);
            this.Controls.Add(this.text1Distance);
            this.Controls.Add(this.randomDistance);
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.setSpeed);
            this.Controls.Add(this.text2Speed);
            this.Controls.Add(this.text1Speed);
            this.Controls.Add(this.randomSpeed);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.setRPM);
            this.Controls.Add(this.text2RPM);
            this.Controls.Add(this.text1RPM);
            this.Controls.Add(this.randomRPM);
            this.Controls.Add(this.labelRPM);
            this.Controls.Add(this.setHeartBeat);
            this.Controls.Add(this.text2HeartBeat);
            this.Controls.Add(this.text1HeartBeat);
            this.Controls.Add(this.randomHeartBeat);
            this.Controls.Add(this.labelHeartBeat);
            this.Controls.Add(this.ComPortBox);
            this.Controls.Add(this.connectButton);
            this.Name = "ErgometerSimulator";
            this.Text = "Ergometer Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ComboBox ComPortBox;
        private System.Windows.Forms.Label labelHeartBeat;
        private System.Windows.Forms.CheckBox randomHeartBeat;
        private System.Windows.Forms.TextBox text1HeartBeat;
        private System.Windows.Forms.TextBox text2HeartBeat;
        private System.Windows.Forms.Button setHeartBeat;
        private System.Windows.Forms.Button setRPM;
        private System.Windows.Forms.TextBox text2RPM;
        private System.Windows.Forms.TextBox text1RPM;
        private System.Windows.Forms.CheckBox randomRPM;
        private System.Windows.Forms.Label labelRPM;
        private System.Windows.Forms.Button setSpeed;
        private System.Windows.Forms.TextBox text2Speed;
        private System.Windows.Forms.TextBox text1Speed;
        private System.Windows.Forms.CheckBox randomSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Button setDistance;
        private System.Windows.Forms.TextBox text2Distance;
        private System.Windows.Forms.TextBox text1Distance;
        private System.Windows.Forms.CheckBox randomDistance;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Button setPower;
        private System.Windows.Forms.TextBox text2Power;
        private System.Windows.Forms.TextBox text1Power;
        private System.Windows.Forms.CheckBox randomPower;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.Button setEnergy;
        private System.Windows.Forms.TextBox text2Energy;
        private System.Windows.Forms.TextBox text1Energy;
        private System.Windows.Forms.CheckBox randomEnergy;
        private System.Windows.Forms.Label labelEnergy;
        private System.Windows.Forms.Button setActualPower;
        private System.Windows.Forms.TextBox text2ActualPower;
        private System.Windows.Forms.TextBox text1ActualPower;
        private System.Windows.Forms.CheckBox randomActualPower;
        private System.Windows.Forms.Label labelActualPower;
        private System.Windows.Forms.Button setTime;
        private System.Windows.Forms.TextBox text1Time;
        private System.Windows.Forms.CheckBox countTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Timer updateTimer;
    }
}

