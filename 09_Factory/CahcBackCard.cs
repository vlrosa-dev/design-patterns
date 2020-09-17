public class CashBackCard : ICreditCard
{
    private int _balance;
    private int _charge;
    private int _limit;
    public CashBackCard()
    {
        _limit = 1000;
        _balance = 0;
        _charge = 5;
    }
    public string CardType => "CASHBACK";
    public int CreditLimit
    {
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