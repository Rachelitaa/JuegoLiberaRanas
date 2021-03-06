﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{

    public float speed = 2.0f;
    public float alturaSalto = 5f;
    public bool grounded = true;
    public GameObject ranaMuerta;
    public int puntos=0;
    public Text puntuacion;
    public Text vida;
    public int vidas=1;
    public int contador=0;
    public GameObject gameOver;

    
    private void FixedUpdate()
    {
        //contador = 0;
        puntuacion.text = "Puntuacion: " + puntos;
        vida.text = "Vidas: " + vidas;
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
           
        if (collision.gameObject.name == "ranitaAtrapada"|| collision.gameObject.name == "ranitaAtrapada (1)"|| collision.gameObject.name == "ranitaAtrapada (2)")
        {
            Destroy(collision.gameObject);
            puntos++;
            
            contador++;
            if (contador==3)
            {
                vidas++;
                vida.text = "Vidas: " + vidas;
                contador = 0;
            }
            
        }else if (collision.gameObject.name == "Serpiente(Clone)")
        {
            vidas--;
            vida.text = "Vidas: " + vidas;
            if (vidas <= 0)
            {
                //Destruimos la rana
                Destroy(this.gameObject);
                
                //instamciamos una ranaMuerta en la posición actual en la que estamos.
                Instantiate(ranaMuerta, transform.position, Quaternion.identity);
                gameOver.SetActive(true);
            }
        }
        
        }

       
}
