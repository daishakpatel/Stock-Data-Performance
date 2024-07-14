using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_1
{
    //This is an abstract base class representing a candlestick pattern recognizer
    abstract internal class Recognizer
    {
        //Properties to store pattern size and name
        public int patternSize;
        public string patternName;

        //Constructor to initialize pattern size and name
        public Recognizer(int patternSize, string patternName)
        {
            this.patternSize = patternSize;
            this.patternName = patternName;
        }

        //Abstract method to be implemented by derived classes to recognize specific patterns
        protected abstract Boolean recognizePattern(List<smartCandleStick> scsl);

        //Method to recognize patterns within a list of smartCandleStick objects and return a list of indexes where the pattern was recognized
        public List<int> recognizePatterns(List<smartCandleStick> scsl)
        {
            List<int> recognizedIndexes = new List<int>();

            //Loop through the smartCandleStick list to find patterns
            for (int i = patternSize - 1; i < scsl.Count; i++)
            {
                List<smartCandleStick> subscsl = scsl.GetRange(i - patternSize + 1, patternSize);

                //Check if the pattern is recognized in the sublist
                if (recognizePattern(subscsl))
                {
                    recognizedIndexes.Add(i);
                }
            }

            //Return the list of recognized indexes
            return recognizedIndexes;
        }
    }
}
