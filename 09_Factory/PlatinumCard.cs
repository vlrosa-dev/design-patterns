public class PlatinumCard : ICreditCard
{
    private int _balance;
    private int _charge;
    private int _limit;
    public PlatinumCard()
    {
        _limit = 10000;
        _balance = 0;
        _charge = 50;
    }
    public string CardType => "PLATINUM";
    public int CreditLimit {
        get { return _limit; }
        set { _limit = value; } 
    }
    public int AnnualCharge
    {
        get { return _charge; }
        set { _charge = value; }
    }
    public int AccountBalance
    {
        get { return _balance; }
        set { _balance = value; }
    }
}
