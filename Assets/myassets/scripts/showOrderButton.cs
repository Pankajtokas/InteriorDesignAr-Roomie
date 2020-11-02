using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showOrderButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("loggedin")==0){
			GameObject[] buttons=GameObject.FindGameObjectsWithTag("order");
			foreach(GameObject x in buttons){
				x.SetActive(false);
			}
		}	
	}
}
