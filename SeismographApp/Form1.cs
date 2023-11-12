using System;
using System.IO.Ports;
using System.Management;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SeismographApp
{
    public partial class MainForm : Form
    {
        private SerialPort serialPort;

        public MainForm()
        {
            InitializeComponent();
            InitializeSerialPort();
            this.FormClosing += MainForm_FormClosing;

            // Set up chart properties
            //chart1.ChartAreas[0].AxisX.Minimum = 0;
            //chart1.ChartAreas[0].AxisX.Maximum = 500; // Adjust as needed
            chart1.ChartAreas[0].AxisY.Minimum = -5;
            chart1.ChartAreas[0].AxisY.Maximum = 5; // Adjust as needed

            chart1.ChartAreas[0].AxisX.IsStartedFromZero = false;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss"; // Optional: Format the X-axis label as desired

            // Add X-Axis series
            chart1.Series.Add("X-Axis");
            chart1.Series["X-Axis"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["X-Axis"].XValueType = ChartValueType.DateTime;

            // Add X-Axis series
            //chart1.Series.Add("X-Axis");
            chart1.Series["X-Axis"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            // Add Y-Axis series
            chart1.Series.Add("Y-Axis");
            chart1.Series["Y-Axis"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            // Add Z-Axis series
            chart1.Series.Add("Z-Axis");
            chart1.Series["Z-Axis"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        
        private void InitializeSerialPort()
        {
            serialPort = new SerialPort("COM3", 115200);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Cannot Find Sensor \n" + ex.Message);
            }
        }


        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            string[] values = data.Split(',');

            if (values.Length >= 6 &&
                float.TryParse(values[0], out float x) && float.TryParse(values[1], out float y) && float.TryParse(values[2], out float z) &&
                float.TryParse(values[3], out float x1) && float.TryParse(values[4], out float y1) && float.TryParse(values[5], out float z1))
            {
                if (this.IsHandleCreated)
                {
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        // Get the current timestamp
                        DateTime timestamp = DateTime.Now;

                        // Add data points with the timestamp as X-value
                        chart1.Series["X-Axis"].Points.AddXY(timestamp, x);
                        chart1.Series["Y-Axis"].Points.AddXY(timestamp, y);
                        chart1.Series["Z-Axis"].Points.AddXY(timestamp, z);

                        DateTime oneMinuteAgo = DateTime.Now.AddSeconds(-30);
                        DateTime oneMinuteAhead = DateTime.Now.AddSeconds(30);
                        chart1.ChartAreas[0].AxisX.Minimum = oneMinuteAgo.ToOADate();
                        chart1.ChartAreas[0].AxisX.Maximum = oneMinuteAhead.ToOADate();

                        // Remove data points older than a specific time window (e.g., 10 minutes)
                        while (chart1.Series["X-Axis"].Points[0].XValue < oneMinuteAgo.ToOADate())
                        {
                            chart1.Series["X-Axis"].Points.RemoveAt(0);
                            chart1.Series["Y-Axis"].Points.RemoveAt(0);
                            chart1.Series["Z-Axis"].Points.RemoveAt(0);
                        }

                        double accelerationMagnitude = CalculateEquation(x1, y1, z1);
                        labelResult1.Text = $"{accelerationMagnitude}";

                    });
                }
            }
        }

        private double CalculateEquation(float x1, float y1, float z1)
        {
            double accelerationMagnitude = Math.Sqrt(x1 * x1 + y1 * y1 + z1 * z1);
            if (accelerationMagnitude > 10.0)
            {
                labelResult1.Text = $"{accelerationMagnitude}";
                labelResult2.Text = "                                   Earthquake Detected                                       ";
                labelResult3.Text = "";
            }
            else
            {
                labelResult2.Text = "";
                labelResult3.Text = "";
            }
            return accelerationMagnitude;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

    }
}
