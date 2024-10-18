

public class Message {
    public string? MessageText { get; set; }

    public Message(string message) => (MessageText) = (message);

    public void printMessage() 
    {
        Console.WriteLine($"Message: {MessageText}");
    }

}

// USING PRIMARY CONSTRUCTOR
// Feature 'primary constructors' is not available in C# 11.0. Please use language version 12.0 or greater.
// public class MessageApp(string user, string message)
// {
// }