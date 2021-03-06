﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State currentState;

	// Use this for initialization
	void Start () {
        currentState = startingState;
        textComponent.text = currentState.getStateStory();
	}
	
	// Update is called once per frame
	void Update () {
        manageState();
        textComponent.text = currentState.getStateStory();
    }

    private void manageState()
    {
        var nextStates = currentState.getNextStates();
        var keyPressed = Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2);

        for(int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                currentState = nextStates[index];
            }
        }
    }
}
