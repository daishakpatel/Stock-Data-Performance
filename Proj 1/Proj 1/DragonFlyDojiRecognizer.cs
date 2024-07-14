using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_1
{
    //This class specializes in recognizing the DragonFlyDoji candlestick pattern
    internal class DragonFlyDojiRecognizer : Recognizer
    {
        //Constructor to initialize the pattern size and name
        public DragonFlyDojiRecognizer() : base(1, "DragonFlyDoji")
        {

        }

        //Override the recognizePattern method to recognize specific candlestick pattern
        protected override Boolean recognizePattern(List<smartCandleStick> scsl)
        {
            return scsl[0].isDragonFlyDoji;
        }
    }
}
