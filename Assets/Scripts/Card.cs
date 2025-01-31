using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card 
{
    public string id;
    public int value;
    public string suite;
    public Sprite numberImage;
    public Sprite suiteImage;

    public Card()
    {

    }

    public Card(string id, int value, string suite, Sprite numberImage, Sprite suiteImage)
    {
        this.id = id;
        this.value = value;
        this.suite = suite;
        this.numberImage = numberImage;
        this.suiteImage = suiteImage;
    }
}
