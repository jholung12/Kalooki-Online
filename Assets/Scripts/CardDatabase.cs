using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    // Start is called before the first frame update
    void Awake()
    {
        cardList.Add(new Card("AS", 15, "spade", Resources.Load<Sprite>("blackace"), Resources.Load<Sprite>("spade")));
        cardList.Add(new Card("KS", 10, "spade", Resources.Load<Sprite>("blackking"), Resources.Load<Sprite>("spade")));
        cardList.Add(new Card("QS", 15, "spade", Resources.Load<Sprite>("blackqueen"), Resources.Load<Sprite>("spade")));
        cardList.Add(new Card("JS", 15, "spade", Resources.Load<Sprite>("blackjack"), Resources.Load<Sprite>("spade")));
        fillSpade();

        cardList.Add(new Card("AC", 15, "club", Resources.Load<Sprite>("blackace"), Resources.Load<Sprite>("club")));
        cardList.Add(new Card("KC", 10, "club", Resources.Load<Sprite>("blackking"), Resources.Load<Sprite>("club")));
        cardList.Add(new Card("QC", 10, "club", Resources.Load<Sprite>("blackqueen"), Resources.Load<Sprite>("club")));
        cardList.Add(new Card("JC", 10, "club", Resources.Load<Sprite>("blackjack"), Resources.Load<Sprite>("club")));
        fillClub();

        cardList.Add(new Card("AH", 1, "heart", Resources.Load<Sprite>("redace"), Resources.Load<Sprite>("heart")));
        cardList.Add(new Card("KH", 10, "heart", Resources.Load<Sprite>("redking"), Resources.Load<Sprite>("heart")));
        cardList.Add(new Card("QH", 10, "heart", Resources.Load<Sprite>("redqueen"), Resources.Load<Sprite>("heart")));
        cardList.Add(new Card("JH", 10, "heart", Resources.Load<Sprite>("redjack"), Resources.Load<Sprite>("heart")));
        fillHeart();

        cardList.Add(new Card("AD", 1, "diamond", Resources.Load<Sprite>("redace"), Resources.Load<Sprite>("diamond"))); 
        cardList.Add(new Card("KD", 10, "diamond", Resources.Load<Sprite>("redking"), Resources.Load<Sprite>("diamond")));
        cardList.Add(new Card("QD", 10, "diamond", Resources.Load<Sprite>("redqueen"), Resources.Load<Sprite>("diamond")));
        cardList.Add(new Card("JD", 10, "diamond", Resources.Load<Sprite>("redjack"), Resources.Load<Sprite>("diamond")));
        fillDiamond();

        cardList.Add(new Card("JJ", 50, "joker", Resources.Load<Sprite>("joker"), Resources.Load<Sprite>("joker")));
    }

    private void fillSpade()
    {
        string id;
        int value;
        for(int i = 0; i < 9; i++)
        {
            value = i + 2;
            id = value + "S";
            cardList.Add(new Card(id, i+2, "spade", Resources.Load<Sprite>("black" + value), Resources.Load<Sprite>("spade")));
        }
    }

    private void fillClub()
    {
        string id;
        int value;
        for (int i = 0; i < 9; i++)
        {
            value = i + 2;
            id = value + "C";
            cardList.Add(new Card(id, i + 2, "club", Resources.Load<Sprite>("black" + value), Resources.Load<Sprite>("club")));
        }
    }
    private void fillHeart()
    {
        string id;
        int value;
        for (int i = 0; i < 9; i++)
        {
            value = i + 2;
            id = value + "H";
            cardList.Add(new Card(id, i + 2, "heart", Resources.Load<Sprite>("red" + value), Resources.Load<Sprite>("heart")));
        }
    }
    private void fillDiamond()
    {
        string id;
        int value;
        for (int i = 0; i < 9; i++)
        {
            value = i + 2;
            id = value + "D";
            cardList.Add(new Card(id, i + 2, "diamond", Resources.Load<Sprite>("red" + value), Resources.Load<Sprite>("diamond")));
        }
    }
}