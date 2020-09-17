using System;
using System.Collections.Generic;
using System.Text;

public abstract class CardHolder
{
    public ICreditCard Card { get; set; }

    public void AddLimit(int v)
    {
        Card.CreditLimit = v;
    }
    public void PayAccount(int valorDaConta)
    {
        Card.AccountBalance += valorDaConta;
    }
    public abstract ICreditCard GetCard();
}
