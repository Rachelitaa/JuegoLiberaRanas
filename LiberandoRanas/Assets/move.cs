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

        Vector2 dir = new Vector2(h, 0);

        GetComponent<Rigidbody2D>().velocity += dir.normalized * speed;

        //Control de que estemos tocando el suelo
        if (transform.position.y > -6.20f)
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
            GetComponent<Animator>().SetBool("flying", true);


        }
    }

        //si la rana colisiona con la serpiente se para el tiempo
        private void OnCollisionEnter2D(Collision2D collision)
        {
            //Colision con la serpiente = muerte
            if (collision.gameObject.name == "Serpiente")
            {
                //Destruimos la rana
                Destroy(this.gameObject);
                Time.timeScale = 0;

            }
        }

       
}
