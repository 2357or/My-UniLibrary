namespace R2357.Algorithm {

    /// <summary>
    /// Base class for a sinple wrapping properties.
    /// </summary>
    public abstract class PropertyWrapper<T> : IPropertyWrapper<T> {
        private readonly T initalValue;

        /// <summary>
        /// [Constructor] Create default Property object.
        /// </summary>
        public PropertyWrapper() : this(default) { }

        /// <summary>
        /// [Constructor] Create default Property object and set initalValue.
        /// </summary>
        public PropertyWrapper(T initalValue) {
            this.initalValue = initalValue;
        }

        /// <summary>
        /// Return initalaize value.
        /// </summary>
        public T InitialValue() {
            return initalValue;
        }

        /// <summary>
        /// Return getter action (delegate).
        /// </summary>
        public abstract PropertyAction<T> GetAction();

        /// <summary>
        /// Return setter action (delegate).
        /// </summary>
        public abstract PropertyAction<T> SetAction();
    }
}