using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {

	// TextArea(10, 14) :  TextArea(min number of lines to show, 
	// 								min number of lines to show scroll bar)
	[TextArea(10, 14)] [SerializeField] string storyText;

}
