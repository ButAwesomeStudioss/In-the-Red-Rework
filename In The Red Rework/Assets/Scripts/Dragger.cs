using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragger : MonoBehaviour
{
    
    private bool dragging;
    
    private Vector2 offset;
    
    private EndSlot Slot;
    public void init(EndSlot slot) {

    }


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
if(Vector2.Distance(transform.position,Slot.transform.position)< 3) {
    transform.position = Slot.transform.position;
    
}
else {
    transform.position = transform.position;
dragging = false;
}



}

Vector2 GetMousePos(){
return Camera.main.ScreenToWorldPoint(Input.mousePosition);
}
}
