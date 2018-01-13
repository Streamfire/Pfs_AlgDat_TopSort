using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Steuert die Bewegung der Kamera.
/// </summary>
public class CamController : MonoBehaviour {

	/// <summary>
	/// minimalwerte für XYZ der Kamera
	/// </summary>
	public float MinX,MinY,MinZ;
	/// <summary>
	/// Maximalwerte der Kamera
	/// </summary>
	public float MaxX, MaxY, MaxZ;
	/// <summary>
	/// Bewegungsgeschwindigkeit der Kamera.
	/// </summary>
	public float Speed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		moveCam();
	}

	/// <summary>
	/// von Update aufgerufen, Prüft Tastatureingabe und bewegt die Kamera entsprechend,
	/// relativ zur seit dem letzten Frame vergangenen Zeit.
	/// </summary>
	private void moveCam()
	{ 
		if(Input.GetKey(KeyCode.UpArrow))
		{
			//y+
			gameObject.transform.Translate(0, Speed * Time.deltaTime, 0);
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			//x-
			gameObject.transform.Translate(-Speed * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			//y-
			gameObject.transform.Translate(0, -Speed * Time.deltaTime, 0);
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			//x+
			gameObject.transform.Translate(Speed * Time.deltaTime, 0, 0);
		}
	
	}

	/// <summary>
	/// Hält die kamera in den von min und max werten festgelegten Rahmen.
	/// </summary>
	private void keepBounds()
	{

	}

}
