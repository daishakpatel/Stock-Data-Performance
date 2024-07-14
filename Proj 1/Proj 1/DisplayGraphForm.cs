using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proj_1
{
    //Define a partial class named Form_entry that inherits from System.Windows.Forms.Form class
    public partial class DisplayGraphForm : System.Windows.Forms.Form
    {
        private Chart chart1;

        // Declare a BindingList and a temporary List of aCandleStick objects
        private BindingList<smartCandleStick> BindingCandleSticks { get; set; }
        private List<aCandleStick> templist;
        private string filename;
        private List<Recognizer> recognizers;

        // Constructor for the form
        public DisplayGraphForm()
        {
            InitializeComponent();
        }

        internal DisplayGraphForm(string filename, List<aCandleStick> candlesticks, DateTimePicker start, DateTimePicker end)
        {
            InitializeComponent(); // Always do this first
            //Form_Empty fe = new Form_Empty();
            //fe.Show();

            templist = new List<aCandleStick>();
            templist = candlesticks;
            this.filename = filename;

            UpdatedateTimePicker_startDate.Value = start.Value;
            UpdatedateTimePicker_endDate.Value = end.Value;

            getCandlesticksInDateRange(start.Value, end.Value);

            //dataGridView_stock.DataSource = BindingCandleSticks;

            //Set the chart title to the file name
            chart_stock.Titles.Clear();
            chart_stock.Titles.Add(Path.GetFileNameWithoutExtension(filename));
            chart_stock.Titles[0].Font = new Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //Connect the chart to the BindingList
            chart_stock.DataSource = BindingCandleSticks;
            chart_stock.DataBind();

            recognizers = new List<Recognizer>();
            recognizers.Add(new DojiRecognizer());
            recognizers.Add(new BullishRecognizer());
            recognizers.Add(new PeakRecognizer());
            recognizers.Add(new BearishEngulfingRecognizer());
            recognizers.Add(new BullishEngulfingRecognizer());
            recognizers.Add(new HammerRecognizer());
            recognizers.Add(new InvertedHammerRecognizer());
            recognizers.Add(new GravestoneDojiRecognizer());
            recognizers.Add(new DragonFlyDojiRecognizer());
            recognizers.Add(new BearishRecognizer());
            recognizers.Add(new NeutralRecognizer());
            recognizers.Add(new ValleyRecognizer());

            foreach (Recognizer r in recognizers)
            {
                aCandleStickPatterns.Items.Add(r.patternName);
            }
        }
        private void getCandlesticksInDateRange(DateTime start, DateTime end)
        {
            BindingCandleSticks = new BindingList<smartCandleStick>();
            if (BindingCandleSticks != null)
            {
                BindingCandleSticks.Clear();
            }

            for (int i = 0; i < templist.Count; i++)
            {
                aCandleStick cs = templist[i];
                smartCandleStick scs = new smartCandleStick(cs);

                if (cs.date > end)
                    break;

                if (cs.date >= start)
                {
                    BindingCandleSticks.Add(scs);
                }
            }
        }
        private void button_Update_Click(object sender, EventArgs e)
        {
            if (BindingCandleSticks != null)
            {
                BindingCandleSticks.Clear();
            }

            getCandlesticksInDateRange(UpdatedateTimePicker_startDate.Value, UpdatedateTimePicker_endDate.Value);

            //dataGridView_stock.DataSource = BindingCandleSticks;

            chart_stock.DataSource = BindingCandleSticks;
            chart_stock.DataBind();
        }
        private void PatternButton_Click(object sender, EventArgs e)
        {
           // String selectedPattern = aCandleStickPatterns.SelectedItem.ToString();
            int selectedPatternIndex = aCandleStickPatterns.SelectedIndex;
            chart_stock.Annotations.Clear();
            
            Recognizer selectedRecognizer = recognizers[selectedPatternIndex];
            List<int> recognizedIndexes = selectedRecognizer.recognizePatterns(BindingCandleSticks.ToList());

            foreach (int i in recognizedIndexes)
            {
                RectangleAnnotationFunc(i);
                //ArrowAnnotationFunc(i);
            }
        }

        private void RectangleAnnotationFunc(int startIndex)
        {
            System.Windows.Forms.DataVisualization.Charting.RectangleAnnotation rectangle = new System.Windows.Forms.DataVisualization.Charting.RectangleAnnotation();

            // Get the data points for the three candlesticks
            System.Windows.Forms.DataVisualization.Charting.DataPoint startDataPoint = chart_stock.Series["series_OHLC"].Points[startIndex];

            rectangle.ClipToChartArea = "area_OHLC";
            rectangle.AxisX = chart_stock.ChartAreas["area_OHLC"].AxisX;
            rectangle.AxisY = chart_stock.ChartAreas["area_OHLC"].AxisY;
            rectangle.IsSizeAlwaysRelative = false;
            rectangle.AxisY.IsStartedFromZero = false;

            rectangle.BackColor = Color.FromArgb(100, Color.DarkBlue); // Adjust transparency and color as needed
            rectangle.ForeColor = Color.Transparent;
            rectangle.ShadowColor = Color.Transparent;

            rectangle.AnchorDataPoint = startDataPoint;
            rectangle.Y = startDataPoint.YValues[0];
            rectangle.Width = 1; // Set the width based on the distance between the start and end data points
            rectangle.Height = startDataPoint.YValues[1] - startDataPoint.YValues[0]; // Set the height based on the difference between the highest and lowest Y-values

            // Add the rectangle annotation to the chart
            chart_stock.Annotations.Add(rectangle);
        }


        private void ArrowAnnotationFunc(int ind)
        {
            System.Windows.Forms.DataVisualization.Charting.ArrowAnnotation arrow = new System.Windows.Forms.DataVisualization.Charting.ArrowAnnotation();

            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint = chart_stock.Series["series_OHLC"].Points[ind];
            // Customize arrow properties as needed

            arrow.ClipToChartArea = "area_OHLC";
            arrow.AxisX = chart_stock.ChartAreas["area_OHLC"].AxisX;
            arrow.AxisY = chart_stock.ChartAreas["area_OHLC"].AxisY;
            arrow.AnchorDataPoint = dataPoint;
            arrow.LineColor = Color.DarkMagenta;
            arrow.ForeColor = Color.DarkCyan;
            arrow.BackColor = Color.DarkCyan;
            arrow.BackSecondaryColor = Color.DarkCyan;
            arrow.ShadowColor = Color.Transparent;
            arrow.Height = -7;
            arrow.Width = .5;    // Width of the arrow (adjust as needed)
            arrow.LineWidth = 1;
            arrow.Alignment = ContentAlignment.TopLeft;

            arrow.AxisY.IsStartedFromZero = false;
            arrow.IsSizeAlwaysRelative = true;

            // Add the arrow annotation to the chart
            chart_stock.Annotations.Add(arrow);
        
        }
    }
}
