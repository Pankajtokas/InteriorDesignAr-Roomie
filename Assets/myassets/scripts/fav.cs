using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fav : MonoBehaviour {

	private bool save;
	public Sprite off;
	public Sprite on;

	// Use this for initialization
	void Start () {
		save=false;
		if(SceneManager.GetActiveScene().name=="profile"){
			save=true;
			this.GetComponent<Image>().sprite = on;
		}
			this.GetComponent<Button>().onClick.AddListener(delegate{
			Toggle();
			});
	}

	private void Toggle(){
		save=!save;
		if(save){
			this.GetComponent<Image>().sprite = on;
		}else{
			this.GetComponent<Image>().sprite = off;
		}
		ToDatabase();
	}

	private void ToDatabase(){
		StartCoroutine(Order());
	}

	IEnumerator Order()
    {   
    	int order = save?1:0;
    	Debug.Log(PlayerPrefs.GetInt("userid"));
    	Debug.Log(PlayerPrefs.GetInt("productid"));
        WWWForm form = new WWWForm();
        form.AddField("userid", PlayerPrefs.GetInt("userid"));
        form.AddField("productid", PlayerPrefs.GetInt("productid"));
 		form.AddField("order",order);
        WWW www = new WWW("http://192.168.1.3/AR/Order.php", form);
        yield return www;
        Debug.Log(www.text);
    }
}
