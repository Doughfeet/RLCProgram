﻿namespace RLCProgram
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartControl = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StartButton1 = new System.Windows.Forms.Button();
            this.Amp_NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.PhaseNumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.R_NumericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.C_NumericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.L_NumericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FreqNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amp_NumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhaseNumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_NumericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_NumericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_NumericUpDown5)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FreqNumericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl
            // 
            chartArea1.Name = "ChartArea1";
            this.chartControl.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartControl.Legends.Add(legend1);
            this.chartControl.Location = new System.Drawing.Point(12, 12);
            this.chartControl.Name = "chartControl";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series4";
            this.chartControl.Series.Add(series1);
            this.chartControl.Series.Add(series2);
            this.chartControl.Series.Add(series3);
            this.chartControl.Series.Add(series4);
            this.chartControl.Size = new System.Drawing.Size(1212, 807);
            this.chartControl.TabIndex = 0;
            this.chartControl.Text = "chart1";
            // 
            // StartButton1
            // 
            this.StartButton1.Location = new System.Drawing.Point(1321, 825);
            this.StartButton1.Name = "StartButton1";
            this.StartButton1.Size = new System.Drawing.Size(222, 115);
            this.StartButton1.TabIndex = 1;
            this.StartButton1.Text = "button1";
            this.StartButton1.UseVisualStyleBackColor = true;
            this.StartButton1.Click += new System.EventHandler(this.StartButton1_Click);
            // 
            // Amp_NumericUpDown1
            // 
            this.Amp_NumericUpDown1.Location = new System.Drawing.Point(218, 227);
            this.Amp_NumericUpDown1.Name = "Amp_NumericUpDown1";
            this.Amp_NumericUpDown1.Size = new System.Drawing.Size(205, 31);
            this.Amp_NumericUpDown1.TabIndex = 2;
            this.Amp_NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Amp_NumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Amp_NumericUpDown1.ValueChanged += new System.EventHandler(this.Amp_NumericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amplitude(V_o )";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(24, 321);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(73, 25);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Phase";
            // 
            // PhaseNumericUpDown2
            // 
            this.PhaseNumericUpDown2.Location = new System.Drawing.Point(218, 321);
            this.PhaseNumericUpDown2.Name = "PhaseNumericUpDown2";
            this.PhaseNumericUpDown2.Size = new System.Drawing.Size(205, 31);
            this.PhaseNumericUpDown2.TabIndex = 4;
            this.PhaseNumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resistance(Ohm)";
            // 
            // R_NumericUpDown3
            // 
            this.R_NumericUpDown3.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.R_NumericUpDown3.Location = new System.Drawing.Point(218, 52);
            this.R_NumericUpDown3.Name = "R_NumericUpDown3";
            this.R_NumericUpDown3.Size = new System.Drawing.Size(205, 31);
            this.R_NumericUpDown3.TabIndex = 6;
            this.R_NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.R_NumericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.R_NumericUpDown3.ValueChanged += new System.EventHandler(this.R_NumericUpDown3_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Capacitance(uF)";
            // 
            // C_NumericUpDown4
            // 
            this.C_NumericUpDown4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.C_NumericUpDown4.Location = new System.Drawing.Point(218, 99);
            this.C_NumericUpDown4.Name = "C_NumericUpDown4";
            this.C_NumericUpDown4.Size = new System.Drawing.Size(205, 31);
            this.C_NumericUpDown4.TabIndex = 6;
            this.C_NumericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.C_NumericUpDown4.Value = new decimal(new int[] {
            20,
            0,
            0,
            131072});
            this.C_NumericUpDown4.ValueChanged += new System.EventHandler(this.C_NumericUpDown4_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Inductance(H)";
            // 
            // L_NumericUpDown5
            // 
            this.L_NumericUpDown5.Location = new System.Drawing.Point(218, 148);
            this.L_NumericUpDown5.Name = "L_NumericUpDown5";
            this.L_NumericUpDown5.Size = new System.Drawing.Size(205, 31);
            this.L_NumericUpDown5.TabIndex = 6;
            this.L_NumericUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.L_NumericUpDown5.ValueChanged += new System.EventHandler(this.L_NumericUpDown5_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FreqNumericUpDown1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.PhaseNumericUpDown2);
            this.groupBox1.Controls.Add(this.L_NumericUpDown5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Amp_NumericUpDown1);
            this.groupBox1.Controls.Add(this.C_NumericUpDown4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.R_NumericUpDown3);
            this.groupBox1.Location = new System.Drawing.Point(1265, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 388);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // FreqNumericUpDown1
            // 
            this.FreqNumericUpDown1.Location = new System.Drawing.Point(223, 272);
            this.FreqNumericUpDown1.Name = "FreqNumericUpDown1";
            this.FreqNumericUpDown1.Size = new System.Drawing.Size(200, 31);
            this.FreqNumericUpDown1.TabIndex = 7;
            this.FreqNumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FreqNumericUpDown1.ValueChanged += new System.EventHandler(this.FreqNumericUpDown1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Frequence";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(1265, 471);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 319);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Circut Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Current_R";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 1004);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StartButton1);
            this.Controls.Add(this.chartControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amp_NumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhaseNumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_NumericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_NumericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_NumericUpDown5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FreqNumericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartControl;
        private System.Windows.Forms.Button StartButton1;
        private System.Windows.Forms.NumericUpDown Amp_NumericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.NumericUpDown PhaseNumericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown R_NumericUpDown3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown C_NumericUpDown4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown L_NumericUpDown5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown FreqNumericUpDown1;
    }
}

