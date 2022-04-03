using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ThisCard : MonoBehaviour
{
    public TurnSystem TurnSystemReference;
    public List<Card> thisCard = new List<Card>();
    public int thisId;

    public int id;
    public string cardName;
    public int triggerSpace;
    public int effect;
    public int destroyEffect;
    public string cardDescription;

    public Text nameText;
    public Text costText;
    public Text effectText; //Effect on trigger turn
    public Text destroyEffectText; // Effect on end of board.
    public Text descriptionText;
    // Start is called before the first frame update

    public Sprite thisSprite;
    public Image cardImage;

    public bool cardBack;
    public static bool staticCardBack;

    public GameObject Hand;
    public int numberOfCardsInDeck;

    public bool canBePlayed;
    public bool isPlayed;
    public GameObject Playspace;
    void Start()
    {
        thisCard [0] = CardDataBase.cardList[thisId];
        id = thisCard[0].id;
        cardName = thisCard[0].cardName;
        triggerSpace = thisCard[0].triggerSpace; //replace with ActiveGameSpace
        effect = thisCard[0].activeEffect;
        destroyEffect = thisCard[0].onDestroyEffect;
        cardDescription = thisCard[0].cardDescription;
        thisSprite = thisCard[0].thisImage;

        numberOfCardsInDeck = PlayerDeck.deckSize;

        nameText.text = ""+cardName;
        costText.text = ""+triggerSpace;
        effectText.text = ""+effect;
        destroyEffectText.text = ""+destroyEffect;
        descriptionText.text = ""+cardDescription;
        cardImage.sprite = thisSprite;

        Hand = GameObject.Find("PlayerHand");
        canBePlayed = false;
        isPlayed = false;

        TurnSystemReference = GetComponent<TurnSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
        id = thisCard[0].id;
        cardName = thisCard[0].cardName;
        triggerSpace = thisCard[0].triggerSpace; //replace with ActiveGameSpace
        effect = thisCard[0].activeEffect;
        destroyEffect = thisCard[0].onDestroyEffect;
        cardDescription = thisCard[0].cardDescription;
        thisSprite = thisCard[0].thisImage;

         nameText.text = ""+cardName;
        costText.text = ""+triggerSpace;
        effectText.text = ""+effect;
        destroyEffectText.text = ""+destroyEffect;
        descriptionText.text = ""+cardDescription;
        cardImage.sprite = thisSprite;

        CheckDisableCardBack();
        UpdateTextColor();

        // Check if action point is greater than cost of this card, and weather this card has been played. If it can be played, the card can be draggable. Otherwise it is not.
        if(isPlayed == false)
        {
            canBePlayed = true;
        }
        else canBePlayed = false;

        if(canBePlayed == true)
        {
            gameObject.GetComponent<Draggable>().enabled = true;
        }
        else 
        {
            gameObject.GetComponent<Draggable>().enabled = false;            
        
        
            Playspace = GameObject.FindGameObjectWithTag("Playspace");
            if(isPlayed == false && this.transform.parent == Playspace.transform)
            {
                PlayCard(); //Deducts action points and sets this card IsPlayed to true
            }
        
        }

        if(this.tag == "Clone")
        {
            thisCard[0] = PlayerDeck.staticDeck[numberOfCardsInDeck -1];
            numberOfCardsInDeck -=1;
            PlayerDeck.deckSize -=1;
            cardBack = false;
            this.tag = "Untagged";
        }

    }

    

    public void PlayCard()
    {
        //Deducts action points and sets this card IsPlayed to true
        TurnSystemReference.currentActionPoints -= triggerSpace;
        isPlayed = true;
    }


    private void CheckDisableCardBack()
    {
        // Disable the Card back so that the player can see the card.
        if(this.transform.parent == Hand.transform.parent)
        {
            cardBack = false;
        }

        staticCardBack = cardBack;
    }

    private void UpdateTextColor()
    {
        //Update effect and death effect text color depending on positive or negative value.
        switch(effect)
        {
            case <0:
                effectText.color = Color.red;
                break;

            case 0:
                effectText.color = Color.white;
                break;
            case >0:
                effectText.color = Color.green;
            break;
        }

        switch(destroyEffect)
        {
            case <0:
                destroyEffectText.color = Color.red;
                break;

            case 0:
                destroyEffectText.color = Color.white;
                break;
            case >0:
                destroyEffectText.color = Color.green;
            break;
        }
    }

}
