using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCard : MonoBehaviour
{
    //public int deckSize;
    public List<Card> displayCard = new List<Card>();
    public int displayId;

    public string id;
    public string suite;
    public int value;
    public Sprite numberSprite;
    public Sprite suiteSprite;

    //UI Elements
    public Image numberImage;
    public Image suiteImage;


    public bool cardBack;
    public static bool staticCardBack;

    public GameObject hand;
    public int numCardsInDeck;

    // Start is called before the first frame update
    void Start()
    {
        numCardsInDeck = Deck.deckSize;

        displayCard.Add(CardDatabase.cardList[displayId]);
    }

    // Update is called once per frame
    void Update()
    {
        id = displayCard[0].id;
        suite = displayCard[0].suite;
        value = displayCard[0].value;
        numberSprite = displayCard[0].numberImage;
        suiteSprite = displayCard[0].suiteImage;

        numberImage.sprite = numberSprite;
        suiteImage.sprite = suiteSprite;

        hand = GameObject.Find("Hand");
        if (this.transform.parent == hand.transform.parent)
        {
            cardBack = false;
        }

        staticCardBack = cardBack;

        if (this.tag == "Clone")
        {
            displayCard[0] = Deck.staticDeck[numCardsInDeck - 1];
            numCardsInDeck--;
            Deck.deckSize--;
            cardBack = false;
            this.tag = "Untagged";
        }
    }
}
