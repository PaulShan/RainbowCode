using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainbow
{
    public static class RainbowColors
    {
        public static List<string> GetColorsByAppearing()
        {            
            return colorListByAppearing;
        }


        static List<string> colorListByAppearing = new List<string> { "Red", "Orange", "Yellow", "Green", "Indigo", "Violet" };
    }
}
