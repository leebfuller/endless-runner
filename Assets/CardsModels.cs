using System.Collections;
using UnityEngine;

public class CardModels : MonoBehaviour
{
    public Sprite[] faces;
    public sprite cardback;

    public int cardIndex; // e.g faces [card index];

    public void ToggleFace(bool showFace)
    {


        if (showFace)
        {
            spriteRenderer.sprite = faces[cardIndex]
        }
        else
        {
            //TODO: Show the card face
        }
    }

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
