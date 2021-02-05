namespace R2357.Extensions {

    /// <summary>
    /// Extension methods (Number).
    /// </summary>
    public static class StringExtension {

        /// <summary>
        /// [ExtensionMethod] Returns the smallest element of the list.
        /// </summary>
        public static char MaxElement(this string str) {
            char ret = str[0];
            foreach(char x in str) if(x > ret) ret = x;
            return ret;
        }
    }
}
