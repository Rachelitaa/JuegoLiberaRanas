using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Salir()
    {
        Application.Quit();
    }

    public void Reintentar()
    {
        Application.LoadLevel(0);
    }
}