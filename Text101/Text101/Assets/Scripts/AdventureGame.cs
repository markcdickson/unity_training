using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "EndStates")]

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;
    [SerializeField] State[] endStates;

    State currentState;
    int dissatisfactionScore = 0;
    int unattendedTime = 0;

	// Use this for initialization
	void Start () {
        currentState = startingState;
        textComponent.text = currentState.getStateStory();
	}
	
	// Update is called once per frame
	void Update () {
        var keyPressed = Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2);

        if (currentState.isEndState() && keyPressed)
        {
            if ((dissatisfactionScore >= 10) &&
               (unattendedTime < 15))
            {
                currentState = endStates[0];
            }
            else if ((dissatisfactionScore >= 10) &&
                    (unattendedTime >= 15))
            {
                currentState = endStates[1];
            }
            else if ((dissatisfactionScore < 10) &&
                    (unattendedTime < 15))
            {
                currentState = endStates[2];
            }
            else if ((dissatisfactionScore < 10) && (dissatisfactionScore > 5) &&
                    (unattendedTime >= 15))
            {
                currentState = endStates[3];
            }
            else
            {
                currentState = endStates[4];
            }
        }
        else
        {
            manageState();
        }
        textComponent.text = currentState.getStateStory();
    }

    private void manageState()
    {
        var nextStates = currentState.getNextStates();
        var keyPressed = Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2);

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentState = nextStates[0];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentState = nextStates[1];
        }

        if (keyPressed)
        {
            manageScores(currentState);
        }
    }

    private void manageScores(State currentState)
    {
        dissatisfactionScore += currentState.getDissatisfactionScore();
        unattendedTime += currentState.getUnattendedScore();
        Debug.Log("Dissatisfaction Score = " + dissatisfactionScore);
        Debug.Log("Unattended Time = " + unattendedTime);
    }
}
