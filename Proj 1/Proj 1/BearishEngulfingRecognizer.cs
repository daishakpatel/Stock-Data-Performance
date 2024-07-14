using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_1
{
    //This class specializes in recognizing the Bearish Engulfing candlestick pattern
    internal class BearishEngulfingRecognizer : Recognizer
    {
        //Constructor to initialize the pattern size and name
        public BearishEngulfingRecognizer() : base(2, "BearishEngulfing")
        {

        }

        //Override the recognizePattern method to recognize specific candlestick pattern
        protected override Boolean recognizePattern(List<smartCandleStick> scsl)
        {
            return (scsl[0].isBullish && scsl[1].isBearish && scsl[0].high < scsl[1].high && scsl[0].low > scsl[1].low);
        }
    }
}
