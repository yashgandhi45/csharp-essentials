namespace Delegates
{
    public class PhotoFilters
    {
        // Method to apply brightness to the photo
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply Brightness");
        }

        // Method to apply contrast to the photo
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply Contrast");
        }

        // Method to resize the photo
        public void Resize(Photo photo)
        {
            Console.WriteLine("Apply Resize");
        }
    }
}
