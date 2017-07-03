using UnityEngine;
// to bring up the UI information eg: Here we need the Text
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;

	// Use this for initialization
	void Start () {
	
		text.text = "Dovah here!";
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.Space)){
			text.text = "You are in a prison cell, you want to escape. There are some dirty sheets on the bed, " + 
						"a mirror on the wall and the door is locked from the outside.\n\n" +
						"Press 'S' to view the Sheets, 'M' to view the Mirror and 'L' to view the Lock";
		}
		
	}
}
