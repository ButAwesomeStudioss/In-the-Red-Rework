using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Robot : MonoBehaviour
{
    private bool dragging;
    
    private Vector2 offset;
    
    public BoxCollider2D EndSlot;

    public Rigidbody2D Me;
    
public GameObject Spawner;

    public GameObject UiObject;


 
    

    void Update() {
//if(!dragging) return;
    
 //var mousePosition = GetMousePos();

// transform.position = mousePosition - offset;
    
    
    }
   
   // void OnMouseDown () {
//dragging = true;
//offset = GetMousePos() - (Vector2)transform.position;
//}




//void OnMouseUp(){
//transform.position = transform.position;
//dragging = false;

//}

Vector2 GetMousePos(){
return Camera.main.ScreenToWorldPoint(Input.mousePosition);
}

private void OnCollisionEnter2D(Collision2D other) {
    if(other.rigidbody == EndSlot.attachedRigidbody){
    Rigidbody2D clone;
            clone = Instantiate(Me, Spawner.transform.position, Spawner.transform.rotation);
            Destroy(gameObject);
     
}
}
private void OnTriggerExit2D(Collider2D other) {
    if(other.tag != "conveyer"){
        Me.velocity = Vector2.zero;
        
}
}
}