using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int maximumNumber;
	int minimumNumber;
	int guess;

	// Use this for initialization
	void Start () {
		
		InitializeVariables();
		StartGame();
		
	}
	
	//Initialize the Game
	void StartGame(){
		
		print("========================");
		print("Welcome to Number Wizard");
		print("Pick a number in your head, but don't tell me!");
		
		guess = maximumNumber/2;
		
		print("The highest number you can pick is " + maximumNumber);
		print("The lowest number you can pick is " + minimumNumber);
		maximumNumber++;
		
		print("Is the number " + guess + "?");
		print("UP arrow for higher, DOWN for lower, ENTER for equal");
		
	}
	
	//Calculate the next guess
	void NextGuess(){
		
		guess = (minimumNumber + maximumNumber) / 2;
		print("Is it " + guess + "?");
		print("UP arrow for higher, DOWN for lower, ENTER for equal");
		
	}
	
	void InitializeVariables(){
		
		maximumNumber = 10000;
		minimumNumber = 1;
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.DownArrow)){
			//print("Lower it is then");
			maximumNumber = guess;
			NextGuess();
		}else if (Input.GetKeyDown(KeyCode.UpArrow)){
			//print("Higher it is then");
			minimumNumber = guess;
			NextGuess();
		}else if (Input.GetKeyDown(KeyCode.Return)){
			print("The Number is " + guess);
			InitializeVariables();
			StartGame();
		}
		
	
	}
}
