using System;
using System.Collections;
using UnityEngine;

namespace VisualScripts
{
	public class BlinkAction : IAction
	{
		private Color color;
		private int count;
		private float duration;
		private GameObject[] gameobj;

		/// <summary>
		/// Initializes a new instance of the <see cref="VisualScripts.BlinkAction"/> class.
		/// </summary>
		/// <param name="col">Which Color BlinkAction should use.</param>
		/// <param name="cnt">How often Action should blink.</param>
		/// <param name="dur">How fast one BlinkAction should be.</param>
		/// <param name="go">GameObject-Array which used in inherit Run method</param>
		public BlinkAction (Color col,int cnt, float dur, GameObject[] go)
		{
			this.color = col;
			this.count = cnt;
			this.duration = dur;
			this.gameobj = go;
		}
			

		/// <summary>
		/// Inherit Method from IAction
		/// </summary>
		public IEnumerator Run()
		{
			Color[] tmpCol = new Color[gameobj.Length];
			//save Color
			for(int i=0; i< gameobj.Length; i++)
			{
				tmpCol[i] = gameobj [i].GetComponentInChildren<Renderer> ().material.GetColor ("_Color");
			}

			//blick count times
			for (int j = 0; j < count; j++) {

				// set new Color
				for (int i = 0; i < gameobj.Length; i++) {
					gameobj [i].GetComponentInChildren<Renderer> ().material.SetColor ("_Color",color);
				}
				// wait some time (not duration/2 ? because used 2 times)
				yield return new WaitForSeconds(duration);
				// set old color
				for(int i=0; i<gameobj.Length; i++)
				{
					gameobj [i].GetComponentInChildren<Renderer> ().material.SetColor ("_Color",tmpCol[i]);
				}
				// wait some time again
				yield return new WaitForSeconds (duration);

				// Überprüfung notwendig??? erstmal ohne
				/*
				if (j != gameobj.Length - 1) {
					yield return new WaitForSeconds (duration);
				}
				*/
			}
		}
	}
}

