using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public float speed = 2.0f;
    public float alturaSalto = 5f;

    
    private void FixedUpdate() {

        //Para movernos en el eje x
        //Get Input from Arrow Keys,AD,Gamepads
        float h = Input.GetAxisRaw("Horizontal");

        Vector2 dir = new Vector2(h, 0);
        GetComponent<Rigidbody2D>().velocity += dir.normalized * speed;

        //Tecla Fecha arriba para saltar
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().velocity += Vector2.up * alturaSalto;
            
        }
    }
	
}
