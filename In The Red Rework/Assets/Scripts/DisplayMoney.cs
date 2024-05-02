using UnityEngine;
using UnityEngine.UI;

public class DisplayMoney : MonoBehaviour
{
    public GameObject UiObject;
    public TextMesh MoneyCount;

    public object CoinCount { get; private set; }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CoinCount")
        {
            UiObject.SetActive(true);
            gameObject.name = "100";
        }
    }
}