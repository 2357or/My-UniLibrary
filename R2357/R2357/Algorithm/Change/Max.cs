using System.Runtime.CompilerServices;

namespace R2357.Algorithm {

    /// <summary>
    /// Change the value.
    /// </summary>
    public static partial class Change {

        /// <summary>
        /// Update to the maximum value(int).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Max(ref int a, int b) {
            if(a < b) {
                a = b;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Update to the maximum value(uint).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Max(ref uint a, uint b) {
            if(a < b) {
                a = b;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Update to the maximum value(long).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Max(ref long a, long b) {
            if(a < b) {
                a = b;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Update to the maximum value(ulong).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Max(ref ulong a, ulong b) {
            if(a < b) {
                a = b;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Update to the maximum value(short).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Max(ref short a, short b) {
            if(a < b) {
                a = b;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Update to the maximum value(ushort).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Max(ref ushort a, ushort b) {
            if(a < b) {
                a = b;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Update to the maximum value(byte).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Max(ref byte a, byte b) {
            if(a < b) {
                a = b;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Update to the maximum value(char).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Max(ref char a, char b) {
            if(a < b) {
                a = b;
                return true;
            }
            return false;
        }

    }
}