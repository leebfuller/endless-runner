using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CardStack))]
public class CardStackView : MonoBehaviour
{
    CardStack deck;

    public Vector3 start;
    public float cardOffset;
    public GameObject cardPrefab;

    void Start()
    {
        deck = GetComponent<CardStack>();
        ShowCards();
    }

    void ShowCards()
    {
        int cardCount = 0;

        foreach(int i in deck.GetCards())
        {
            float xPosition = cardOffset * cardCount;

            GameObject cardCopy = (GameObject)Instantiate(cardPrefab);
            Vector3 temp = start + new Vector3(xPosition, 0f);
            cardCopy.transform.position = temp;

            CardsModels cardsModels = cardCopy.GetComponent<CardsModels>();
            cardsModels.cardIndex = i;
            cardsModels.ToggleFace(true);

            SpriteRenderer spriteRenderer = cardCopy.GetComponent<SpriteRenderer>();
            spriteRenderer.sortingOrder = cardCount;

            cardCount++;
        }
    }
}
