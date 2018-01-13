using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Dialog zum hinzufügen eines neuen Knotens
/// </summary>
public class AddDialogController : MonoBehaviour {

	/// <summary>
	/// Main Controller Referenz
	/// </summary>
	private GameObject _mainController;
	/// <summary>
	/// Referenz auf das Eingabefeld des Dialogs
	/// </summary>
	public GameObject TextField;

	private void Start()
	{
		_mainController = GameObject.FindGameObjectWithTag("MainController");
	}
	/// <summary>
	/// The Cancel Button of the Dialog was pressed,
	/// the GameController is informed
	/// The dialog is closed
	/// </summary>
	public void BtnCnclDown()
	{
		_mainController.GetComponent<Controller>().DialogClosed("___cancel___");
		Destroy(gameObject.transform.root.gameObject);
	}
	/// <summary>
	/// The Accept Button of the Dialog was pressed,
	/// the GameController is informed
	/// the dialog is closed.
	/// </summary>
	public void BtnAcptDown()
	{
		if (TextField.GetComponent<UnityEngine.UI.Text>().text == "")
		{ 
			_mainController.GetComponent<Controller>().DialogClosed("___empty___");
		}
		else
		{
			_mainController.GetComponent<Controller>().DialogClosed(TextField.GetComponent<UnityEngine.UI.Text>().text);
		}
			
		Destroy(gameObject.transform.root.gameObject);
	}
}
