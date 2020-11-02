using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class forCouch : MonoBehaviour {

	public float speed=40;
	public float angle=10;
	private Vector3 fp;   //First touch position
    private Vector3 lp;   //Last touch position
    private float dragDistance;  //minimum distance for a swipe to be registered
    public Slider rotator;
    private Quaternion originalRot;    
	// Use this for initialization
	void Start () {
		originalRot = transform.rotation;
		rotator.onValueChanged.AddListener (delegate {
			rotate ();
		});
	}

	void rotate()
	{
 		transform.rotation = originalRot * Quaternion.AngleAxis(rotator.value*2, -Vector3.forward);	
	}
		


	void FixedUpdate()
	{
		if (SystemInfo.deviceType == DeviceType.Desktop)
		{
			if (Input.GetKey("up"))
			{
				transform.RotateAround(this.transform.position, new Vector3(1, 0, 0), speed * Time.deltaTime);
			}
			if (Input.GetKey("down"))
			{
				transform.RotateAround(this.transform.position, new Vector3(-1, 0, 0), speed * Time.deltaTime);
			}
			if (Input.GetKey("left"))
			{
				transform.RotateAround(this.transform.position, new Vector3(0, 1, 0), speed * Time.deltaTime);
			}
			if (Input.GetKey("right"))
			{
				transform.RotateAround(this.transform.position, new Vector3(0, -1, 0), speed * Time.deltaTime);
			}

		}
	}
}
