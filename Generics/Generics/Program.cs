namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Using a generic List to store integers, avoiding code duplication for each type.
            Console.WriteLine("Hello, World!");
            var numbers = new List<int>(); // List<int> is a generic collection to store integers.
            numbers.Add(1); // Adding an integer to the list.

            // Using a generic dictionary with string keys and integer values.
            var dictionary = new GenericDictionary<string, int>(); // A generic dictionary with string keys and int values.
            dictionary.Add("a", 1); // Adding a key-value pair to the dictionary.

            // Using the custom Nullable<T> type to store nullable value types.
            var nullableInt = new Nullable<int>(42); // Creating a nullable integer with a value of 42.
            Console.WriteLine(nullableInt.HasValue); // Checking if the nullable integer has a value (True).
            Console.WriteLine(nullableInt.GetValueorDefault()); // Retrieving the value or default (42).
        }
    }

    // Generic class for a list that works with any type (T).
    public class GenericList<T>
    {
        // Method to add an item of type T to the list.
        public void Add(T item) { }

        // Indexer to access the item at a specific index in the list.
        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    // Generic dictionary class that takes a key of type TKey and a value of type TValue.
    public class GenericDictionary<TKey, TValue>
    {
        // Method to add a key-value pair to the dictionary.
        public void Add(TKey key, TValue value) { }
    }
}
