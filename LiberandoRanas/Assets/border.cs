using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class border : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //si la serpiente toca al borde se destruye
        if (collision.gameObject.name == "Serpiente")
            Destroy(collision.gameObject);
    }
}

	
