using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
public class scalerScript : MonoBehaviour {
	public Slider slide;
	private float scaler;
	private float init;
	private float val;
	// Use this for initialization
	void Start () {
		
		scaler=1;
		slide.onValueChanged.AddListener (delegate {
			scale ();
		});
	}

	void scale(){

		transform.localScale = new Vector3 ( 1, 1, 1) * slide.value;

	}

	void FixedUpdate()
	{	
		if (SystemInfo.deviceType == DeviceType.Desktop)
		{
			if(scaler<=2 && scaler>=0.5)
			{
				if (Input.GetKey("r"))
				{
					transform.localScale = new Vector3 ( 1, 1, 1) * scaler;
					scaler+=0.1f;
				}
				if (Input.GetKey("t"))
				{
					transform.localScale = new Vector3 ( 1, 1, 1) * scaler;
					scaler-=0.1f;
				}
			}
		}

		else
		{
			if(Input.touchCount==2)
			{

				Touch touch1=Input.GetTouch(0);
				Touch touch2=Input.GetTouch(1);

				if(touch1.phase==TouchPhase.Began || touch2.phase==TouchPhase.Began)
				{
					init=Mathf.Abs(touch1.position.magnitude-touch2.position.magnitude);
				}

				if((touch1.phase == TouchPhase.Moved || touch2.phase == TouchPhase.Moved))
			    {
				 // If two fingers are on the screen, and either of the finger is moved
			    	float now=Mathf.Abs(touch1.position.magnitude-touch2.position.magnitude);
			    	val=now/init;
			    	if(val<=2.0f && val>=0.5f)
			    	{

			    		transform.localScale = new Vector3 ( 1, 1, 1) * val;
					} 
				}
			}
		}
	}
}
// {
// 			if(Input.touchCount==2)
// 			{

// 				Touch touch1=Input.GetTouch(0);
// 				Touch touch2=Input.GetTouch(1);

// 				if(touch1.phase==TouchPhase.Began || touch2.phase==TouchPhase.Began)
// 				{
// 					init=Mathf.Abs(touch1.position.magnitude-touch2.position.magnitude);
// 				}

// 				if((touch1.phase == TouchPhase.Moved || touch2.phase == TouchPhase.Moved))
// 			    {
// 				 // If two fingers are on the screen, and either of the finger is moved
// 			    	float now=Mathf.Abs(touch1.position.magnitude-touch2.position.magnitude);
// 			    	if(val<=2.0f && val>=0.5f)
// 			    	{
// 			    		val=endval+((now/init)-1);
// 					}
// 					transform.localScale = new Vector3 ( 1, 1, 1) * val;
// 				}
// 				endval=val;
// 			}
// 		}