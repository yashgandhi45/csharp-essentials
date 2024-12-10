namespace EventsandDelegates
{
    // MailService is the "subscriber" class that reacts to the event raised by VideoEncoder.
    public class MailService
    {
        // The method signature must match the delegate's signature (object, EventArgs).
        // This is the method that will be called when the event is raised.
        public void OnVideoEncoded(object source, EventArgs e)
        {
            // This method is triggered when the VideoEncoded event is raised.
            // In this example, it sends an email notification about the video encoding.
            Console.WriteLine("MailService: Sending an email notification...");
        }
    }
}