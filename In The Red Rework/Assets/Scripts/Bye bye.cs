using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Byebye : MonoBehaviour
{
    public GameObject Inventory;

    void Start()
    {
        Inventory.gameObject.SetActive(false);
    }

    
    public void Switch()
    {
        if (Inventory.activeSelf == false) Inventory.SetActive(true);
        else Inventory.SetActive(false);
    }
}
