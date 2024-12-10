namespace Generics
{
    // Nullable<T> class simulating nullable value types (only for value types like int, float, etc.).
    // The "where T : struct" constraint ensures T is a value type (like int, float, etc.).
    public class Nullable<T> where T : struct
    {
        private object _value; // A private field to store the value of type T.

        // Default constructor for Nullable<T>.
        public Nullable() { }

        // Constructor that initializes the value of type T.
        public Nullable(T value)
        {
            _value = value;
        }

        // Property to check if the value has been set.
        public bool HasValue
        {
            get { return _value != null; } // If _value is not null, HasValue returns true.
        }

        // Method to get the value or return the default value of T if HasValue is false.
        public T GetValueorDefault()
        {
            if (HasValue) return (T)_value; // Return the value if it exists.
            return default(T); // Return default value for T (e.g., 0 for int, null for reference types).
        }
    }
}

