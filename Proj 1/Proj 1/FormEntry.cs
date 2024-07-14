using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_1
{
    public partial class FormEntry : Form
    {
        private static String referenceString = "\"Ticker\",\"Period\",\"Date\",\"Open\",\"High\",\"Low\",\"Close\",\"Volume\"";
        public FormEntry()
        {
            InitializeComponent();
        }

        private void LoadButtonOpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            List<List<aCandleStick>> allCandlesticks = loadCandlesticks(LoadButtonOpenFileDialog.FileNames);
            openDisplayChartForms(LoadButtonOpenFileDialog.FileNames, allCandlesticks);
        }

        private List<List<aCandleStick>> loadCandlesticks(string[] arrayofFilenames)
        {
            List<string> listofFilenames = arrayofFilenames.ToList<string>();
            return loadCandlesticks(listofFilenames);
        }

        private List<List<aCandleStick>> loadCandlesticks(List<string> listofFilenames)
        {
            List<List<aCandleStick>> resultingList = new List<List<aCandleStick>>(listofFilenames.Count());

            foreach (string filename in listofFilenames)
            {
                List<aCandleStick> candlesticks = loadStockFromFile(filename);
                resultingList.Add(candlesticks);
            }

            return resultingList;
        }
        private List<aCandleStick> loadStockFromFile(string filename)
        {
            List<aCandleStick> templist = new List<aCandleStick>(1024);

            using (StreamReader sr = new StreamReader(filename))
            {
                string line;

                //First read the header
                string header = sr.ReadLine();

                if (header == referenceString)
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        aCandleStick cs = new aCandleStick(line);
                        templist.Add(cs);
                    }

                    templist.Reverse();
                }
            }

            return templist;
        }
        private void openDisplayChartForms(string[] arrayofFilenames, List<List<aCandleStick>> allCandlesticks)
        {
            for (int i = 0; i < arrayofFilenames.Length; i++)
            {
                DisplayGraphForm newForm = new DisplayGraphForm(arrayofFilenames[i], allCandlesticks[i], LoaddateTimePicker_startDate, LoaddateTimePicker_endDate);
                newForm.Show();
            }
        }
        private void button_Load_Click(object sender, EventArgs e)
        {
            LoadButtonOpenFileDialog.ShowDialog();
        }
    }
}
