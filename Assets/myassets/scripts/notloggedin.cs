using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notloggedin : MonoBehaviour {

	public void ResetLog() {
		PlayerPrefs.SetInt("loggedin",0);		
	}

}
