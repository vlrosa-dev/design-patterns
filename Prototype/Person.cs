using System;

public class Person
{
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }
    public string Name { get; set; }
    public Address Address { get; set; }
    public void Print()
    {
        Console.WriteLine($"Age:{Age}, Birth:{BirthDate}, Name:{Name}, Addres:{Address.Street}");
    }

    public Person ShallowCopy()
    {
        return (Person)this.MemberwiseClone();
    }
    public Person Clone()   //DeepCopy
    {
        Person clone = (Person)this.MemberwiseClone();
        clone.Name = string.Copy(Name);
        clone.Address = new Address(Address.Street, Address.Cep);

        return clone;
    }
    
}
