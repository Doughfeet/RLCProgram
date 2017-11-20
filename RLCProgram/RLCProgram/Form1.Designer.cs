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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartControl = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StartButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl
            // 
            chartArea1.Name = "ChartArea1";
            this.chartControl.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartControl.Legends.Add(legend1);
            this.chartControl.Location = new System.Drawing.Point(126, 97);
            this.chartControl.Name = "chartControl";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartControl.Series.Add(series1);
            this.chartControl.Size = new System.Drawing.Size(1124, 1001);
            this.chartControl.TabIndex = 0;
            this.chartControl.Text = "chart1";
            // 
            // StartButton1
            // 
            this.StartButton1.Location = new System.Drawing.Point(1406, 996);
            this.StartButton1.Name = "StartButton1";
            this.StartButton1.Size = new System.Drawing.Size(222, 115);
            this.StartButton1.TabIndex = 1;
            this.StartButton1.Text = "button1";
            this.StartButton1.UseVisualStyleBackColor = true;
            this.StartButton1.Click += new System.EventHandler(this.StartButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1702, 1245);
            this.Controls.Add(this.StartButton1);
            this.Controls.Add(this.chartControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartControl;
        private System.Windows.Forms.Button StartButton1;
    }
}

