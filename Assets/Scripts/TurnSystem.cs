using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnSystem : MonoBehaviour
{
    public PlayerDeck PlayerDeck;
    public bool PlayerTurn;
    public int turnCount;

    public Text turnText;

    public int maxActionPoints;
    public int currentActionPoints;
    public Text ActionPointText;
    // Start is called before the first frame update
    void Start()
    {
        PlayerTurn = true;
        turnCount = 0;
        maxActionPoints = 1;
        currentActionPoints = 1;
        
        /* Instantiate death card, attach to Playspace */
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerTurn == true){
            turnText.text = "Take your action";
        }
        else
        {
            turnText.text = "Wait one moment...";
        }

        ActionPointText.text = currentActionPoints + "/" + maxActionPoints;
    }

    public void EndPlayerTurn()
    {
        PlayerTurn = false;
        // Execute end of turn gameplay
        turnCount++;
        currentActionPoints = maxActionPoints;
        PlayerDeck.DrawCard();
        //A function to update the lanes with lane control system.
    }


    // A function which is called by the individual buttons when clicked on which checks if death is on this row, if space 1 is empty, and if the player has enough action points.
    // the function must move the death card to space 1 and subtract the cost of the action. 


}
