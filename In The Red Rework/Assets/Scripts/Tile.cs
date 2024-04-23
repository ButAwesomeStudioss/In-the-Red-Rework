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
<<<<<<< Updated upstream
    public GameObject thing;
=======
<<<<<<< HEAD
    [SerializeField] private GameObject _highlight;
=======
    public GameObject thing;
>>>>>>> 1ddf971667952cd04184371851d865877f51a319
>>>>>>> Stashed changes

    public void Init(bool isOffset)
    {
        _renderer.color = isOffset ? _offsetColor : _baseColor;

    }

<<<<<<< Updated upstream
=======
<<<<<<< HEAD
    void OnMouseEnter()
    {
        _highlight.SetActive(true);
    }

    void OnMouseExit()
    {
        _highlight.SetActive(false);
    }
=======
>>>>>>> Stashed changes
private void OnMouseOver() {
               
 if(Input.GetMouseButtonDown(0))
 thing.transform.position = gameObject.transform.position;
<<<<<<< Updated upstream
=======
>>>>>>> 1ddf971667952cd04184371851d865877f51a319
>>>>>>> Stashed changes
}
  
               
 
}


