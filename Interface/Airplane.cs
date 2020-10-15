using System;
public class Airplane : IFlyingTransport
{
    public void fly(string origin, string destiny, int passengers){
        Console.WriteLine("Avião Decolando!");
    }
}