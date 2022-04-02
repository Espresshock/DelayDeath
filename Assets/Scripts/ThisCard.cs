using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ThisCard : MonoBehaviour
{

    public List<Card> thisCard = new List<Card>();
    public int thisId;

    public int id;
    public string cardName;
    public int cost;
    public int effect;
    public string cardDescription;

    public Text nameText;
    public Text costText;
    public Text effectText;
    public Text descriptionText;
    // Start is called before the first frame update

    public Sprite thisSprite;
    public Image cardImage;

    public bool cardBack;
    public static bool staticCardBack;

    public GameObject Hand;
    public int numberOfCardsInDeck;
    void Start()
    {
        thisCard [0] = CardDataBase.cardList[thisId];
        id = thisCard[0].id;
        cardName = thisCard[0].cardName;
        cost = thisCard[0].cost;
        effect = thisCard[0].effect;
        cardDescription = thisCard[0].cardDescription;
        thisSprite = thisCard[0].thisImage;

        thisCard[0] = CardDataBase.cardList[thisId];

        nameText.text = ""+cardName;
        costText.text = ""+cost;
        effectText.text = ""+effect;
        descriptionText.text = ""+cardDescription;
        cardImage.sprite = thisSprite;

        Hand = GameObject.Find("PlayerHand");
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(this.transform.parent == Hand.transform.parent)
        {
            cardBack = false;
        }

        staticCardBack = cardBack;
    }
}
