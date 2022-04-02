using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnSystem : MonoBehaviour
{

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
        maxActionPoints++;
        currentActionPoints = maxActionPoints;
    }


}
