using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public float speed = 2.0f;
    public float alturaSalto = 5f;
    public bool grounded = true;


    private void FixedUpdate()
    {
        //Get Input from Arrow Keys,AD,Gamepads
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        GetComponent<Animator>().SetBool("saltando", v > 0);

        Vector2 dir = new Vector2(h, 0);

        GetComponent<Rigidbody2D>().velocity += dir.normalized * speed;

        //Control de que estemos tocando el suelo
        if (transform.position.y > -5.60f)
        {
            grounded = false;
        }
        else
        {
            grounded = true;
        }

        //Tecla Up para saltar
        if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
        {
            GetComponent<Rigidbody2D>().velocity += Vector2.up * alturaSalto;
            GetComponent<Animator>().SetBool("flying",true);


        }
    }
}
