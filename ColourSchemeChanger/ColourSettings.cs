using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColourSchemeChanger
{
    public class ColourSettings
    {
        static public string colourOne = "0,0,0";
        static public string ColourTwo = "255,255,255";

        public static Color ConvertToColour(string colorString)
        {
            var colorParts = colorString.Split(',');
            int r = int.Parse(colorParts[0].Trim());
            int g = int.Parse(colorParts[1].Trim());
            int b = int.Parse(colorParts[2].Trim());
            return Color.FromArgb(r, g, b);
        }

    }
}
