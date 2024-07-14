using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_1
{
    //Defines a class named aCandleStick to store the data of a single candlestick
    internal class aCandleStick
    {
        //Define the properties of the class
        public Decimal open { get; set; }
        public Decimal high { get; set; }
        public Decimal low { get; set; }
        public Decimal close { get; set; }
        public long volume { get; set; }
        public DateTime date { get; set; }

        //Con
        //uctor for the class
        public aCandleStick(DateTime date = default, decimal open = 0, decimal high = 0, decimal low = 0, decimal close = 0, long volume = 0)
        {
            this.date = date;
            this.open = open;
            this.high = high;
            this.low = low;
            this.close = close;
            this.volume = volume;
        }

        //Constructor for the class that intializes an object using candlestick data from a string
        public aCandleStick(String rowofData) : this()
        {
            //Split the rowofData string into substrings using the specified separators
            char[] separators = new char[] { ',', ' ', '"', '-' };
            string[] subs = rowofData.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            //Create a dictionary to map the month names to their corresponding numbers
            Dictionary<string, int> map = new Dictionary<string, int>();
            int i = 1;

            map.Add("Jan", i++);
            map.Add("Feb", i++);
            map.Add("Mar", i++);
            map.Add("Apr", i++);
            map.Add("May", i++);
            map.Add("Jun", i++);
            map.Add("Jul", i++);
            map.Add("Aug", i++);
            map.Add("Sep", i++);
            map.Add("Oct", i++);
            map.Add("Nov", i++);
            map.Add("Dec", i++);

            //Create a string that contains the date in the format "YYYY/MM/DD"
            String datestring = subs[4] + "/" + map[subs[2]] + "/" + subs[3];

            Decimal temp;
            DateTime tempDate;
            long tempVolume;

            //Try to parse the substrings into the corresponding data types
            if (DateTime.TryParse(datestring, out tempDate) == true)
                date = tempDate;

            if (Decimal.TryParse(subs[5], out temp) == true)
                open = temp;

            if (Decimal.TryParse(subs[6], out temp) == true)
                high = temp;

            if (Decimal.TryParse(subs[7], out temp) == true)
                low = temp;

            if (Decimal.TryParse(subs[8], out temp) == true)
                close = temp;

            if (long.TryParse(subs[9], out tempVolume) == true)
                volume = tempVolume;
        }
    }
}
