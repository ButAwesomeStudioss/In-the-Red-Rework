using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragger : MonoBehaviour
{
    
    private bool dragging;
    
    private Vector2 offset;
    
    public EndSlot EndSlot;

    void Update() {
if(!dragging) return;
    
 var mousePosition = GetMousePos();

 transform.position = mousePosition - offset;
    }
   
    void OnMouseDown () {
dragging = true;
offset = GetMousePos() - (Vector2)transform.position;
}


void OnMouseUp(){
if(transform.position.Equals(EndSlot.transform.position)){


    
        transform.position = transform.position;
dragging = false;
    
}

}

Vector2 GetMousePos(){
return Camera.main.ScreenToWorldPoint(Input.mousePosition);
}
}
