namespace MetalSpecFit
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUVPath = new System.Windows.Forms.TextBox();
            this.buttonBrowseUV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxParameters = new System.Windows.Forms.TextBox();
            this.textBoxCDPath = new System.Windows.Forms.TextBox();
            this.buttonBrowseCD = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chartUV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonSimulate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownXMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownXMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownXStep = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxComponents = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chartUV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXStep)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "UV Spec:";
            // 
            // textBoxUVPath
            // 
            this.textBoxUVPath.Location = new System.Drawing.Point(89, 12);
            this.textBoxUVPath.Name = "textBoxUVPath";
            this.textBoxUVPath.Size = new System.Drawing.Size(726, 22);
            this.textBoxUVPath.TabIndex = 2;
            // 
            // buttonBrowseUV
            // 
            this.buttonBrowseUV.Location = new System.Drawing.Point(821, 12);
            this.buttonBrowseUV.Name = "buttonBrowseUV";
            this.buttonBrowseUV.Size = new System.Drawing.Size(75, 22);
            this.buttonBrowseUV.TabIndex = 3;
            this.buttonBrowseUV.Text = "Browse";
            this.buttonBrowseUV.UseVisualStyleBackColor = true;
            this.buttonBrowseUV.Click += new System.EventHandler(this.buttonBrowseUV_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fitting Parameters:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "(Pos,Int,Width)";
            // 
            // textBoxParameters
            // 
            this.textBoxParameters.Location = new System.Drawing.Point(15, 102);
            this.textBoxParameters.Multiline = true;
            this.textBoxParameters.Name = "textBoxParameters";
            this.textBoxParameters.Size = new System.Drawing.Size(258, 362);
            this.textBoxParameters.TabIndex = 5;
            this.textBoxParameters.Text = "350, 1, 2\r\n345, 0.5, 1";
            // 
            // textBoxCDPath
            // 
            this.textBoxCDPath.Location = new System.Drawing.Point(89, 40);
            this.textBoxCDPath.Name = "textBoxCDPath";
            this.textBoxCDPath.Size = new System.Drawing.Size(726, 22);
            this.textBoxCDPath.TabIndex = 6;
            // 
            // buttonBrowseCD
            // 
            this.buttonBrowseCD.Location = new System.Drawing.Point(821, 40);
            this.buttonBrowseCD.Name = "buttonBrowseCD";
            this.buttonBrowseCD.Size = new System.Drawing.Size(75, 22);
            this.buttonBrowseCD.TabIndex = 7;
            this.buttonBrowseCD.Text = "Browse";
            this.buttonBrowseCD.UseVisualStyleBackColor = true;
            this.buttonBrowseCD.Click += new System.EventHandler(this.buttonBrowseCD_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "CD Spec:";
            // 
            // chartUV
            // 
            chartArea3.Name = "ChartArea1";
            this.chartUV.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartUV.Legends.Add(legend3);
            this.chartUV.Location = new System.Drawing.Point(364, 102);
            this.chartUV.Name = "chartUV";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartUV.Series.Add(series3);
            this.chartUV.Size = new System.Drawing.Size(760, 300);
            this.chartUV.TabIndex = 10;
            this.chartUV.Text = "UV-Spec";
            // 
            // chartCD
            // 
            chartArea4.Name = "ChartArea1";
            this.chartCD.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartCD.Legends.Add(legend4);
            this.chartCD.Location = new System.Drawing.Point(364, 408);
            this.chartCD.Name = "chartCD";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartCD.Series.Add(series4);
            this.chartCD.Size = new System.Drawing.Size(760, 300);
            this.chartCD.TabIndex = 11;
            this.chartCD.Text = "CD-Spec";
            // 
            // buttonSimulate
            // 
            this.buttonSimulate.Location = new System.Drawing.Point(15, 663);
            this.buttonSimulate.Name = "buttonSimulate";
            this.buttonSimulate.Size = new System.Drawing.Size(261, 45);
            this.buttonSimulate.TabIndex = 12;
            this.buttonSimulate.Text = "Simulate";
            this.buttonSimulate.UseVisualStyleBackColor = true;
            this.buttonSimulate.Click += new System.EventHandler(this.buttonSimulate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Wavelength min:";
            // 
            // numericUpDownXMin
            // 
            this.numericUpDownXMin.DecimalPlaces = 2;
            this.numericUpDownXMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownXMin.Location = new System.Drawing.Point(153, 470);
            this.numericUpDownXMin.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDownXMin.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownXMin.Name = "numericUpDownXMin";
            this.numericUpDownXMin.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownXMin.TabIndex = 15;
            this.numericUpDownXMin.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // numericUpDownXMax
            // 
            this.numericUpDownXMax.DecimalPlaces = 2;
            this.numericUpDownXMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownXMax.Location = new System.Drawing.Point(153, 498);
            this.numericUpDownXMax.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDownXMax.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownXMax.Name = "numericUpDownXMax";
            this.numericUpDownXMax.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownXMax.TabIndex = 16;
            this.numericUpDownXMax.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // numericUpDownXStep
            // 
            this.numericUpDownXStep.DecimalPlaces = 2;
            this.numericUpDownXStep.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownXStep.Location = new System.Drawing.Point(153, 526);
            this.numericUpDownXStep.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownXStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownXStep.Name = "numericUpDownXStep";
            this.numericUpDownXStep.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownXStep.TabIndex = 17;
            this.numericUpDownXStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Wavelength max:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 528);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Wavelength step:";
            // 
            // checkBoxComponents
            // 
            this.checkBoxComponents.AutoSize = true;
            this.checkBoxComponents.Location = new System.Drawing.Point(32, 558);
            this.checkBoxComponents.Name = "checkBoxComponents";
            this.checkBoxComponents.Size = new System.Drawing.Size(147, 21);
            this.checkBoxComponents.TabIndex = 20;
            this.checkBoxComponents.Text = "Show Components";
            this.checkBoxComponents.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 731);
            this.Controls.Add(this.checkBoxComponents);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownXStep);
            this.Controls.Add(this.numericUpDownXMax);
            this.Controls.Add(this.numericUpDownXMin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSimulate);
            this.Controls.Add(this.chartCD);
            this.Controls.Add(this.chartUV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonBrowseCD);
            this.Controls.Add(this.textBoxCDPath);
            this.Controls.Add(this.textBoxParameters);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBrowseUV);
            this.Controls.Add(this.textBoxUVPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartUV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXStep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUVPath;
        private System.Windows.Forms.Button buttonBrowseUV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxParameters;
        private System.Windows.Forms.TextBox textBoxCDPath;
        private System.Windows.Forms.Button buttonBrowseCD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCD;
        private System.Windows.Forms.Button buttonSimulate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownXMin;
        private System.Windows.Forms.NumericUpDown numericUpDownXMax;
        private System.Windows.Forms.NumericUpDown numericUpDownXStep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxComponents;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

