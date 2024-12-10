namespace EventsandDelegates
{
    public class Program
    {
        // This is where we demonstrate the usage of events and delegates.
        static void Main(string[] args)
        {
            // Creating an instance of a Video object. This video will be encoded.
            var video = new Video() { Title = "Video 1" };

            // Creating an instance of VideoEncoder, which is the "publisher" of the event.
            var videoEncoder = new VideoEncoder(); // Publisher

            // Creating an instance of MailService, which will act as the "subscriber" to the event.
            var mailService = new MailService(); // Subscriber

            // Subscribe to the VideoEncoded event. This tells the VideoEncoder to call the
            // OnVideoEncoded method of MailService when the event is raised.
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            // Start encoding the video. Once the encoding is finished, the event will be triggered.
            videoEncoder.Encode(video);
        }

        // Explanation of the key concepts:
        // - The VideoEncoder class will "publish" an event named VideoEncoded.
        // - The MailService class will "subscribe" to that event, meaning it will listen for when
        //   the event is triggered, and it will execute the corresponding handler (method) when it happens.

        // This demonstrates the decoupling between the video encoding and the email notification processes.
        // The VideoEncoder (publisher) doesn't need to know anything about the MailService (subscriber).
        // It simply triggers the event, and MailService will respond to it.
    }
}