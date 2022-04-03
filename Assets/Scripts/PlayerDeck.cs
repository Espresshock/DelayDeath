using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{

    public List<Card> deck = new List<Card>();
    public List<Card> container = new List<Card>();

    static public List<Card> staticDeck = new List<Card>();

    public GameObject CardToHand;
    public GameObject[] Clones;

    public GameObject Hand;
    public int x;
    static public int deckSize;

    // Start is called before the first frame update
    void Start()
    {
        x=0;
        deckSize = 12;

        for(int i=0;i<deckSize;i++)
        {
            x = Random.Range(1,12);
            deck[i] = CardDataBase.cardList[x];
        }

        Shuffle();
        
    }

    // Update is called once per frame
    void Update()
    {
        staticDeck = deck;
    }

    public void Shuffle()
    {
        for(int i = 0; i < deckSize; i++)
        {
            container[0] = deck[i];
            int randomIndex = Random.Range(i, deckSize);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = container[0];
        }

    }

    public void DrawCard()
    {
        Clones = GameObject.FindGameObjectsWithTag("Clone");
        foreach(GameObject Clone in Clones)
        {
            Destroy(Clone);
        }
        Instantiate(CardToHand, transform.position, transform.rotation);

        
    }
}
