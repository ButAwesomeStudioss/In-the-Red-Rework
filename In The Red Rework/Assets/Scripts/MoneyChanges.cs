using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyChanges : MonoBehaviour
{
    public static MoneyChanges instance;
   public int MoneyAmount = 250;
    public TMP_Text moneytext;
    
    
     
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
     private void Update() 
    {
        moneytext.text = "Money: " + MoneyAmount.ToString();
    }
}
