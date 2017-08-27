using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public Paddle paddle;
	private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
		paddleToBallVector = this.transform.position - paddle.transform.position;
		print(paddleToBallVector);
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = paddle.transform.position + paddleToBallVector;
		
		if(Input.GetMouseButton(0)){
			print("Mouse Clicked, Launch Ball");
			
			this.rigidbody2D.velocity = new Vector2(2f, 10f);
			
		}
	}
}
