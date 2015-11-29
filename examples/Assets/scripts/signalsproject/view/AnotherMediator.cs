using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

namespace strange.examples.signals
{
	public class AnotherMediator : Mediator
	{
		[Inject]
		public AnotherView view { get; set; }


		[Inject]
		public SignalToListenTo signalToListenTo { get; set; }

		public override void OnRegister ()
		{
			signalToListenTo.AddListener(Foo);

			view.Init();

			base.OnRegister ();
		}

		public override void OnRemove ()
		{

			signalToListenTo.RemoveListener(Foo);
			base.OnRemove ();
		}

		void Foo()
		{
			Debug.Log ("My Name Is "+gameObject.name);
		}
	}
}