using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;

namespace RLCProgram
{
    public partial class Form1 : Form
    {
        private Thread thread;
        private double counter = 0;
        private double[] dataArray = new double[60];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void GetDataForSpline()
        {

            

            while (true)
            {
                counter = counter + 1;
                dataArray[dataArray.Length - 1] = Math.Round(Math.Sin(1 * counter), 0);

                Array.Copy(dataArray, 1, dataArray, 0, dataArray.Length - 1);

                if (chartControl.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateDataChart(); });
                }
                Thread.Sleep(100);
            }


        }

        private void UpdateDataChart()
        {
            chartControl.Series["Series1"].Points.Clear();

            for (int i = 0; i < dataArray.Length - 1; ++i)
            {
                chartControl.Series["Series1"].Points.AddY(dataArray[i]);
            }
        }
        private void StartButton1_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(this.GetDataForSpline));
            thread.IsBackground = true;
            thread.Start();
        }



        private void SplineChartExample()
        {
            //this.chartControl.Series.Clear();

            //this.chartControl.Titles.Add("Total Income");

            //Series series = this.chartControl.Series.Add("Total Income");
            //series.ChartType = SeriesChartType.Spline;

            //for (int i = 0; i < 20; i++)
            //{
            //    series.Points.Add(Math.Sin(i));
            //}
            //series.Points.AddXY("September", 100);
            //series.Points.AddXY("Obtober", 300);
            //series.Points.AddXY("November", 800);
            //series.Points.AddXY("December", 200);
            //series.Points.AddXY("January", 600);
            //series.Points.AddXY("February", 400);
        }


    }
}
