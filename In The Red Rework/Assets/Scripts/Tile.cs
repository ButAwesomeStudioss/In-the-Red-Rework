using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Events;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _baseColor, _offsetColor;
    [SerializeField] private SpriteRenderer _renderer;
    public GameObject thing;
public UnityEvent bought;
public int moneyvalue;
MoneyChanges moneymang;
    public void Init(bool isOffset)
    {
        _renderer.color = isOffset ? _offsetColor : _baseColor;

    }
private void OnMouseOver() {
            
   
 if(Input.GetMouseButtonDown(0) & moneyvalue >=50){
 bought.Invoke();
 gameObject.tag = "Placed tile";
 GameObject clone;
            clone = Instantiate(thing, gameObject.transform.position, gameObject.transform.rotation);

}
}
private void Update() {
    moneymang = GameObject.FindGameObjectWithTag("Can I talk to the manager").GetComponent<MoneyChanges>();

      moneyvalue = moneymang.MoneyAmount;

}
}
  
               
 



