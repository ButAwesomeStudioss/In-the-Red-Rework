using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _baseColor, _offsetColor;
    [SerializeField] private SpriteRenderer _renderer;
    public GameObject thing;

    public void Init(bool isOffset)
    {
        _renderer.color = isOffset ? _offsetColor : _baseColor;

    }
private void OnMouseOver() {
               
 if(Input.GetMouseButtonDown(0)){
 //thing.transform.position = gameObject.transform.position;
 GameObject clone;
            clone = Instantiate(thing, gameObject.transform.position, gameObject.transform.rotation);
}

}
}
  
               
 



