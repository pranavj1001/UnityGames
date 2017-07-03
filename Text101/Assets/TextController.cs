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
			text.text = "Pranav here!";
		}
		
	}
}
