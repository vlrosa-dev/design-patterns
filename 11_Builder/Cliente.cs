using System;
using System.Collections.Generic;
using System.Text;

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
