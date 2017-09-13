using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRevealer : MonoBehaviour {

    Sprite pixel;
    public Sprite real;

    // Use this for initialization
    protected void OnMouseEnter() {
        pixel = GetComponent<SpriteRenderer>().sprite;
        GetComponent<SpriteRenderer>().sprite = real;
    }

    protected void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().sprite = pixel;
    }
}
