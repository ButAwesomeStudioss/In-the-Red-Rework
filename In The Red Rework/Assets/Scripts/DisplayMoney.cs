using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMoney : MonoBehaviour
{
    private Text MoneyCount;

    void Start()
    {
        MoneyCount = GetComponent<Text>();
    }
    void Update()
    {
        string[] temp = MoneyCount.text.Split('$');
        MoneyCount.text = temp[0] + "$" + MoneyScript.money;
    }
}
