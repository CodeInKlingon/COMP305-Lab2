using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwapper : MonoBehaviour {

    public Sprite[] sprites;

    public GameObject sprite;
    public bool reverse;


    // Use this for initialization
    protected void OnMouseDown()
    {
        print("mouse down");
        string currentSprite = sprite.GetComponent<SpriteRenderer>().sprite.name.ToString();
        if (!reverse)
        {
            switch (currentSprite)
            {
                case "Daniel1":
                    sprite.GetComponent<SpriteRenderer>().sprite = sprites[1];
                    break;
                case "Daniel2":
                    sprite.GetComponent<SpriteRenderer>().sprite = sprites[2];
                    break;
                case "Daniel3":
                    sprite.GetComponent<SpriteRenderer>().sprite = sprites[0];
                    break;
            }
        }
        else
        {
            switch (currentSprite)
            {
                case "Daniel1":
                    sprite.GetComponent<SpriteRenderer>().sprite = sprites[2];
                    break;
                case "Daniel2":
                    sprite.GetComponent<SpriteRenderer>().sprite = sprites[0];
                    break;
                case "Daniel3":
                    sprite.GetComponent<SpriteRenderer>().sprite = sprites[1];
                    break;
            }
        }
    }
}
