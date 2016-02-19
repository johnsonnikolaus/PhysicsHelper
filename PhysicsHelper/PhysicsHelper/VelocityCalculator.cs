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
            decimal result = (deltaField.Value / timeField.Value);
            resultLabel.Text = result.ToString().Substring(0, result.ToString().IndexOf(".") + 3) + unitDropDown.Text + "/" + timeUnit.Text;
        }
    }
}
