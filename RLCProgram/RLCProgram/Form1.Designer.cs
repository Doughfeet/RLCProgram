namespace RLCProgram
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartControl = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StartButton1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.R_NumericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.C_NumericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.L_NumericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_NumericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_NumericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_NumericUpDown5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl
            // 
            chartArea2.Name = "ChartArea1";
            this.chartControl.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartControl.Legends.Add(legend2);
            this.chartControl.Location = new System.Drawing.Point(12, 12);
            this.chartControl.Name = "chartControl";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(218, 227);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(205, 31);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amplitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fase";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(218, 281);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(205, 31);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Capacitance(F)";
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
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.L_NumericUpDown5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.C_NumericUpDown4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.R_NumericUpDown3);
            this.groupBox1.Location = new System.Drawing.Point(1265, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 459);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1702, 1004);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StartButton1);
            this.Controls.Add(this.chartControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_NumericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_NumericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_NumericUpDown5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartControl;
        private System.Windows.Forms.Button StartButton1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown R_NumericUpDown3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown C_NumericUpDown4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown L_NumericUpDown5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

