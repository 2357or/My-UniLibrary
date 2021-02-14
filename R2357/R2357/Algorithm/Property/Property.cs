using System;
using UnityEngine;

namespace R2357.Algorithm {

    /// <summary>
    /// It has a public property named `Value`.
    /// </summary>
    public interface IProperty<T> {
        /// <summary>
        /// Wrapped property.
        /// </summary>
        public T Value { get; set; }
    }

    /// <summary>
    /// Process wrapping with properties.
    /// </summary>
    public delegate T PropertyAction<T>(T action);


    /// <summary>
    /// Functions required to wrap property.
    /// </summary>
    public interface IPropertyWrapper<T> {
        /// <summary>
        /// Return initalaize value.
        /// </summary>
        public T InitialValue();

        /// <summary>
        /// Return getter action (delegate).
        /// </summary>
        public PropertyAction<T> GetAction();

        /// <summary>
        /// Return setter action (delegate).
        /// </summary>
        /// <returns></returns>
        public PropertyAction<T> SetAction();
    }

    /// <summary>
    /// Wrapped Property.
    /// </summary>
    [Serializable]
    public sealed class Property<T> : IProperty<T> {
        [SerializeField]
        private T value = default;

        [NonSerialized]
        private PropertyAction<T> GetAction;

        [NonSerialized]
        private PropertyAction<T> SetAction;

        /// <summary>
        /// Wrapped property.
        /// </summary>
        public T Value {
            get {
                return GetAction(value);
            }
            set {
                this.value = SetAction(value);
            }
        }

        /// <summary>
        /// [Constructor] Create default Property object.
        /// </summary>
        public Property() : this(default, null, null) { }

        /// <summary>
        /// [Constructor] Create Property object using a class(inherit IPropertyWrapper).
        /// </summary>
        public Property(IPropertyWrapper<T> propertyWrapper) : this(propertyWrapper.InitialValue(), propertyWrapper.GetAction(), propertyWrapper.SetAction()) { }

        /// <summary>
        /// [Constructor] Create default Property object and set initalValue.
        /// </summary>
        public Property(T initialValue) : this(initialValue, null, null) { }

        /// <summary>
        /// [Constructor] Create Property object using the elements that make it up.
        /// </summary>
        public Property(T initialValue, PropertyAction<T> getAction, PropertyAction<T> setAction) {
            this.value = initialValue;
            this.GetAction = getAction ?? (x => x);
            this.SetAction = setAction ?? (x => x);
        }

        /// <summary>
        /// Return a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString() {
            return value?.ToString() ?? "(null)";
        }
    }
}