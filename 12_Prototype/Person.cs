using System;

public class Person : IPrototype
{
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }
    public string Name { get; set; }
    public Address Address { get; set; }
    public void Print()
    {
        Console.WriteLine($"Age:{Age}, Birth:{BirthDate}, Name:{Name}, Addres:{Address}");
    }

    public IPrototype ShallowCopy()
    {
        return (Person)this.MemberwiseClone();
    }
    public IPrototype Clone()   //DeepCopy
    {
        Person clone = (Person)this.MemberwiseClone();
        clone.Name = string.Copy(Name);
        clone.Address = new Address(Address.Street);

        return clone;
    }
    
}
