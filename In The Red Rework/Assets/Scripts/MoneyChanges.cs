using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyChanges : MonoBehaviour
{
   public int MoneyAmount;
    public Text moneytext;
    
   public void Sold()
    {
        MoneyAmount += 100;
    }
    public void Bought()
    {
        if (MoneyAmount >= 50)
        {
            MoneyAmount -= 50;
        }
    }
    public void PlacedConveyor()
    {
        if (MoneyAmount >= 25)
        {
            MoneyAmount -= 25;
        }
    }
}
