public class Address
{
    public Address(string street, int cep)
    {
        Street = street;
        Cep = cep;
    }
    public string Street { get; set; }
    public int Cep { get; set; }
}
