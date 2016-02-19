using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsHelper
{
    public partial class VelocityCalculator : Form
    {
        public VelocityCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal velResult = (deltaField.Value / timeField.Value);
            decimal speedResult = (initialPosField.Value + finalPosField.Value) / timeField.Value;
            velResultLabel.Text = velResult.ToString().Substring(0, velResult.ToString().IndexOf(".") + 3) + unitDropDown.Text + "/" + timeUnit.Text;
            speedResultLabel.Text = speedResult.ToString().Substring(0, speedResult.ToString().IndexOf(".") + 3) + unitDropDown.Text + "/" + timeUnit.Text;
        }

        private void initialPosField_ValueChanged(object sender, EventArgs e)
        {
            deltaField.Value = finalPosField.Value - initialPosField.Value;
        }

        private void finalPosField_ValueChanged(object sender, EventArgs e)
        {
            deltaField.Value = finalPosField.Value - initialPosField.Value;
        }
        
    }
}
