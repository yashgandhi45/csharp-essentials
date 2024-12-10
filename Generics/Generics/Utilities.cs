namespace Generics
{
    // Utility class demonstrating how constraints can be applied to generics.
    // The "where T : IComparable" constraint ensures that T must implement IComparable interface.
    public class Utilities<T> where T : IComparable
    {
        // Method to compare two integers and return the larger one.
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // Generic method to compare two values of type T and return the larger one.
        // T must implement IComparable to enable the comparison.
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}

