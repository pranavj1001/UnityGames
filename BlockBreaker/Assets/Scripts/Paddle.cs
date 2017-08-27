using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float mousePosGameUnits = (Input.mousePosition.x/Screen.width) * 16;
		Vector3 paddlePos = new Vector3(Mathf.Clamp(mousePosGameUnits, 0.5f, 15.5f), this.transform.position.y, 0f);
		this.transform.position = paddlePos;
	}
}
