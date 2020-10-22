using System;

public class Cliente
{
    static void Main(string[] args)
    {
        Console.WriteLine("Email BUILDER!");
        var emailBuilder = new EmailBuilder();
        var diretor = new EmailDirector(emailBuilder);

        var email = diretor.Work();

        email.Send();
    }
}
