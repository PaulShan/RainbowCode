using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainbow
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colorList = RainbowColors.GetColorsByAppearing();
            colorList.ForEach(s => Console.Write(s + " "));
            Console.WriteLine();
            StringUtil.Alphabetise(colorList).ForEach(s => Console.Write(s + " "));
            Console.WriteLine();

        }
    }
}
