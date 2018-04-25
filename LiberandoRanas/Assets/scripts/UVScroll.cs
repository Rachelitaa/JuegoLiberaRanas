using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UVScroll : MonoBehaviour {

    public Vector2 speed;
    private void LateUpdate()
    {
        //el background en vez de moverse solo se moverá cuando pulse las teclas del eje x
        float h = Input.GetAxisRaw("Horizontal");
        GetComponent<Renderer>().material.mainTextureOffset += h * speed;
    }
}
