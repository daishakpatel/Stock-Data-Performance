using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_1
{
    //This class specializes in recognizing the Peak candlestick pattern
    internal class PeakRecognizer : Recognizer
    {
        //Constructor to initialize the pattern size and name
        public PeakRecognizer() : base(3, "Peak")
        {

        }

        //Override the recognizePattern method to recognize specific candlestick pattern
        protected override Boolean recognizePattern(List<smartCandleStick> scsl)
        {
            return (scsl[1].high > scsl[0].high && scsl[1].high > scsl[2].high);
        }
    }
}
