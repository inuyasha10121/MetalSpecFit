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
            var filepath = openFileDialog1.ShowDialog();
            if (filepath != DialogResult.OK)
            {
                textBoxUVPath.Text = String.Empty;
                return;
            }
            textBoxUVPath.Text = openFileDialog1.FileName;
        }

        private void buttonBrowseCD_Click(object sender, EventArgs e)
        {
            var filepath = openFileDialog1.ShowDialog();
            if (filepath != DialogResult.OK)
            {
                textBoxCDPath.Text = String.Empty;
                return;
            }
            textBoxCDPath.Text = openFileDialog1.FileName;
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

            //Clear out chart if other elements are there
            var chartelems = chartUV.Series.Count - 1;
            for (int i = chartelems; i > -1; i--)
            {
                chartUV.Series.Remove(chartUV.Series[i]);
                chartCD.Series.Remove(chartCD.Series[i]);
            }

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

            chartCD.Series.Add("Sim");
            chartUV.Series.Add("Sim");

            //TODO: Add real spectra addition here
            if(!textBoxUVPath.Text.Equals(String.Empty))
            {
                chartUV.Series.Add("Real");

            }
            if (!textBoxCDPath.Text.Equals(String.Empty))
            {
                chartCD.Series.Add("Real");

            }


            var cdbasespec = chartCD.Series.Count;
            var uvbasespec = chartUV.Series.Count;

            for (int i = 1; i < totalcurves; i++)
            {
                chartCD.Series.Add("Comp " + (i - 1));
                chartUV.Series.Add("Comp " + (i - 1));
            }

            for (int i = 0; i < totalcurves; i++)
            {
                chartCD.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chartUV.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }

            //Push the data to the charts
            for (int currx = 0; currx < numx; currx++)
            {
                chartUV.Series[0].Points.AddXY(xvals[currx], simUV[currx]);
                chartCD.Series[0].Points.AddXY(xvals[currx], simCD[currx]);

                if (checkBoxComponents.Checked)
                {
                    for(int curve = 0; curve < numCurves; curve++)
                    {
                        chartUV.Series[curve + uvbasespec].Points.AddXY(xvals[currx], simComponents[curve][currx]);
                        chartCD.Series[curve + cdbasespec].Points.AddXY(xvals[currx], simComponents[curve][currx]);
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
