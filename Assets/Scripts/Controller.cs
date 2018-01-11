using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	public GameObject AddButton;
	public GameObject NodePrefab;
	public GameObject DialogPrefab;
	

	private int _nextDefaultName;
	private string _nextName;
	private LinkedList<GameObject> _nodes;

	// Use this for initialization
	void Start () {
		_nextDefaultName = 0;
		_nextName = "";
		_nodes = new LinkedList<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/// <summary>
	/// returns the next default name for a node
	/// </summary>
	/// <returns></returns>
	public string getNextName()
	{
		
		if(_nextName== "___empty___")
		{
			_nextDefaultName++;
			return _nextDefaultName.ToString();
		}
		else
		{
			return _nextName;
		}
	}

	/// <summary>
	/// shows a dialoge to add a customnamed prefab of a node
	/// </summary>
	public void AddButtonClicked()
	{
		AddButton.SetActive(false);
		Instantiate(DialogPrefab);
	}

	/// <summary>
	/// called when either one of the dialog buttons was pressed
	/// when there's no string given the dialog was canceled,
	/// otherwise the given string becomes the name of the new node.
	/// </summary>
	/// <param name="nodeName">the name of the newly created node</param>
	public void DialogClosed(string nodeName)
	{
		if (nodeName != "___empty___")
		{
			_nextName = nodeName;
		}
		else
			_nextName = "___empty___";

		_nodes.AddLast(Instantiate(NodePrefab));
		float x = (-8 + (1.5f * (_nodes.Count / 8)));
		float y= (4.5f - (1*((_nodes.Count) % 8)));
		_nodes.Last.Value.transform.position=new Vector3(x,y,0);

		AddButton.SetActive(true);
	}

}
