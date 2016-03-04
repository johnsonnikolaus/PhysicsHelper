using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

            if (!checkBox1.Checked)
            {
                //Calculate the results
                float displacement = Convert.ToSingle(finalPosField.Value - initialPosField.Value);
                float deltaV = Convert.ToSingle(displacement);
                float deltaT = Convert.ToSingle(timeField.Value);
                float velResult = Convert.ToSingle((displacement / deltaT));
                float speedResult = Convert.ToSingle((initialPosField.Value + finalPosField.Value) / timeField.Value);
                float accelerationResult = Convert.ToSingle(deltaV / deltaT);
                velResultLabel.Text = velResult.ToString() + unitDropDown.Text + "/" + timeUnit.Text;
                speedResultLabel.Text = speedResult.ToString() + unitDropDown.Text + "/" + timeUnit.Text;
                //accelerationResultLabel.Text = accelerationResult.ToString() + unitDropDown.Text + "/" + timeUnit.Text;
            }
            if (checkBox1.Checked)
            {
                float start = Convert.ToSingle(initialPosField.Value);
                float end = Convert.ToSingle(finalPosField.Value);
                float time = Convert.ToSingle(timeField.Value);
                PlotPoint[] plotPoints = new PlotPoint[8];
                plotPoints[0] = new PlotPoint(start, 0);
                plotPoints[1] = new PlotPoint(Convert.ToSingle(point2Pos.Value), Convert.ToSingle(point2Time.Value));
                plotPoints[2] = new PlotPoint(Convert.ToSingle(point3Pos.Value), Convert.ToSingle(point3Time.Value));
                plotPoints[3] = new PlotPoint(Convert.ToSingle(point4Pos.Value), Convert.ToSingle(point4Time.Value));
                plotPoints[4] = new PlotPoint(Convert.ToSingle(point5Pos.Value), Convert.ToSingle(point5Time.Value));
                plotPoints[5] = new PlotPoint(Convert.ToSingle(point6Pos.Value), Convert.ToSingle(point6Time.Value));
                plotPoints[6] = new PlotPoint(Convert.ToSingle(point7Pos.Value), Convert.ToSingle(point7Time.Value));
                plotPoints[7] = new PlotPoint(end, time);

                Console.WriteLine(plotPoints[1].xPoint.ToString() + ", " + plotPoints[1].yPoint.ToString());                

            }
        }

        private void initialPosField_ValueChanged(object sender, EventArgs e)
        {
            deltaField.Value = finalPosField.Value - initialPosField.Value;
        }

        private void finalPosField_ValueChanged(object sender, EventArgs e)
        {
            deltaField.Value = finalPosField.Value - initialPosField.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                panel1.Enabled = true;
                panel1.Visible = true;
                panel2.Enabled = true;
                panel2.Visible = true;
            }
            else
            {
                panel1.Enabled = false;
                panel1.Visible = false;
                panel2.Enabled = false;
                panel2.Visible = false;
            }
        }
    }

    public class PlotPoint
    {
        public float xPoint { get; set; }
        public float yPoint { get; set; }
        public PlotPoint(float x, float y)
        {
            xPoint = x;
            yPoint = y;
        }
    }
}
