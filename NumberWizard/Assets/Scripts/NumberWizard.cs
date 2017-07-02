using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head but don't tell me");
		
		int maximumNumber = 10000;
		int minimumNumber = 1;
		
		print ("The highest number you can pick is " + maximumNumber);
		print ("The lowest number you can pick is " + minimumNumber);
		
		print ("Is the number higher or lower than 500?");
		print ("UP arrow for higher, DOWN for lower, ENTER for equal");
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.DownArrow))
			print("Lower it is then");
			
		if (Input.GetKeyDown(KeyCode.UpArrow))
			print("Higher it is then");
			
		if (Input.GetKeyDown(KeyCode.Return))
			print("Equal it is then");
		
	
	}
}
