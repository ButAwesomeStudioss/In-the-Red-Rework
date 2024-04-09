using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragger : MonoBehaviour
{
    private bool dragging;
    
    void Update() {
if(!dragging) return;
    
 var mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);

 transform.position = mousePosition;
    }
    
    void OnMouseDown () {
dragging = true;
}



}
