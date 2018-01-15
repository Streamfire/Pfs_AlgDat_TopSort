using System;
using UnityEngine;
using System.Collections;

namespace VisualScripts
{
	public class ColorAction : IAction
	{
		private Color color;
		private GameObject[] gameobj;

		/// <summary>
		/// Initializes a new instance of the <see cref="VisualScripts.ColorAction"/> class.
		/// </summary>
		/// <param name="col">Set Color for GameObject.</param>
		/// <param name="go">GameObject-Array which used in inherit Run method</param>
		public ColorAction (Color col, GameObject[] go)
		{
			this.color = col;
			this.gameobj = go;
		}

		/// <summary>
		/// Inherit Method from IAction.
		/// </summary>
		public IEnumerator Run()
		{
			foreach(GameObject g in gameobj)
			{
				g.GetComponentInChildren<Renderer> ().material.SetColor ("_Color",color);
			}
			yield break;
		}
	}
}

