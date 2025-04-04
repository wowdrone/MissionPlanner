using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MissionPlanner.Controls;

namespace MissionPlanner.HJSCUSTOM
{
    public partial class MyCustomView : MyUserControl
    {
        string battrey;
        int voltage;


        public MyCustomView()
        {
            InitializeComponent();
            Timer Timer = new System.Windows.Forms.Timer();
            Timer.Interval = 500;
            Timer.Tick += new EventHandler(MAVLINK_SENDER);
            Timer.Start();
        }
        private void MAVLINK_SENDER(object sender, EventArgs e)
        {
            float custom_altitude = MainV2.comPort.MAV.cs.alt;
            Console.WriteLine($"고도 : {custom_altitude} m");
        }
        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("배터리잔량");
        }
    }
}
