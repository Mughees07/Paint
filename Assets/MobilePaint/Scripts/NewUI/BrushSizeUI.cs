using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace unitycoder_MobilePaint
{

	public class BrushSizeUI : MonoBehaviour {

		MobilePaint mobilePaint;
		MobilePaint mobilePaint2;
		MobilePaint mobilePaint3;
		MobilePaint mobilePaint4;
		private Slider slider;
		public GameObject obj;
		public GameObject RightLeft;
		public GameObject UpperLower;
		void Start () 
		{
			mobilePaint = PaintManager.mobilePaint; // gets reference to mobilepaint through PaintManager
			mobilePaint2 = PaintManager.mobilePaint2; // gets reference to mobilepaint through PaintManager
			mobilePaint3 = PaintManager.mobilePaint3; // gets reference to mobilepaint through PaintManager
			mobilePaint4 = PaintManager.mobilePaint4; // gets reference to mobilepaint through PaintManager
			if (mobilePaint==null&& mobilePaint2==null) Debug.LogError("No MobilePaint assigned at "+transform.name, gameObject);

			slider = GetComponent<Slider>();
			if (slider==null) 
			{
				Debug.LogError("No Slider component founded",gameObject);
			}else{
				slider.value = mobilePaint.brushSize;
				slider.onValueChanged.AddListener((value) => 
					{ 
						obj.SetActive(false);
						UpperLower.SetActive (false);
						RightLeft.SetActive (false);
						mobilePaint.SetBrushSize((int)value); 
						mobilePaint2.SetBrushSize((int)value);
						mobilePaint3.SetBrushSize((int)value); 
						mobilePaint4.SetBrushSize((int)value);
				});
			}
		}
	}
}