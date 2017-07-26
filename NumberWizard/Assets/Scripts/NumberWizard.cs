using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	int maximumNumber;
	int minimumNumber;
	int guess;
	int maxGuessesAllowed = 10;
	
	public Text text;
	
	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	// Assign values to the variables
	void StartGame(){
		
		maximumNumber = 10000;
		minimumNumber = 1;
		guess = 500;
		
		maximumNumber++;
		
	}
	
	public void GuessHigher(){
		minimumNumber  = guess;
		NextGuess();
	}
	
	public void GuessLower(){
		maximumNumber = guess;
		NextGuess();
	}
	
	// Calculate the next guess
	void NextGuess(){
		
		guess = (minimumNumber + maximumNumber) / 2;
		text.text= guess.ToString();
		maxGuessesAllowed--;
		
		if(maxGuessesAllowed <= 0){
			Application.LoadLevel("Win");
		}
		
		
	}
}
