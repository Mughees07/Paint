using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace unitycoder_MobilePaint
{
	
	public class ToggleCustomShapeModeUI : MonoBehaviour 
	{
		MobilePaint mobilePaint;
		MobilePaint mobilePaint2;
		MobilePaint mobilePaint3;
		MobilePaint mobilePaint4;
		public GameObject customBrushPanel;

		void Start () 
		{
			mobilePaint = PaintManager.mobilePaint;
			mobilePaint2 = PaintManager.mobilePaint2;
			mobilePaint3 = PaintManager.mobilePaint3;
			mobilePaint4 = PaintManager.mobilePaint4;
			if (mobilePaint==null&&mobilePaint2==null&&mobilePaint3==null&&mobilePaint4==null) Debug.LogError("No MobilePaint assigned",gameObject);
			if (customBrushPanel==null) Debug.LogError("No customBrushPanel assigned",gameObject);

			var toggle=GetComponent<Toggle>();
			if (toggle==null) Debug.LogError("No Toggle component founded",gameObject);

			// disable button if not using custom brushes
			toggle.interactable = mobilePaint.useCustomBrushes;
			toggle.interactable = mobilePaint2.useCustomBrushes;
			toggle.interactable = mobilePaint3.useCustomBrushes;
			toggle.interactable = mobilePaint4.useCustomBrushes;
			if (toggle.IsInteractable())
				toggle.onValueChanged.AddListener(delegate {this.SetMode();});
		}


		public void SetMode()
		{
			if (GetComponent<Toggle>().isOn)
			{
				customBrushPanel.SetActive(true);
				mobilePaint.SetDrawModeShapes();
				mobilePaint2.SetDrawModeShapes();
				mobilePaint3.SetDrawModeShapes();
				mobilePaint4.SetDrawModeShapes();
			}else{
				customBrushPanel.SetActive(false);
			}

		}

	}
}