using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugChangeCard : MonoBehaviour
{
    CardFlipper flipper;
    CardsModels cardsModels;
    int cardIndex = 0;

    public GameObject card;

    void Awake()
    {
        cardsModels = card.GetComponent<CardsModels>();
        flipper = card.GetComponent<CardFlipper>();
    }

    void OnGUI()
    {
       if (GUI.Button(new Rect(10, 10, 100, 28), "Hit me!"))
        {
            if (cardIndex >= cardsModels.faces.Length)
            {
                cardIndex = 0;
                flipper.FlipCard(cardsModels.faces[cardsModels.faces.Length - 1], cardsModels.cardBack, -1);
            }
            else
            {
                if (cardIndex  >0)
                {
                    flipper.FlipCard(cardsModels.faces[cardIndex - 1], cardsModels.faces[cardIndex], cardIndex);
                }
                else
                {
                    flipper.FlipCard(cardsModels.cardBack, cardsModels.faces[cardIndex], cardIndex);
                }

                cardIndex++;
            }

        }
    }

}
