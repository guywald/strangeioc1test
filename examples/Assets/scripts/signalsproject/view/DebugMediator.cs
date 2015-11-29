using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

namespace strange.examples.signals
{
	public class DebugMediator : Mediator
	{
		[Inject]
		public DebugView view { get; set; }

		[Inject]
		public SignalToListenTo signalToListenTo { get; set; }

		public override void OnRegister ()
		{
			view.mySignal.AddListener(Bar);
			base.OnRegister ();
		}

		public override void OnRemove ()
		{
			view.mySignal.RemoveListener(Bar);
			base.OnRemove ();
		}

		void Bar()
		{
			signalToListenTo.Dispatch();
		}
	}
}