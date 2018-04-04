using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dividerScript : MonoBehaviour {
	public GameObject line2;
	public GameObject line1;
	public GameObject line3;
	public GameObject line4;

	public GameObject Canvas1;
	public GameObject Canvas2;
	public GameObject Canvas3;
	public GameObject Canvas4;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void rightLeft()
	{
		Canvas1.SetActive (true);
		Canvas2.SetActive (true);

		line1.SetActive (true);
		line2.SetActive (true);
		line3.SetActive (false);
		line4.SetActive (false);

		Canvas3.SetActive (false);
		Canvas4.SetActive (false);

		GameObject.Find ("Canvas1Size").transform.rotation = Quaternion.Euler (0, 0, 0);
		GameObject.Find ("Canvas1Size").transform.position = new Vector3 (0, 0, 0);

		Canvas1.transform.localScale = new Vector3 (0.4633f, 0.9989f, 1f);
		Canvas1.transform.localPosition = new Vector3 (-69.84f, 2.76f);

		Canvas2.transform.localScale = new Vector3 (0.47224f, 0.9912071f, 1f);
		Canvas2.transform.localPosition = new Vector3 (39f, 2.3f);
		Canvas2.transform.localRotation = Quaternion.Euler (0f, 0f, 180f);
	}

	public void upperLower()
	{
		Canvas1.SetActive (true);
		Canvas2.SetActive (true);

		Canvas3.SetActive (false);
		Canvas4.SetActive (false);

		line3.SetActive (true);
		line4.SetActive (true);
		line1.SetActive (false);
		line2.SetActive (false);


		GameObject.Find ("Canvas1Size").transform.rotation = Quaternion.Euler (0, 0, 90);
		GameObject.Find ("Canvas1Size").transform.position = new Vector3 (-14, 0, 0);

		Canvas2.transform.localScale = new Vector3 (0.3743075f, 1.29878f, 1f);
		Canvas2.transform.localPosition = new Vector3 (45.16f, 1.56f,0f);
		Canvas2.transform.localRotation = Quaternion.Euler (0f, 0f, 180f);
		
		Canvas1.transform.localScale = new Vector3 (0.3613272f, 1.296688f, 1f);
		Canvas1.transform.localPosition = new Vector3 (-41f, 1,0);
	}
}
