using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class arModeToggle : MonoBehaviour {//attach to camera
	private bool check;
	public Toggle tog;
    // private GameObject furniture;
	void Start()
    {
    	GetComponent<VuforiaBehaviour>().enabled = false;

    	check=tog.GetComponent<Toggle>().isOn;
		VuforiaARController.Instance.SetWorldCenterMode(VuforiaARController.WorldCenterMode.DEVICE_TRACKING);
        tog.GetComponent<Toggle>().onValueChanged.AddListener(delegate {
                this.ToggleValueChanged();
            });
    }

    void ToggleValueChanged()
    {
    	if(check==tog.GetComponent<Toggle>().isOn)
		{
            GetComponent<VuforiaBehaviour>().enabled = false;
            // GameObject.FindWithTag("Player").GetComponent<Renderer>().transform.position=new Vector3(0,0,0);
		}
		else
		{
			VuforiaARController.Instance.SetWorldCenterMode(VuforiaARController.WorldCenterMode.DEVICE_TRACKING);
            GetComponent<VuforiaBehaviour>().enabled = true;
            GameObject.FindWithTag("Player").GetComponent<Renderer>().transform.position=new Vector3(0,0,5);
		}
    }
}
