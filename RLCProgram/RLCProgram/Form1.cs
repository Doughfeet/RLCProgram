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
        double count = 0;
        private int[] counter = new int[] { 10, 0, -10, 0 };
        private double[] sinDataArray = new double[30];
        private double[] cosDataArray = new double[30];

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

                sinDataArray[sinDataArray.Length - 1] = Math.Sin(count);
                Array.Copy(sinDataArray, 1, sinDataArray, 0, sinDataArray.Length - 1);

                cosDataArray[cosDataArray.Length - 1] = Math.Cos(count);
                Array.Copy(cosDataArray, 1, cosDataArray, 0, cosDataArray.Length - 1);


                if (chartControl.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateDataChart(); });
                    this.Invoke((MethodInvoker)delegate { UpdateDataChart2(); });
                }
                count = count + 0.6;
                Thread.Sleep(250);
            }


        }

        private void UpdateDataChart()
        {
            chartControl.Series["Series1"].Points.Clear();

            for (int i = 0; i < sinDataArray.Length - 1; ++i)
            {
                chartControl.Series["Series1"].Points.AddY(sinDataArray[i]);
            }

        }

        private void UpdateDataChart2()
        {
            chartControl.Series["Series2"].Points.Clear();

            for (int i = 0; i < cosDataArray.Length - 1; ++i)
            {
                chartControl.Series["Series2"].Points.AddY(cosDataArray[i]);
            }
        }
        private void StartButton1_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(this.GetDataForSpline));
            thread.IsBackground = true;
            thread.Start();
        }
    }
}
