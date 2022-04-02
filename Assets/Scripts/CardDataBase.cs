using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{

public static List<Card> cardList = new List<Card> ();

void Awake()
{
    cardList.Add (new Card(0, "Inevitable", 5, 100, "The Game Ends Inevitably", Resources.Load<Sprite>("CardImages/DeathCard")));
    cardList.Add (new Card(1, "life", 4, 1, "...", Resources.Load<Sprite>("CardImages/DeathCard")));
    cardList.Add (new Card(2, "asdf", 3, 2, "dsa", Resources.Load<Sprite>("CardImages/DeathCard")));
    cardList.Add (new Card(3, "zxcv", 2, 3, "bvc", Resources.Load<Sprite>("CardImages/DeathCard")));
}

}
