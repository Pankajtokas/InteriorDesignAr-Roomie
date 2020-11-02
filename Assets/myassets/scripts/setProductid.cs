using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setProductid : MonoBehaviour {
	
	public void setProduct(int id){
		PlayerPrefs.SetInt("productid",id);
	}
}
