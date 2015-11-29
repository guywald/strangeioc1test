using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;

namespace strange.examples.signals
{
	public class DebugView : View
	{
		public Signal mySignal = new Signal();

		void OnGUI()
		{
			if (GUI.Button(new Rect(10, 10, 50, 50), "Dispatch"))
				mySignal.Dispatch();
		}
	}
}