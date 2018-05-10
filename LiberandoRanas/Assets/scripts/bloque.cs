using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloque : MonoBehaviour {

    int toques = 0;
    public Sprite bloqueRoto;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (toques == 0)
        {
            GetComponent<SpriteRenderer>().sprite = bloqueRoto;

        }
        if (toques > 0)
        {
            Destroy(this.gameObject);

        }

        toques++;



    }
}
