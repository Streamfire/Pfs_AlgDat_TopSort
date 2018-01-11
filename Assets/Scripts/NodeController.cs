using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeController : MonoBehaviour {


	public GameObject TextObject;


	private GameObject _mainController;
	private TextMesh _text;
	private string _name;

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
