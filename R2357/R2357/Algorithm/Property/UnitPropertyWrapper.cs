namespace R2357.Algorithm {

    /// <summary>
    /// Property object initialized from delegate
    /// </summary>
    public sealed class UnitPropertyWrapper<T> : IPropertyWrapper<T> {
        private readonly T initialValue;
        private readonly PropertyAction<T> getAction, setAction;

        /// <summary>
        /// [Constructor] Create property object using value and delegate.
        /// </summary>
        public UnitPropertyWrapper(T initialValue, PropertyAction<T> getAction, PropertyAction<T> setAction) {
            this.initialValue = initialValue;
            this.getAction = getAction ?? (x => x);
            this.setAction = setAction ?? (x => x);
        }

        /// <summary>
        /// Return initialize value.
        /// </summary>
        public T InitialValue() {
            return initialValue;
        }

        /// <summary>
        /// Getter.
        /// </summary>
        public T GetAction(T value) {
            return getAction(value);
        }

        /// <summary>
        /// Setter.
        /// </summary>
        public T SetAction(T value) {
            return setAction(value);
        }
    }
}