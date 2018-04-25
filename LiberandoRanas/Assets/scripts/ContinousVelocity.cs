using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinousVelocity : MonoBehaviour {
    public float speed;
    // Use this for initialization
    void Start () {
		
	}
	
	// A una velocidat determinada, se traslada el objeto hacia la izquierda en el eje de las x
	void Update () {
       transform.Translate(-speed, 0, 0);
    }
}
