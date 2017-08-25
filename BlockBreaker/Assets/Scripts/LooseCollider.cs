using UnityEngine;
using System.Collections;

public class LooseCollider : MonoBehaviour {

	public LevelManager levelManager;

	void OnTriggerEnter2D(Collider2D collider){
		print("Triggered");
		levelManager.LoadLevel("Win");
	}
	
	void OnCollisionEnter2D(Collision2D collision){
		print("Collision occured");
	}
	
}
