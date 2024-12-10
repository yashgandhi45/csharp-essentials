namespace Generics
{
    // DiscountCalculator is a generic class that works with any type of Product or its subclasses.
    // The "where TProduct : Product" constraint ensures that TProduct is of type Product or a subclass of Product.
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        // Method to calculate a discount for a product based on its price.
        public float CalculateDiscount(TProduct product)
        {
            return product.Price * 0.1f; // Applying a 10% discount.
        }

        // Another method that works with the TProduct type, for example, a Book.
        public float CheckHere(TProduct product)
        {
            return product.Price; // Simply returns the price of the product.
        }
    }
    // Book is a subclass of Product, inheriting the properties of Product.
    public class Book : Product
    {
        public string Isbn { get; set; } // ISBN property for the Book class.
    }
}

