namespace R2357.Debug {

    /// <summary>
    /// Output log to console
    /// </summary>
    public static class Print {

        /// <summary>
        /// Output normal log.
        /// </summary>
        /// <param name="message"></param>
        public static void Log(object message) {
            UnityEngine.Debug.Log(message);
            return;
        }

        /// <summary>
        /// Output normal logs.
        /// </summary>
        /// <param name="messages"></param>
        public static void Log(params object[] messages) {
            foreach(var m in messages) {
                UnityEngine.Debug.Log(m);
            }
            return;
        }

        /// <summary>
        /// Output warning log.
        /// </summary>
        /// <param name="message"></param>
        public static void Warning(object message) {
            UnityEngine.Debug.LogWarning(message);
            return;
        }

        /// <summary>
        /// Output warning logs.
        /// </summary>
        /// <param name="message"></param>
        public static void Warning(params object[] message) {
            foreach(var m in message) {
                UnityEngine.Debug.LogWarning(m);
            }
            return;
        }

        /// <summary>
        /// Output error log.
        /// </summary>
        /// <param name="message"></param>
        public static void Error(object message) {
            UnityEngine.Debug.LogError(message);
            return;
        }

        /// <summary>
        /// Output error logs.
        /// </summary>
        /// <param name="message"></param>
        public static void Error(params object[] message) {
            foreach(var m in message) {
                UnityEngine.Debug.LogError(m);
            }
            return;
        }
    }
}