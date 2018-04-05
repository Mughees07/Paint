using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorSelection : MonoBehaviour {
	public GameObject obj; 
	public GameObject RightLeft;
	public GameObject UpperLower;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update()
	{
		
	}
	public void colorselect()
	{
		obj.gameObject.SetActive (true);
		UpperLower.SetActive (false);
		RightLeft.SetActive (false);
		if (Input.GetMouseButtonDown (0)) 
		{
			
			obj.SetActive(false);
			Debug.Log ("gaib");
		}
	}

}
