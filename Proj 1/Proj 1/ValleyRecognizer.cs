using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_1
{
    //This class specializes in recognizing the Valley candlestick pattern
    internal class ValleyRecognizer : Recognizer
    {
        //Constructor to initialize the pattern size and name
        public ValleyRecognizer() : base(3, "Valley")
        {

        }

        //Override the recognizePattern method to recognize specific candlestick pattern
        protected override Boolean recognizePattern(List<smartCandleStick> scsl)
        {
            return (scsl[1].low < scsl[0].low && scsl[1].low < scsl[2].low);
        }
    }
}
