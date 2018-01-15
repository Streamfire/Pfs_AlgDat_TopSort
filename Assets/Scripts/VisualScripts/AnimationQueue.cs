using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VisualScripts;

public class AnimationQueue : MonoBehaviour {

	// Timeout for yield in worker
	public float delaySeconds=0.5f;
	// Queue for all Action
	private Queue<IAction> queue = new Queue<IAction> ();


	/// <summary>
	/// Start this instance after assigning this script
	/// </summary>
	void Start () {

		// Visit Doc: https://docs.unity3d.com/ScriptReference/MonoBehaviour.StartCoroutine.html
		// needs an IEnumerator
		StartCoroutine (worker());
	}
	/// <summary>
	/// Enqueues the action.
	/// </summary>
	/// <param name="IAction">Action to enqeue in Queue</param>
	public void enqueueAction(IAction action){
		queue.Enqueue (action);
	}

	// runs every time after WaitForSeconds
	IEnumerator worker(){
		while(true){
			if(queue.Count != 0){
				IAction action = queue.Dequeue();
				yield return action.Run ();
			}
			yield return new WaitForSeconds (delaySeconds);
		}
	}

}
