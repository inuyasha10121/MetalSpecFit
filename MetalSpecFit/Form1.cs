using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetalSpecFit
{
    public partial class Form1 : Form
    {
        private float gaussFunc(float height, float pos, float width, float x)
        {
            return height * (float)Math.Exp(-1.0f * (((x - pos) * (x - pos)) / (2 * width * width)));
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            chartUV.ChartAreas[0].CursorX.IsUserEnabled = true;
            chartUV.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartCD.ChartAreas[0].CursorX.IsUserEnabled = true;
            chartCD.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
        }

        private void buttonBrowseUV_Click(object sender, EventArgs e)
        {

        }

        private void buttonBrowseCD_Click(object sender, EventArgs e)
        {

        }

        private void buttonSimulate_Click(object sender, EventArgs e)
        {
            //Get list of parameters
            var simComponents = new List<List<float>>();
            var simUV = new List<float>();
            var simCD = new List<float>();

            var paramLines = textBoxParameters.Lines;

            var xvals = new List<float>();
            float xmin = (float)numericUpDownXMin.Value;
            float xmax = (float)numericUpDownXMax.Value;
            float xstep = (float)numericUpDownXStep.Value;
            float cdymin = float.MaxValue;
            float cdymax = float.MinValue;
            float uvymin = float.MaxValue;
            float uvymax = float.MinValue;

            //Populate our x values and build the simulated spectra lists
            for (float xpos = xmin; xpos < xmax; xpos += xstep)
            {
                xvals.Add(xpos);
                simUV.Add(0.0f);
                simCD.Add(0.0f);
            }

            int numx = xvals.Count;

            //Build up the simulation components and overall spectra
            int numCurves = paramLines.Length;
            for(int curve = 0; curve < numCurves; curve++)
            {
                //Parse the parameters
                var curveParams = paramLines[curve].Split(',');
                float curvePos = float.Parse(curveParams[0]);
                float curveInt = float.Parse(curveParams[1]);
                float curveWidth = float.Parse(curveParams[2]);

                //Build the component spectra and simulated spectra
                simComponents.Add(new List<float>());
                for(int currx = 0; currx < numx; currx++)
                {
                    var gaussVal = gaussFunc(curveInt, curvePos, curveWidth, xvals[currx]);
                    simComponents[curve].Add(gaussVal);

                    simCD[currx] += gaussVal;
                    simUV[currx] += Math.Abs(gaussVal);

                    //Auto-scale parameters
                    if(simCD[currx] > cdymax)
                    {
                        cdymax = simCD[currx];
                    }
                    if(simCD[currx] < cdymin)
                    {
                        cdymin = simCD[currx];
                    }
                    if (simUV[currx] > uvymax)
                    {
                        uvymax = simUV[currx];
                    }
                    if (simUV[currx] < uvymin)
                    {
                        uvymin = simUV[currx];
                    }
                }
            }

            //Setup plots
            int totalcurves = 1;
            if (checkBoxComponents.Checked)
            {
                totalcurves += simComponents.Count;
            }

            for (int i = 0; i < totalcurves; i++)
            {
                chartCD.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chartUV.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                chartCD.Series[i].Points.Clear();
                chartUV.Series[i].Points.Clear();
            }

            //Push the data to the charts
            for (int currx = 0; currx < numx; currx++)
            {
                chartUV.Series[0].Points.AddXY(xvals[currx], simUV[currx]);
                //chartUV.Series[0].Label = "Simulated";
                chartCD.Series[0].Points.AddXY(xvals[currx], simCD[currx]);
                //chartCD.Series[0].Label = "Simulated";

                //TODO: Put the spectra reading code here

                if (checkBoxComponents.Checked)
                {
                    for(int curve = 0; curve < numCurves; curve++)
                    {
                        chartUV.Series[curve + 2].Points.AddXY(xvals[currx], simComponents[curve][currx]);
                        //chartUV.Series[curve + 2].Label = ("Comp " + (curve + 1));
                        chartCD.Series[curve + 2].Points.AddXY(xvals[currx], simComponents[curve][currx]);
                        //chartCD.Series[curve + 2].Label = ("Comp " + (curve + 1));
                    }
                }
            }
            chartCD.ChartAreas[0].RecalculateAxesScale();
            chartUV.ChartAreas[0].RecalculateAxesScale();
            chartCD.Update();
            chartUV.Update();
        }
    }
}
