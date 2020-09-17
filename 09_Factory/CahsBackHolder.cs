using System;
using System.Collections.Generic;
using System.Text;

public class CahsBackHolder : CardHolder
{
    public override ICreditCard GetCard()
    {
        return new CashBackCard();
    }
}
