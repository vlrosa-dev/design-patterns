public interface ICreditCard
{
    public string CardType { get; }
    public int CreditLimit { get; set; }
    public int AnnualCharge { get; set; }
    public int AccountBalance { get; set; }
}
