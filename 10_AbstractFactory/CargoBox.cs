using System;

public class CargoBox : ICargo
{
    public void Open()
    {
        Console.WriteLine("Eu sou uma caixa aberta.");
    }
}

