using System;
using System.Collections;

namespace VisualScripts
{
	/// <summary>
	/// IAction Interface
	/// </summary>
	public interface IAction
	{
		// Used in AnimationQueue - the Method is inherited from the other Classes.
		IEnumerator Run ();
	}
}

