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
        public MyCustomView()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("배터리잔량");
        }
    }
}
