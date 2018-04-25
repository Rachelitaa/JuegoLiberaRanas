using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NidoSerpientes : MonoBehaviour {

    public GameObject serpiente;
    public int time = 12;

    // Use this for initialization
    void Start()
    {
        //La primera serpiente nace a los 3s y las otras a los 7s
         InvokeRepeating("Nacer", 10, time);
    }

    void Nacer()
    {
        //Creamos una copia de la serpiente
        Instantiate(serpiente, transform.position, Quaternion.identity);
    }
}
