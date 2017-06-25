using System;

namespace TypeDown.Util
{
    public static class Page
    {
        public static string NameFromType(this Type type)
        {
            return type.Name.Replace("Page", "");
        } 
    }
}
