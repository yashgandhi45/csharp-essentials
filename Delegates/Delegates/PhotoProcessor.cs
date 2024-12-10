namespace Delegates
{
    public class PhotoProcessor
    {
        // Process method which takes a photo file path and a delegate that represents a group of filter methods.
        // The Action<Photo> delegate allows methods that operate on a Photo object and return void to be passed.
        public void Process(string path, Action<Photo> fileHandler)
        {
            // Load the photo from the given path
            var photo = Photo.Load(path);

            // Execute the fileHandler delegate, which will apply all assigned filters to the photo
            fileHandler(photo);

            // After filters are applied, save the photo
            photo.Save();
        }
    }
}
