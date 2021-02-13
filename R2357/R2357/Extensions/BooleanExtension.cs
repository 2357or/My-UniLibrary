using System.Runtime.CompilerServices;

namespace R2357.Extensions {

    /// <summary>
    /// Extension methods (Boolean).
    /// </summary>
    public static class BooleanExtension {

        /// <summary>
        /// [ExtensionMethod] Negates the boolean value.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Not(this ref bool b) {
            return !b;
        }

        /// <summary>
        /// [ExtensionMethod] Swaps the boolean values.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Toggle(this ref bool b) {
            b ^= true;
        }
    }
}