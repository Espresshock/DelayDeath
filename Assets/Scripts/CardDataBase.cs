using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{

public static List<Card> cardList = new List<Card> ();

void Awake()
{
    cardList.Add (new Card(0, "Death", 6, 0, -100, "The inevitable", Resources.Load<Sprite>("CardImages/DeathCard")));
    cardList.Add (new Card(1, "Holy Omen", 1, 1, -1, "A token of respite", Resources.Load<Sprite>("CardImages/HolySymbolCard")));
    cardList.Add (new Card(2, "Holy Symbol", 2, 2, -2, "A prayer of healing", Resources.Load<Sprite>("CardImages/HolySymbolCard")));
    cardList.Add (new Card(4, "Holy Sign", 1, 1, -2, "A prayer of healing", Resources.Load<Sprite>("CardImages/HolySymbolCard")));
    cardList.Add (new Card(3, "Last Resort", 3, 3, -2, "Strike deals with devils", Resources.Load<Sprite>("CardImages/LastResortcard")));
    cardList.Add (new Card(5, "Last Resort", 4, 3, -3, "Strike deals with devils", Resources.Load<Sprite>("CardImages/LastResortcard")));
    cardList.Add (new Card(8, "Last Resort", 5, 4, -3, "Strike deals with devils", Resources.Load<Sprite>("CardImages/LastResortcard")));
    cardList.Add (new Card(6, "Buff", 1, 0, 1, "An Aura of Meditation", Resources.Load<Sprite>("CardImages/Buffcard")));
    cardList.Add (new Card(7, "Buff", 1, -1, 2, "An Aura of Meditation", Resources.Load<Sprite>("CardImages/Buffcard")));
    cardList.Add (new Card(9, "Buff", 4, 2, 1, "An Aura of Meditation", Resources.Load<Sprite>("CardImages/Buffcard")));
    cardList.Add (new Card(10, "Greater Blessing", 1, 3, 0, "A blessing of the gods", Resources.Load<Sprite>("CardImages/GreaterBlessingCard")));
    cardList.Add (new Card(11, "Medium", 2, 2, 0, "Angelic protection", Resources.Load<Sprite>("CardImages/MediumHealCard")));
    cardList.Add (new Card(12, "Heal", 3, 3, -1, "Angelic protection", Resources.Load<Sprite>("CardImages/MediumHealCard")));
    cardList.Add (new Card(12, "Minor Blessing", 2, 2, -2, "A temporary boon", Resources.Load<Sprite>("CardImages/MinorBlessingCard")));

    }
    
}
