using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Use this for initialization
    void Start()
    {
        startGame();
    }

    void startGame()
    {
        nextGuess();
    }

    public void onPressHigher()
    {
        if (min != max)
        {
            min = guess + 1;
            nextGuess();
        }
    }

    public void onPressLower()
    {
        max = guess-1;
        nextGuess();
    }

    void nextGuess()
    {
        guess = Random.Range(min, max);

        guessText.text = guess.ToString();
    }
}
