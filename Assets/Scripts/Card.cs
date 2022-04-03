using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

public class Card {
    public int id;
    public string cardName;
    public int triggerSpace; // Replace with active gamespace. The space on which the card is activated 
    public int activeEffect; // split effect into Active Effect and OnDestroy Effect
    public int onDestroyEffect;
    public string cardDescription;

    public Sprite thisImage;

    public Card()
    {

    }

    public Card(int Id, string CardName, int Cost, int Effect, int DestroyEffect, string CardDescription, Sprite ThisImage)
    {
        id = Id;
        cardName = CardName;
        triggerSpace = Cost;
        activeEffect = Effect;
        onDestroyEffect = DestroyEffect;
        cardDescription = CardDescription;
        thisImage = ThisImage;
    }
}
