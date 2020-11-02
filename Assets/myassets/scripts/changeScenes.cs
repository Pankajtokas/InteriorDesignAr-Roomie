using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class changeScenes : MonoBehaviour {
	private int scene;

	public void Start(){
		if(SceneManager.GetActiveScene().name == "home"){
			PlayerPrefs.SetInt("loggedin",0);
		}
	}

	public void changeScene(int sceneNumber)
	{	
		scene = sceneNumber;

		if(PlayerPrefs.GetInt("loggedin")==1){
			if(SceneManager.GetActiveScene().buildIndex==4){
				if(scene==0){
					scene=3;
				}
					SceneManager.LoadScene(scene);
			}
			else{
				SceneManager.LoadScene(scene);
			}
		} else {
				if(SceneManager.GetActiveScene().name == "home" && sceneNumber==0)
					Application.Quit();
				else
					{
						SceneManager.LoadScene(scene);
					}
		}
	}

	void Update(){
		if (Input.GetKeyDown(KeyCode.Escape)){
			SceneManager.LoadScene(scene);
		}

		if(Input.GetKeyDown(KeyCode.Escape) && scene==0){
			Application.Quit();
		}
	}
}
