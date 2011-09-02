using System;
using System.Collections.Generic;
using System.Text;

namespace DVDPostTools
{
    public class ClsString
    {
        public static string Capitalize(string value)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
        }


    }
}
