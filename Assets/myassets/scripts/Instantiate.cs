using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Instantiate : MonoBehaviour {


	public GameObject obj;
	public Text txt;
	public GameObject button;
	// Use this for initialization
	void Start()
	{
		this.GetComponent<Button>().onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
            Instantiate(obj, new Vector3(0, 0, 0), Quaternion.identity);
            Destroy(button);
	}
	
}
