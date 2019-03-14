using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugChangeCard : MonoBehaviour
{
    CardsModels cardsModels;
    int cardIndex = 0;

    public GameObject card;

    void Awake()
    {
        cardsModels = card.GetComponent<CardsModels>();
    }

    void OnGUI()
    {
       if (GUI.Button(new Rect(10, 10, 100, 28), "Hit me!"))
        {
            cardsModels.cardIndex = cardIndex;
            cardsModels.ToggleFace(true);

            cardIndex++;

            if (cardIndex == 52)
            {
                cardIndex = 0;
                cardsModels.ToggleFace(false);
            }


        }
    }

}
