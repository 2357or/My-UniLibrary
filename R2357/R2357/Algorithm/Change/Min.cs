using System.Runtime.CompilerServices;

namespace R2357.Algorithm {

    /// <summary>
    /// Change the value.
    /// </summary>
    public static partial class Change {

        /// <summary>
        /// Update to the minimum value(int).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Min(ref int a, int b) {
            if(a > b) {
                a = b;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Update to the minimum value(uint).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Min(ref uint a, uint b) {
            if(a > b) {
                a = b;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Update to the minimum value(long).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Min(ref long a, long b) {
            if(a > b) {
                a = b;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Update to the minimum value(ulong).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Min(ref ulong a, ulong b) {
            if(a > b) {
                a = b;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Update to the minimum value(short).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Min(ref short a, short b) {
            if(a > b) {
                a = b;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Update to the minimum value(ushort).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Min(ref ushort a, ushort b) {
            if(a > b) {
                a = b;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Update to the minimum value(byte).
        /// </summary>>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Min(ref byte a, byte b) {
            if(a > b) {
                a = b;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Update to the minimum value(char).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Min(ref char a, char b) {
            if(a > b) {
                a = b;
                return true;
            }
            return false;
        }
    }
}