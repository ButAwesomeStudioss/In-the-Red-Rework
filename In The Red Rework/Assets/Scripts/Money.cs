using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyScript : MonoBehaviour
{
    //Money (Uppercase) is the Text String,
    //money (lowercase) is the variable that's changed.
    public const string Money = "Money";
    public static int money = 0;
    void Start()
    {
        money = PlayerPrefs.GetInt("Money");
    }

    public static void UpdateMoney()
    {
        PlayerPrefs.SetInt("Money", money);
        money = PlayerPrefs.GetInt("Coins");
        PlayerPrefs.Save();
    }
}
