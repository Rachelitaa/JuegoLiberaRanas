using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public float speed = 2.0f;
    public float alturaSalto = 5f;
    public bool grounded = true;
    public GameObject ranaMuerta;
    int puntos;


    private void FixedUpdate()
    {
        //Get Input from Arrow Keys,AD,Gamepads
        float h = Input.GetAxisRaw("Horizontal");

        Vector2 dir = new Vector2(h, 0);

        GetComponent<Rigidbody2D>().velocity += dir.normalized * speed;
        //Control limites de pantalla
        if (transform.position.x < -12)
        {
            transform.position = new Vector2(-10f, transform.position.y);
        }
        if (transform.position.x > 12f)
        {
            transform.position = new Vector2(10f, transform.position.y);
        }

        //Control de que estemos tocando el suelo
        if (transform.position.y > -6f)
        {
            grounded = false;
        }
        else
        {
            grounded = true;
        }

        //Tecla Up para saltar
        if (Input.GetButtonDown("Jump") && grounded)
        {
            GetComponent<Rigidbody2D>().velocity += Vector2.up * alturaSalto;
            GetComponent<Animator>().SetBool("saltando", true);


        }
    }

        //si la rana colisiona con la serpiente se para el tiempo
        private void OnCollisionEnter2D(Collision2D collision)
        {
            //Colision con la serpiente = muerte
            if (collision.gameObject.name == "Serpiente(Clone)")
            {
                //Destruimos la rana
                Destroy(this.gameObject);
                //Time.timeScale = 0;
                //instamciamos una ranaMuerta en la posición actual en la que estamos.
                Instantiate(ranaMuerta, transform.position, Quaternion.identity);

            }
        if (collision.gameObject.name == "ranitaAtrapada"|| collision.gameObject.name == "ranitaAtrapada (1)"|| collision.gameObject.name == "ranitaAtrapada (2)")
        {
            Destroy(collision.gameObject);
            puntos++;
            if (puntos == 10)
            {
                print("Has ganado!!");
            }
            else
            {
                print(puntos);

            }
        }
    }

       
}
