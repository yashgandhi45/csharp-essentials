namespace EventsandDelegates
{
    // VideoEncoder is the "publisher" class that raises an event when a video is encoded.
    public class VideoEncoder
    {
        // 1. Define a Delegate: The delegate defines the signature of methods that can handle the event.
        // This delegate will point to methods that match the (object, EventArgs) signature.
        public delegate void VideoEncodedEventHandler(object source, EventArgs e);

        // 2. Define an Event: The event uses the delegate to create a mechanism for subscribers to 
        // listen for the event. When the event is raised, the delegate will be invoked.
        public event VideoEncodedEventHandler VideoEncoded;

        // Method to simulate video encoding
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000); // Simulate time-consuming video encoding process (3 seconds)
            OnVideoEncoded();   // 3. Raise the Event after encoding is complete
        }

        // Protected method to raise the event.
        // The 'virtual' keyword allows this method to be overridden in derived classes if needed.
        protected virtual void OnVideoEncoded()
        {
            // Before raising the event, we check if there are any subscribers to the event.
            // If the event is not null, it means there are subscribers, and we can invoke it.
            if (VideoEncoded != null)
            {
                // Raise the event by calling the delegate with the appropriate parameters.
                // 'this' refers to the current instance of VideoEncoder, which is the source of the event.
                VideoEncoded(this, EventArgs.Empty); // EventArgs.Empty because no additional data is needed.
            }
        }
    }
}
