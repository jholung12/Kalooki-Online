using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<Card> container = new List<Card>();
    public int x;
    public static int deckSize;
    public List<Card> deck = new List<Card>();
    public static List<Card> staticDeck = new List<Card>();

    public GameObject cardInDeck;

    public GameObject cardToHand;
    public GameObject[] clones;
    public GameObject hand;
    // Start is called before the first frame update
    void Start()
    {
        deckSize = 52;
        for (int i = 0; i < deckSize; i++)
        {
            x = Random.Range(0, 53);
            deck[i] = CardDatabase.cardList[x];
        }
        StartCoroutine(StartGame());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator StartGame()
    {
        for (int i = 0; i <= RoundRules.startAmount; i++)
        {
            yield return new WaitForSeconds(1);

            //NEW
            Instantiate(cardToHand, transform.position, transform.rotation);
        }
    }

    public void Shuffle()
    {
        for (int i = 0; i < deckSize; i++)
        {
            container[0] = deck[i];
            int randomIndex = Random.Range(i, deckSize);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = container[0];
        }
    }

    IEnumerator Draw(int x)
    {
        for (int i = 0; i < x; i++)
        {
            yield return new WaitForSeconds(1);
            Instantiate(cardToHand, transform.position, transform.rotation);
        }
    }
}
