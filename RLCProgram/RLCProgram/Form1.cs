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
        public double Time { get; set; } = 0;

        public double Resistor { get; set; }
        public double Capacitor { get; set; }
        public double Inductor { get; set; }
        public int Amplitude { get; set; }
        public int Frequence { get; set; }
        public double Phase { get; set; }
        public double Current { get; set; }





        private Thread thread;
        private double[] sinDataArray = new double[30];
        private double[] cosDataArray = new double[30];

        private double[] CurrentResistiveArray = new double[30];
        private double[] CurrentInductorArray = new double[30];
        private double[] CurrentCapacitorArray = new double[30];




        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Resistance();
            Capacitance();
            Inductance();
            Freq(); 
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
            C_NumericUpDown4.Maximum = 500M;
            C_NumericUpDown4.Value = 100M;
            //uF 10^-6
        }
        private void Inductance()
        {
            L_NumericUpDown5.Increment = 0.1M;
            L_NumericUpDown5.DecimalPlaces = 1;
            L_NumericUpDown5.Minimum = 0M;
            L_NumericUpDown5.Maximum = 200M;
            L_NumericUpDown5.Value = 150M;
        }

        private void Freq()
        {
            FreqNumericUpDown1.Value = 60;
        }


        private void R_NumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            this.Resistor = (double)R_NumericUpDown3.Value;
        }
        private void L_NumericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            this.Inductor = (double)L_NumericUpDown5.Value;
        }
        private void C_NumericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            this.Capacitor = (double)C_NumericUpDown4.Value;
        }

        private void Amp_NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Amplitude = (int)Amp_NumericUpDown1.Value;
        }
        private void FreqNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Frequence = (int)FreqNumericUpDown1.Value;
        }



        private double InductiveReactance()
        {
            return 2 * Math.PI * Frequence * Inductor;
        }
        private double CapacitiveReactance()
        {
            return 1 / (2 * Math.PI * Frequence * Capacitor * Math.Pow(10, -6));
        }



        private void GetDataForSpline()
        {

            

            while (true)
            {
                sinDataArray[sinDataArray.Length - 1] = Amplitude * Math.Sin(2 * Math.PI * Time);
                Array.Copy(sinDataArray, 1, sinDataArray, 0, sinDataArray.Length - 1);

                
                //Purely RESISIVE circut, is in phase with the applied voltage
                CurrentResistiveArray[CurrentResistiveArray.Length - 1] = (Amplitude/Resistor) * Math.Sin(2 * Math.PI * Time);
                Array.Copy(CurrentResistiveArray, 1, CurrentResistiveArray, 0, CurrentResistiveArray.Length - 1);


                //Purely INDUCTOR circut, is in phase with the applied voltage
                CurrentInductorArray[CurrentInductorArray.Length - 1] = (Amplitude / Inductor) * Math.Sin(2 * Math.PI * Time + (Math.PI / 2)) ;
                Array.Copy(CurrentInductorArray, 1, CurrentInductorArray, 0, CurrentInductorArray.Length - 1);


                //Purely CAPACITOR circut, is in phase with the applied voltage
                CurrentCapacitorArray[CurrentCapacitorArray.Length - 1] = (Amplitude / Capacitor) * Math.Sin(2 * Math.PI * Time - (Math.PI / 2));
                Array.Copy(CurrentCapacitorArray, 1, CurrentCapacitorArray, 0, CurrentCapacitorArray.Length - 1);


                if (chartControl.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateDataChart1(); });
                    this.Invoke((MethodInvoker)delegate { UpdateDataChart2(); });
                    this.Invoke((MethodInvoker)delegate { UpdateDataChart3(); });
                    this.Invoke((MethodInvoker)delegate { UpdateDataChart4(); });
                }
                Time = Time + 0.2;
                Thread.Sleep(250);
            }


        }

        private void UpdateDataChart1()
        {
            chartControl.Series["Series1"].Points.Clear();
            label7.Text = Math.Sin(400).ToString();
            for (int i = 0; i < sinDataArray.Length - 1; ++i)
            {
                chartControl.Series["Series1"].Points.AddY(sinDataArray[i]);
            }
        }

        private void UpdateDataChart2()
        {
            chartControl.Series["Series2"].Points.Clear();
            
            for (int i = 0; i < CurrentResistiveArray.Length - 1; ++i)
            {
                label7.Text = CurrentResistiveArray[i].ToString();
                chartControl.Series["Series2"].Points.AddY(CurrentResistiveArray[i]);
            }
        }

        private void UpdateDataChart3()
        {
            chartControl.Series["Series3"].Points.Clear();

            for (int i = 0; i < CurrentInductorArray.Length - 1; ++i)
            {
                chartControl.Series["Series3"].Points.AddY(CurrentInductorArray[i]);
            }
        }
        private void UpdateDataChart4()
        {
            chartControl.Series["Series4"].Points.Clear();

            for (int i = 0; i < CurrentCapacitorArray.Length - 1; ++i)
            {
                chartControl.Series["Series4"].Points.AddY(CurrentCapacitorArray[i]);
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
