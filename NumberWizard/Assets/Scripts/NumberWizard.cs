using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int maximumNumber = 10000;
	int minimumNumber = 1;
	int guess;

	// Use this for initialization
	void Start () {
		
		print("Welcome to Number Wizard");
		print("Pick a number in your head, but don't tell me!");
		
		guess = maximumNumber/2;
		
		print("The highest number you can pick is " + maximumNumber);
		print("The lowest number you can pick is " + minimumNumber);
		
		print("Is the number " + guess + "?");
		print("UP arrow for higher, DOWN for lower, ENTER for equal");
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.DownArrow)){
			//print("Lower it is then");
			maximumNumber = guess;
			guess = (minimumNumber + maximumNumber) / 2;
			print("Is it " + guess + "?");
		}else if (Input.GetKeyDown(KeyCode.UpArrow)){
			//print("Higher it is then");
			minimumNumber = guess;
			guess = (minimumNumber + maximumNumber) / 2;
			print("Is it " + guess + "?");
		}else if (Input.GetKeyDown(KeyCode.Return)){
			print("The Number is " + guess);
		}
		
	
	}
}
