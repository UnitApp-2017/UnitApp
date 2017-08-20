using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitApp.Helpers
{
    public static class StringExtension
    {
        public static string Quoted(this string str)
        {
            return "\"" + str + "\"";
        }
    }
}