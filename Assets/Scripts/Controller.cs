using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The Main Controller script, anything that affects all aspects of the Application should end up here.
/// </summary>
public class Controller : MonoBehaviour {

	/// <summary>
	/// Referenz auf den Button unten links zum hinzufügen von Nodes
	/// </summary>
	public GameObject AddButton;
	/// <summary>
	/// Referenz auf das NodePrefab
	/// </summary>
	public GameObject NodePrefab;
	/// <summary>
	/// Prefab für den Dialog zum hinzufügen neuer nodes
	/// </summary>
	public GameObject DialogPrefab;
	
	/// <summary>
	/// der nächste Default Name für eine Node
	/// </summary>
	private int _nextDefaultName;
	/// <summary>
	/// Der nächste Custom Name für die NÄCHSTE Node die einen abfragt.
 	/// </summary>
	private string _nextName;
	
	/// <summary>
	/// Liste der Node Objekte
	/// </summary>
	private LinkedList<GameObject> _nodes;

	/// <summary>
	/// list of Conditions that apply while sorting.
	/// </summary>
	private LinkedList<ConditionData> _cond;

	/// <summary>
	/// zur initialisierung des GameControllerObjects
	/// </summary>
	void Start () {
		_nextDefaultName = 0;
		_nextName = "";
		_nodes = new LinkedList<GameObject>();
	}
	
	/// <summary>
	/// Einmal pro Frame aufgerufen,
	/// prüft ob ESC gedrückt, wenn ja Programm beenden.
	/// </summary>
	void Update () {
		

		if(Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}
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
	/// shows a dialog to add a customnamed prefab of a node.
	/// Deactivates the Button it is connected to, so only 1 Dialog at a time is open.
	/// </summary>
	public void AddButtonClicked()
	{
		AddButton.SetActive(false);
		Instantiate(DialogPrefab);
	}

	/// <summary>
	/// called when either one of the dialog buttons was pressed
	/// </summary>
	/// <param name="nodeName">the name of the newly created node, "___empty___" to use a default name
	/// "___cancel___" to not create a node at all</param>
	public void DialogClosed(string nodeName)
	{if (nodeName != "___cancel___")
		{
			float x = (-8 + (1.5f * (_nodes.Count / 8)));
			float y = (4.5f - (1 * ((_nodes.Count) % 8)));

			AddNode(x, y, nodeName);
		}
		AddButton.SetActive(true);
	}

	/// <summary>
	/// Adds a Node to the end of the _nodes List.
	/// </summary>
	public void AddNode(float x,float y, string name)
	{
		if (name != "___empty___")
		{
			_nextName = name;
		}
		else
		{
			_nextName = "___empty___";
		}

		_nodes.AddLast(Instantiate(NodePrefab));
		_nodes.Last.Value.transform.position = new Vector3(x, y, 0);
	}

	/// <summary>
	///Adds a Condition to the list of conditions.
	/// </summary>
	/// <param name="condition"></param>
	public void AddCondition(ConditionData condition)
	{
		_cond.AddLast(condition);
	}


}
