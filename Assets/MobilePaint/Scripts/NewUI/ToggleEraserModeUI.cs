using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace unitycoder_MobilePaint
{
	
	public class ToggleEraserModeUI : MonoBehaviour 
	{
		MobilePaint mobilePaint;
		MobilePaint mobilePaint2;
		MobilePaint mobilePaint3;
		MobilePaint mobilePaint4;

		void Start () 
		{
			mobilePaint = PaintManager.mobilePaint;
			mobilePaint2 = PaintManager.mobilePaint2;
			mobilePaint3 = PaintManager.mobilePaint3;
			mobilePaint4 = PaintManager.mobilePaint4;

			if (mobilePaint==null) Debug.LogError("No MobilePaint assigned",gameObject);

			var toggle=GetComponent<Toggle>();
			if (toggle==null) Debug.LogError("No Toggle component founded",gameObject);
			if (toggle.IsInteractable()) toggle.onValueChanged.AddListener(delegate {this.SetMode();});
		}


		public void SetMode()
		{
			if (GetComponent<Toggle>().isOn)
			{
				mobilePaint.SetDrawModeEraser();
				mobilePaint2.SetDrawModeEraser();
				mobilePaint3.SetDrawModeEraser();
				mobilePaint4.SetDrawModeEraser();
			}

		}

	}
}