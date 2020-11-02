using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProfileLoader : MonoBehaviour {

	public Text name;
	private int userid;
	private string username;
	public RectTransform prefab;
	public GameObject Canvas;

	public void Awake(){
        username = PlayerPrefs.GetString("username");
        userid= PlayerPrefs.GetInt("userid");
		name.text = "Welcome "+username;
		StartCoroutine(Fetchitems());
	}

	IEnumerator Fetchitems()
    {   
        Debug.Log("Called");
        WWWForm form = new WWWForm();
        form.AddField("userid", userid); 
        WWW www = new WWW("http://192.168.1.3/AR/fetchFavs.php", form);
        yield return www;
        if (!string.IsNullOrEmpty(www.error)){
                Debug.Log(www.error);
        } else {
	        string data = www.text;
	        string[] items=data.Split(',');
	        for(int i=0;i<items.Length-1;i++){
	        	string[] info = items[i].Split('|');
	        	transform.position = new Vector3(325.0f, -125.0f-150.0f*i, 0.0f);
	        	RectTransform container=Instantiate(prefab, transform.position, Quaternion.identity) as RectTransform;
	        	container.GetChild(1).GetComponent<Text>().text="Name: "+info[0];
	        	container.GetChild(2).GetComponent<Text>().text="Color: "+info[1];
	        	container.GetChild(3).GetComponent<Text>().text="Price: "+info[2];
	        	container.SetParent(Canvas.transform, false);
	        }
	    }
    }
	
}