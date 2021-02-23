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
        /// Return initialize value.
        /// </summary>
        public T InitialValue();

        /// <summary>
        /// Getter.
        /// </summary>
        public T GetAction(T value);

        /// <summary>
        /// Setter.
        /// </summary>
        /// <returns></returns>
        public T SetAction(T value);
    }

    /// <summary>
    /// Wrapped Property.
    /// </summary>
    [Serializable]
    public sealed class Property<T> : IProperty<T> {
        [SerializeField]
        private T value = default;

        [NonSerialized]
        private readonly IPropertyWrapper<T> propertyWrapper;

        /// <summary>
        /// Wrapped property.
        /// </summary>
        public T Value {
            get {
                UnityEngine.Debug.Log("!");
                return propertyWrapper.GetAction(value);
            }
            set {
                this.value = propertyWrapper.SetAction(value);
            }
        }

        /// <summary>
        /// [Constructor] Create default Property object.
        /// </summary>
        public Property() : this(new UnitPropertyWrapper<T>(default, null, null)) { }

        /// <summary>
        /// [CONSTRUCTOR] Create Property object using a class(inherit IPropertyWrapper).
        /// </summary>
        public Property(IPropertyWrapper<T> propertyWrapper) {
            this.propertyWrapper = propertyWrapper;
            value = propertyWrapper.InitialValue();
        }

        /// <summary>
        /// [Constructor] Create default Property object and set initialValue.
        /// </summary>
        public Property(T initialValue) : this(new UnitPropertyWrapper<T>(initialValue, null, null)) { }

        /// <summary>
        /// [Constructor] Create Property object using the elements that make it up.
        /// </summary>
        public Property(T initialValue, PropertyAction<T> getAction, PropertyAction<T> setAction)
            : this(new UnitPropertyWrapper<T>(initialValue, getAction, setAction)) { }

        /// <summary>
        /// Return a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString() {
            return value?.ToString() ?? "(null)";
        }
    }
}