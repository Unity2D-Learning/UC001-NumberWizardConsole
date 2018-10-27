using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    private int max, min, guess;

    // Use this for initialization
    void Start ()
    {
        InitValues();
        StartGame();
	}

    private void StartGame()
    {
        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("Pick a number, don't tell me what it is ...");
        Debug.Log("The highest number you can pick is " + max);
        Debug.Log("The lowest number you can pick is " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct");
    }

    private void InitValues()
    {
        max = 1000;
        min = 1;
        guess = CalcGuess();
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = CalcGuess();
            Debug.Log("Is it higher or lower than ... " + guess);
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = CalcGuess();
            Debug.Log("Is it higher or lower than ... " + guess);
         }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I'm a genius!");
        }
    }

    private int CalcGuess()
    {
        return (max + min) / 2;
    }
}
