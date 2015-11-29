using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

namespace strange.examples.signals
{
	public class AnotherView : View
	{

		internal void Init()
		{
			StartCoroutine(DestroyAfterSomeTime());
		}
		
		private IEnumerator DestroyAfterSomeTime()
		{
			Debug.Log ("Destroying in 5 seconds");
			yield return new WaitForSeconds(5f);
			Debug.Log ("boom");
			GameObject.Destroy(gameObject);
		}
	}
}