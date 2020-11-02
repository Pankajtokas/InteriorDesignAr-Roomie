using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseHover : MonoBehaviour {

	void Start(){
		Debug.Log(GetComponent<Renderer>());
	}

	// void OnMouseEnter(){
	// 	GetComponent<Renderer>().image.color= Color.red;
	// }

	// void OnMouseExit(){
	// 	GetComponent<Renderer>().image.color= Color.black;
	// }

}
