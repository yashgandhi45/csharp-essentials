namespace Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Delegates are objects that know how to call a method (or a group of methods).
            // They allow us to treat methods as first-class citizens and pass them around as parameters.
            // Use Case: Delegates are ideal when you want to design extensible and flexible applications, 
            // especially when working with events or callback methods.

            Console.WriteLine("Hello, World!");

            // Create a processor for photo processing
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            // Action<Photo> is a delegate that points to methods that take a Photo parameter and return void
            Action<Photo> fileHandler = filters.ApplyBrightness;  // Assign ApplyBrightness to the delegate
            fileHandler += filters.ApplyContrast;  // Add ApplyContrast method to the delegate chain
            fileHandler += RemoveRedEyeFilter;  // Add custom RemoveRedEyeFilter to the delegate chain

            // Pass the fileHandler delegate to the PhotoProcessor to apply the filters
            processor.Process("photo.jpg", fileHandler);
        }

        // A simple method to apply the "Remove RedEye" filter to a photo.
        // This method matches the signature expected by the Action<Photo> delegate.
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Applied Remove RedEye");
        }

        // **Use Interface or Delegate?**
        // Use delegates when you want to implement event-based systems or callbacks.
        // Delegates are useful when you want to pass methods as parameters, especially in event-driven programming.
        //
        // Use an Interface when you want to define a contract that a class must adhere to. 
        // Interfaces are more rigid and useful when designing systems where multiple classes need to 
        // implement the same set of methods.
        // 
        // **When to use Delegates:**
        // - When you need to allow a method or group of methods to be invoked in response to an event.
        // - When flexibility is required, such as passing different methods at runtime.
    }
}
