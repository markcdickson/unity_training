using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Welcome to Mumber Wizard, you.");
        Debug.Log("Think of a number, you bitch.");
        Debug.Log("The highest number you can choose is " + max);
        Debug.Log("The lowest number you can choose is " + min);
        Debug.Log("Is your fucking number higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max += 1;
    }

    void startGame()
    {
        max = 1001;
        min = 1;
        guess = 500;

        Debug.Log("START AGAIN MOTHERFUCKER");
        Debug.Log("Is your fucking number higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            nextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            nextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I'm a jeenz");
            startGame();
        }
    }

    void nextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than " + guess + "?");
    }
}
