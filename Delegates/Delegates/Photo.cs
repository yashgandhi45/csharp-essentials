namespace Delegates
{
    public class Photo
    {
        // Static method to simulate loading a photo from a file path.
        public static Photo Load(string path)
        {
            return new Photo();
        }

        // Method to simulate saving the photo.
        public void Save()
        {
            Console.WriteLine("Photo saved!");
        }
    }
}
