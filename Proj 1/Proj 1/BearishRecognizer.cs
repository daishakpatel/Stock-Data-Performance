using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_1
{
    //This class specializes in recognizing the Bearish candlestick pattern
    internal class BearishRecognizer : Recognizer
    {
        //Constructor to initialize the pattern size and name
        public BearishRecognizer() : base(1, "Bearish")
        {

        }

        //Override the recognizePattern method to recognize specific candlestick pattern
        protected override Boolean recognizePattern(List<smartCandleStick> scsl)
        {
            return scsl[0].isBearish;
        }
    }
}
