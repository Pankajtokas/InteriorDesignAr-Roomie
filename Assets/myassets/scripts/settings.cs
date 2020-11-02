using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class settings : MonoBehaviour {

	public int backScene;	
	// Update is called once per frame
	void Update () {

		if (SceneManager.GetActiveScene().name == "homeScreen")
		{
			exitapp();
		}
		else
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				SceneManager.LoadScene(backScene);
			}
		}
	}

	void exitapp()
	{
					// Exit condition for mobile devices
			if (Input.GetKeyDown(KeyCode.Escape))
				Application.Quit();
	}

}
