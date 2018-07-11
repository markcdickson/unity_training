using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]

public class State : ScriptableObject {

    [TextArea(10,14)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;
    [SerializeField] int dissatisfactionScore = 0;
    [SerializeField] int unattendedScore = 0;
    [SerializeField] bool endState = false;

    public string getStateStory()
    {
        return storyText;
    }

    public State[] getNextStates()
    {
        return nextStates;
    }

    public int getDissatisfactionScore()
    {
        return dissatisfactionScore;
    }

    public int getUnattendedScore()
    {
        return unattendedScore;
    }

    public bool isEndState()
    {
        return endState;
    }
}
