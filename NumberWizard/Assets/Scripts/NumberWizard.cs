using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	int maximumNumber;
	int minimumNumber;
	int guess;
	int maxGuessesAllowed = 11;
	
	public Text text;
	
	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	// Assign values to the variables
	void StartGame(){
		
		maximumNumber = 10000;
		minimumNumber = 1;
		NextGuess();
		
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
		
		guess = Random.Range(minimumNumber, maximumNumber+1);
		text.text= guess.ToString();
		maxGuessesAllowed--;
		
		if(maxGuessesAllowed <= 0){
			Application.LoadLevel("Win");
		}
		
		
	}
}
