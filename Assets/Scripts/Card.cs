using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

public class Card {
    public int id;
    public string cardName;
    public int cost; // Time or turn until card is 
    public int effect;
    public string cardDescription;

    public Sprite thisImage;

    public Card()
    {

    }

    public Card(int Id, string CardName, int Cost, int Effect, string CardDescription, Sprite ThisImage)
    {
        id = Id;
        cardName = CardName;
        cost = Cost;
        effect = Effect;
        cardDescription = CardDescription;
        thisImage = ThisImage;
    }
}
