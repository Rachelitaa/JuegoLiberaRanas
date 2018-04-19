using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UVScroll : MonoBehaviour {

    public Vector2 speed;
    private void LateUpdate()
    {
        GetComponent<Renderer>().material.mainTextureOffset = speed * Time.time;
    }
}
