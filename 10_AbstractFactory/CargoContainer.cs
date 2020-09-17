using System;


public class CargoContainer : ICargo
{
    public void Open()
    {
        Console.WriteLine("Eu sou um container aberto.");
    }
}
