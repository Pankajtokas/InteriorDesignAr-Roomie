using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class moveScript : MonoBehaviour{
	private bool dragging;
	private float dist;
	// Use this for initialization
	void Start () {

		dragging=false;
	}
	

	// Update is called once per frame
	void Update () {

			Ray ray;
			RaycastHit hit;


			if(Input.touchCount!=1)
			{
				dragging= false;
				return;
			}

		    Touch touch1 = Input.GetTouch(0);
		    if(touch1.phase == TouchPhase.Began)
		    {
		    	ray = Camera.main.ScreenPointToRay(touch1.position);
				if (Physics.Raycast(ray, out hit, Mathf.Infinity) && (hit.collider.tag=="Player"))
				{		      
					    dragging= true; 
					    dist = hit.transform.position.z - Camera.main.transform.position.z;
			    }
			}

		    if(dragging && touch1.phase == TouchPhase.Moved)
		    {
			 // If the finger is on the screen, move the object smoothly to the touch position

				Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch1.position.x, touch1.position.y, dist));
	            transform.position = Vector3.Lerp(transform.position,touchPosition,Time.deltaTime*10);
			}

			if(dragging && (touch1.phase == TouchPhase.Ended || touch1.phase == TouchPhase.Canceled))
			{
            	 dragging = false;
         	}

	}
}
