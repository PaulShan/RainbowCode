using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainbow
{
    public static class StringUtil
    {
        public static List<string> Alphabetise(List<string> words)
        {
            return words.OrderBy(s => s).ToList();
        }
    }
}
