using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bio_Entry
{
    public static class Themecolors
    {
        public static Color PrimaryColor {  get; set; }
        public static Color SecondaryColor { get; set; }

        public static List<string> ColorList = new List<string>()
        {
                       "Darkgoldenrod",
                       "Darkgoldenrod"
        };


        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red = red * correctionFactor;
                green = green * correctionFactor;
                blue = blue * correctionFactor;
            }

            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
