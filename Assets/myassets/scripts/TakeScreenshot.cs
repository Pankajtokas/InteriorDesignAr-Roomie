using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeScreenshot : MonoBehaviour {

	[SerializeField]
	public GameObject info;
	private bool enter = false;
	private int x;

	void Awake()
    {
        DontDestroyOnLoad(this);
    }

	void Start(){
		x=0;
		info.SetActive(false);
	}

	public void TakeAShot()
	{	

		StartCoroutine(CaptureIt());		
	}

	IEnumerator CaptureIt()
	{
		string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
		string fileName = "Screenshot" + timeStamp + ".png";
		string path= fileName;
		ScreenCapture.CaptureScreenshot(path);
		yield return 0;
		info.SetActive(true);
		yield return new WaitForSeconds(2);
		info.SetActive(false);
	}


}
