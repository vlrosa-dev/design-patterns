using System;
using System.Collections.Generic;
using System.Text;


public class PlatinumHolder : CardHolder
{
    public override ICreditCard GetCard()
    {
        return new PlatinumCard();
    }
}

