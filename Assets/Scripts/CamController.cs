using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour {

	public float MinX,MinY,MinZ;
	public float MaxX, MaxY, MaxZ;
	public float Speed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		moveCam();
	}

	private void moveCam()
	{ 
		if(Input.GetKey(KeyCode.W))
		{
			//y+
			gameObject.transform.Translate(0, Speed * Time.deltaTime, 0);
		}
		if (Input.GetKey(KeyCode.A))
		{
			//x-
			gameObject.transform.Translate(-Speed * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey(KeyCode.S))
		{
			//y-
			gameObject.transform.Translate(0, -Speed * Time.deltaTime, 0);
		}
		if (Input.GetKey(KeyCode.D))
		{
			//x+
			gameObject.transform.Translate(Speed * Time.deltaTime, 0, 0);
		}
	
	}

	private void keepBounds()
	{

	}

}
