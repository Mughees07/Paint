﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace unitycoder_MobilePaint
{
	
	public class ToggleFloodFillModeUI : MonoBehaviour 
	{
		MobilePaint mobilePaint;
		public GameObject obj;
		public GameObject RightLeft;
		public GameObject UpperLower;
		MobilePaint mobilePaint2;
		MobilePaint mobilePaint3;
		MobilePaint mobilePaint4;
		public Texture2D cursorTexture;
		public CursorMode cursorMode = CursorMode.Auto;
		public Vector2 hotSpot = Vector2.zero;
		void Start () 
		{
			mobilePaint = PaintManager.mobilePaint;
			mobilePaint2 = PaintManager.mobilePaint2;
			mobilePaint3 = PaintManager.mobilePaint3;
			mobilePaint4 = PaintManager.mobilePaint4;
			if (mobilePaint==null) Debug.LogError("No MobilePaint assigned at "+transform.name,gameObject);

			GetComponent<Toggle>().onValueChanged.AddListener(delegate {this.SetMode();});
		}

//		void OnMouseEnter()
//		{
//			Cursor.SetCursor (cursorTexture, hotSpot, cursorMode);
//			Cursor.visible = true;
//		}

		public void SetMode()
		{
			if (GetComponent<Toggle>().isOn)
			{
				//OnMouseEnter ();
				obj.SetActive(false);
				UpperLower.SetActive (false);
				RightLeft.SetActive (false);
				mobilePaint.SetDrawModeFill();
				mobilePaint2.SetDrawModeFill();
				mobilePaint3.SetDrawModeFill();
				mobilePaint4.SetDrawModeFill();
			}

		}

	}
}