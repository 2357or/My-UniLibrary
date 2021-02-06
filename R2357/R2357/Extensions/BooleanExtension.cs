namespace R2357.Extensions {

    /// <summary>
    /// Extension methods (Boolean).
    /// </summary>
    public static class BooleanExtension {

        /// <summary>
        /// [ExtensionMethod] Negates the boolean value.
        /// </summary>
        public static bool Not(this ref bool b) {
            return !b;
        }

        /// <summary>
        /// [ExtensionMethod] Swaps the boolean values.
        /// </summary>
        public static void Toggle(this ref bool b) {
            b ^= true;
        }
    }
}