using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_1
{
    //This class specializes in recognizing the Hammer candlestick pattern
    internal class HammerRecognizer : Recognizer
    {
        //Constructor to initialize the pattern size and name
        public HammerRecognizer() : base(1, "Hammer")
        {

        }

        //Override the recognizePattern method to recognize specific candlestick pattern
        protected override Boolean recognizePattern(List<smartCandleStick> scsl)
        {
            return scsl[0].isHammer;
        }
    }
}
