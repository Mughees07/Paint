using UnityEngine;
using System.Collections;

namespace unitycoder_MobilePaint
{

	public class PaintManager : MonoBehaviour 
	{
		public MobilePaint mobilePaintReference;
		public MobilePaint mobilePaintReference2;
		public MobilePaint mobilePaintReference3;
		public MobilePaint mobilePaintReference4;
		public static MobilePaint mobilePaint;
		public static MobilePaint mobilePaint2;
		public static MobilePaint mobilePaint3;
		public static MobilePaint mobilePaint4;

		void Awake()
		{
			if (mobilePaintReference == null)
				Debug.LogError ("No MobilePaint assigned at " + transform.name, gameObject);
			{
				mobilePaint = mobilePaintReference;

			}
			if (mobilePaintReference2 == null)
				Debug.LogError ("No MobilePaint assigned at " + transform.name, gameObject);
			{
				mobilePaint2 = mobilePaintReference2;

			}if (mobilePaintReference3 == null)
				Debug.LogError ("No MobilePaint assigned at " + transform.name, gameObject);
			{
				mobilePaint3 = mobilePaintReference3;

			}
			if (mobilePaintReference4 == null)
				Debug.LogError ("No MobilePaint assigned at " + transform.name, gameObject);
			{
				mobilePaint4 = mobilePaintReference4;

			}
		}

	}
}