using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proj_1
{
    public partial class Form_Empty : Form
    {
        Chart chart1;
        public Form_Empty()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
        {
            // Create a new chart
            chart1 = new Chart();
            chart1.Dock = DockStyle.Fill;

            // Add a chart area
            ChartArea chartArea = new ChartArea("Default");
            chart1.ChartAreas.Add(chartArea);

            // Add a series for candlestick chart
            Series series = new Series("Candlestick");
            series.ChartArea = "Default";
            series.ChartType = SeriesChartType.Candlestick;
            series["OpenCloseStyle"] = "Triangle";
            series["ShowOpenClose"] = "Both";
            series["PointWidth"] = "0.6";
            series.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series.IsVisibleInLegend = false;
            series.IsXValueIndexed = true;
            chart1.Series.Add(series);

            // Add data (replace this with your actual data)

            DateTime dateTime = DateTime.Now;
            DateTime cur = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 0, 0, 0); ;
            series.Points.AddXY(cur, 350, 347, 348, 349); // Example data point
            series.Points.AddXY(cur.AddDays(1), 340, 337, 338, 339);
            series.Points.AddXY(cur.AddDays(2), 345, 342, 343, 344);
            series.Points.AddXY(cur.AddDays(3), 346, 343, 344, 345);
            //series.Points.AddXY(cur.AddDays(4), 341, 338, 339, 340);

            chart1.ChartAreas["Default"].AxisY.IsStartedFromZero = false;

            // Add arrow annotations to each data point
            RectangleAnnotationFunc(1);

            // Add the chart to the form
            Controls.Add(chart1);
        }

        private void RectangleAnnotationFunc(int startIndex)
        {
            System.Windows.Forms.DataVisualization.Charting.RectangleAnnotation rectangle = new System.Windows.Forms.DataVisualization.Charting.RectangleAnnotation();

            // Get the data points for the three candlesticks
            System.Windows.Forms.DataVisualization.Charting.DataPoint startDataPoint = chart1.Series["Candlestick"].Points[startIndex];
            System.Windows.Forms.DataVisualization.Charting.DataPoint endDataPoint = chart1.Series["Candlestick"].Points[startIndex + 1];
            rectangle.ClipToChartArea = "Default";
            rectangle.AxisX = chart1.ChartAreas["Default"].AxisX;
            rectangle.AxisY = chart1.ChartAreas["Default"].AxisY;
            rectangle.IsSizeAlwaysRelative = false;
            rectangle.AxisY.IsStartedFromZero = false;

            rectangle.BackColor = Color.FromArgb(100, Color.DarkGreen); // Adjust transparency and color as needed
            rectangle.ForeColor = Color.Transparent;
            rectangle.ShadowColor = Color.Transparent;

            //rectangle.AnchorDataPoint = startDataPoint; // Anchor to the first candlestick pattern

            //            rectangle.AnchorDataPoint = startDataPoint; // Anchor to the first candlestick pattern

            rectangle.AnchorDataPoint = endDataPoint; // Anchor to the first candlestick pattern

            double minY = Math.Min(startDataPoint.YValues[1], endDataPoint.YValues[1]);
            double maxY = Math.Max(startDataPoint.YValues[0], endDataPoint.YValues[0]);

            rectangle.Y = maxY;
            rectangle.Height = minY - maxY;

            // Add the rectangle annotation to the chart
            chart1.Annotations.Add(rectangle);
        }

        /*  private void AddArrowAnnotations(Series series)
          {
              foreach (DataPoint dataPoint in series.Points)
              {
                  ArrowAnnotation arrow = new ArrowAnnotation();
                  //arrow.ClipToChartArea = 
                  arrow.AnchorDataPoint = dataPoint;
                  arrow.Height = -20; // Length of the arrow pointing down
                  arrow.Width = 0.0000000000000001;    // Width of the arrow (adjust as needed)
                  arrow.LineWidth = 2;
                  arrow.IsSizeAlwaysRelative = true; // Set to false for absolute size
                  arrow.BackColor = Color.Red;

                  // Set the arrow annotation alignment to BottomCenter
                  arrow.Alignment = ContentAlignment.BottomCenter;

                  // Add the arrow annotation to the chart
                  chart1.Annotations.Add(arrow);

                  // Add text annotation at the calculated position
                  TextAnnotation textAnnotation = new TextAnnotation();
                  textAnnotation.Text = "Bullish"; // Set your desired annotation text here
                  textAnnotation.AnchorDataPoint = dataPoint;
                  textAnnotation.AnchorOffsetY= Math.Abs(arrow.Height);
                  textAnnotation.Alignment = ContentAlignment.MiddleCenter;
                  ;
                  // Add the text annotation to the chart
                  chart1.Annotations.Add(textAnnotation);
              }
          }
        */
    }
}
