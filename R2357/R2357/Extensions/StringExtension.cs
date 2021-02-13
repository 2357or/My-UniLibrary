using System;

namespace R2357.Extensions {

    /// <summary>
    /// Extension methods (Number).
    /// </summary>
    public static class StringExtension {

        /// <summary>
        /// [ExtensionMethod] Returns the smallest element of the list.
        /// </summary>
        public static char MaxElement(this string str) {
            if(str.Length == 0 || str == null) throw new ArgumentNullException();
            char ret = str[0];
            foreach(char x in str) if(x > ret) ret = x;
            return ret;
        }
    }
}
