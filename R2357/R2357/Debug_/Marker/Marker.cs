namespace R2357.Debug {

    /// <summary>
    /// Markers used to check the reach of the code.
    /// </summary>
    public static class Marker {
        private const string _reachedTheMarker = "<size=10>reached the Marker : </size>";
        private const string _comment = "<size=10>comment: </size>";

        /// <summary>
        /// Red marker.
        /// </summary>
        public static void RED(string comment="") {
            UnityEngine.Debug.Log(_reachedTheMarker + "<color=#ff0000ff><b><size=15>R E D</size></b></color>" + _comment + comment);
        }

        /// <summary>
        /// Blue marker.
        /// </summary>
        public static void BLUE(string comment = "") {
            UnityEngine.Debug.Log(_reachedTheMarker + "<color=#0000ffff><b><size=15>B L U E</size></b></color>" + _comment + comment);
        }

        /// <summary>
        /// Green marker.
        /// </summary>
        public static void GREEN(string comment = "") {
            UnityEngine.Debug.Log(_reachedTheMarker + "<color=#008000ff><b><size=15>G R E E N</size></b></color>" + _comment + comment);
        }

        /// <summary>
        /// Yellow marker.
        /// </summary>
        public static void YELLOW(string comment = "") {
            UnityEngine.Debug.Log(_reachedTheMarker + "<color=#ffff00ff><b><size=15>Y E L L O W</size></b></color>" + _comment + comment);
        }

        /// <summary>
        /// White marker.
        /// </summary>
        public static void WHITE(string comment = "") {
            UnityEngine.Debug.Log(_reachedTheMarker + "<color=#ffffffff><b><size=15>W H I T E</size></b></color>" + _comment + comment);
        }

        /// <summary>
        /// Black marker.
        /// </summary>
        public static void BLACK(string comment = "") {
            UnityEngine.Debug.Log(_reachedTheMarker + "<color=#000000ff><b><size=15>B L A C K</size></b></color>" + _comment + comment);
        }
    }
}