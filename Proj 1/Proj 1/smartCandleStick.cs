using Proj_1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Proj_1
{
    // Define a class 'smartCandleStick' that inherits from 'aCandleStick'
    internal class smartCandleStick : aCandleStick
    {
        // Properties to store additional information about the candlestick
        public Decimal range { get; set; }

        public Decimal bodyRange { get; set; }

        public Decimal topPrice { get; set; }

        public Decimal bottomPrice { get; set; }

        public Decimal topTail { get; set; }

        public Decimal bottomTail { get; set; }


        static Decimal dojiBuffer = 0.02M;

        // Boolean properties to identify various candlestick patterns
        public Boolean isBullish { get; set; }
        public Boolean isBearish { get; set; }
        public Boolean isNeutral { get; set; }
        public Boolean isMarubozu { get; set; }
        public Boolean isDoji { get; set; }
        public Boolean isDragonFlyDoji { get; set; }
        public Boolean isGraveStoneDoji { get; set; }
        public Boolean isHammer { get; set; }
        public Boolean isInvertedHammer { get; set; }

        // Constructor that initializes the smartCandleStick using an 'aCandleStick' object
        public smartCandleStick(aCandleStick cs) : base(cs.date, cs.open, cs.high, cs.low, cs.close, cs.volume)
        {
            computeHigherProperties();
            computePatterns();
        }

        // Method to compute higher-level properties of the candlestick
        void computeHigherProperties()
        {
            range = high - low;
            bodyRange = Math.Abs(open - close);
            topPrice = Math.Max(open, close);
            bottomPrice = Math.Min(open, close);
            topTail = Math.Max(high - topPrice, 0);
            bottomTail = Math.Max(bottomPrice - low, 0);
        }

        // Method to compute various candlestick patterns
        void computePatterns()
        {
            isBullish = isBullishcs();
            isBearish = isBearishcs();
            isNeutral = isNeutralcs();
            isMarubozu = isMarubozucs();
            isDoji = isDojics();
            isDragonFlyDoji = isDragonFlyDojics();
            isGraveStoneDoji = isGraveStoneDojics();
            isHammer = isHammercs();
            isInvertedHammer = isInvertedHammercs();
        }

        // Method to check if the candlestick is bullish
        Boolean isBullishcs()
        {
            return open < close;
        }

        // Method to check if the candlestick is bearish
        Boolean isBearishcs()
        {
            return open > close;
        }

        // Method to check if the candlestick is neutral
        Boolean isNeutralcs()
        {
            return bodyRange >= 0.05M * range && bodyRange <= 0.25M * range;
        }

        // Method to check if the candlestick is a marubozu
        Boolean isMarubozucs()
        {
            return Math.Abs(bodyRange - range) <= 0.01M * open;
        }

        // Method to check if the candlestick is a doji
        Boolean isDojics()
        {
            return bodyRange <= dojiBuffer * open;
        }

        // Method to check if the candlestick is a dragonfly doji
        Boolean isDragonFlyDojics()
        {
            return isDoji && topTail <= dojiBuffer * range;
        }

        // Method to check if the candlestick is a gravestone doji
        Boolean isGraveStoneDojics()
        {
            return isDoji && bottomTail <= dojiBuffer * range;
        }

        // Method to check if the candlestick is a hammer
        Boolean isHammercs()
        {
            return topTail <= 0.1M * range && bodyRange >= 0.15M * range && bodyRange <= 0.35M * range;
        }

        // Method to check if the candlestick is an inverted hammer
        Boolean isInvertedHammercs()
        {
            return bottomTail <= 0.1M * range && bodyRange >= 0.15M * range && bodyRange <= 0.35M * range;
        }
    }
}
