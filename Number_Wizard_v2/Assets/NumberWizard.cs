using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int maxNumber;
    int minNumber;
    int guess;

    bool numberFound;
    bool sameNumberCondtion;

    // Use this for initialization
    void Start ()
    {
        StartGame();
    }
    

    // Shows up initial text on the screen
    void StartGame()
    {
        maxNumber = 10000;
        minNumber = 1;
        numberFound = false;
        sameNumberCondtion = false;

        // Greetings
        Debug.Log("Hi there!, Welcome to Number Wizard");

        // Instructions
        Debug.Log("Pick a number, don't tell anyone what it is...");
        Debug.Log("The highest number you can pick is: " + maxNumber);
        Debug.Log("The lowest number you can pick is: " + minNumber);

        maxNumber++;
        guess = Random.Range(minNumber, maxNumber);

        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.UpArrow) && !numberFound)
        {
            if (guess != minNumber && !sameNumberCondtion)
            {
                minNumber = guess;
                NextGuess();
            }
            else
            {
                HumanCheatingConditionFound();
            }
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow) && !numberFound)
        {
            if (guess != maxNumber && !sameNumberCondtion)
            {
                maxNumber = guess;
                NextGuess();
            }
            else
            {
                HumanCheatingConditionFound();
            }
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            if (!numberFound)
            {
                Debug.Log("The number is " + guess);
                numberFound = true;
            }
            else
            {
                Debug.Log("I have guessed the number correctly, please restart me to challenge me again human, Press R to restart");
            }
        }

        else if (Input.GetKeyDown(KeyCode.R))
        {
            StartGame();
        }
	}

    void NextGuess()
    {
        guess = (maxNumber + minNumber) / 2;
        if (guess == minNumber || guess == maxNumber - 1)
        {
            Debug.Log("The number should be " + guess);
            sameNumberCondtion = true;
        }
        else
        {
            Debug.Log(" Is your number " + guess);
        }
    }

    // if user keeps on pressing up or down arrow key then this condition is reached
    void HumanCheatingConditionFound()
    {
        sameNumberCondtion = true;
        Debug.Log("You cheated human");
    }
}
