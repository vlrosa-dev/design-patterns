using System;
public class Email
{
    public string To { get; set; }
    public string From { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public string Anexo { get; set; }

    public void Send()
    {
        Console.WriteLine($"Sending e-mail to: {To}, with Subject: {Subject} ");
    }
}