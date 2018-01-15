using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controller fuer ein Node Objekt.
/// </summary>
public class NodeController : MonoBehaviour {

	/// <summary>
	/// Das TextObjekt das am Node dranhängt.
	/// </summary>
	public GameObject TextObject;

	/// <summary>
	/// Referenz auf den MainController um dessen methoden nutzen zu können
	/// </summary>
	private GameObject _mainController;
	/// <summary>
	/// Schnellzugriff auf die TextMesh Komnponente des TextObjekts.
	/// </summary>
	private TextMesh _text;

	/// <summary>
	/// Name der Node.
	/// </summary>
	private string _name;
	
	/// <summary>
    	/// Anzahl der eingehenden Kanten in die Node 
    	/// </summary>
    	public int _conditionNumberIn;

	/// <summary>
	/// Get/Set für den Namen der Node
	/// </summary>
	public string Name
	{
		get
		{
			return _name;
		}

		set
		{
			_name = value;
		}
	}


	// Use this for initialization
	void Start () {
		_mainController = GameObject.FindGameObjectsWithTag("MainController")[0];
		_text = TextObject.GetComponent<TextMesh>();

		Name = _mainController.GetComponent<Controller>().getNextName();
		_conditionsNumberIn = 0;
	}
	
	// Update is called once per frame
	void Update () {
		DisplayName();
	}

	/// <summary>
	/// Displays the assigned Name of the Node
	/// might seem a bit redundant now but will allow for changing the name during runtime
	/// </summary>
	public void DisplayName()
	{
		_text.text = Name;
	}

	
}
