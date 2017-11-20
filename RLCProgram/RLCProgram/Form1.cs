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
        public double Count { get; set; } = 0;
        public double Resistor { get; set; }
        public double Capacitor { get; set; }
        public double Inductor { get; set; }




        private Thread thread;
        private double[] sinDataArray = new double[30];
        private double[] cosDataArray = new double[30];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Resistance();
            Capacitance();
            Inductance();
        }
        private void Resistance()
        {
            R_NumericUpDown3.Increment = 1;
            R_NumericUpDown3.Minimum = 0;
            R_NumericUpDown3.Maximum = 10000;
            R_NumericUpDown3.Value = 100;
        }
        private void Capacitance()
        {
            C_NumericUpDown4.Increment = 0.1M;
            C_NumericUpDown4.DecimalPlaces = 1;
            C_NumericUpDown4.Minimum = 0M;
            C_NumericUpDown4.Maximum = 10M;
            C_NumericUpDown4.Value = 0.1M;
            //uF 10^-6
        }
        private void Inductance()
        {
            L_NumericUpDown5.Increment = 0.1M;
            L_NumericUpDown5.DecimalPlaces = 1;
            L_NumericUpDown5.Minimum = 0M;
            L_NumericUpDown5.Maximum = 10M;
            L_NumericUpDown5.Value = 1;
            //uH 10^-6
        }


        private void R_NumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            this.Resistor = (double)R_NumericUpDown3.Value;
        }
        private void C_NumericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            this.Capacitor = (double)C_NumericUpDown4.Value;
        }
        private void L_NumericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            this.Inductor = (double)L_NumericUpDown5.Value;
        }




        private void GetDataForSpline()
        {

            

            while (true)
            {

                sinDataArray[sinDataArray.Length - 1] = Math.Sin(Count);
                Array.Copy(sinDataArray, 1, sinDataArray, 0, sinDataArray.Length - 1);

                cosDataArray[cosDataArray.Length - 1] = Math.Cos(2 * Math.PI * Count);
                Array.Copy(cosDataArray, 1, cosDataArray, 0, cosDataArray.Length - 1);


                if (chartControl.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateDataChart(); });
                    this.Invoke((MethodInvoker)delegate { UpdateDataChart2(); });
                }
                Count = Count + 0.2;
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
