using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
/// Datenstruktur die eine einzelne Kondition für zwei Nodes speichert.
/// </summary>
public class ConditionData{

	/// <summary>
	/// Die Node von der Die Kondition Ausgeht
	/// </summary>
	private GameObject _nodeA;
	/// <summary>
	/// Die Node auf die die Kondition trifft.
	/// </summary>
	private GameObject _nodeB;


	/// <summary>
	/// Standardkonstruktor.
	/// </summary>
	public ConditionData()
	{
		NodeA = null;
		NodeB = null;
	}

	/// <summary>
	/// Konstruktor der 2 Nodes ohne Condition vereint.
	/// </summary>
	/// <param name="NodeA">Ausgangsknoten</param>
	/// <param name="NodeB">Zielknoten</param>
	public ConditionData(GameObject NodeA,GameObject NodeB)
	{
		this.NodeA = NodeA;
		this.NodeB = NodeB;
	}

	/// <summary>
	/// Get/Set für die Ausgangsnode.
	/// </summary>
	public GameObject NodeA
	{
		get
		{
			return _nodeA;
		}

		set
		{
			_nodeA = value;
		}
	}

	/// <summary>
	/// Get/Set für die ZielNode.
	/// </summary>
	public GameObject NodeB
	{
		get
		{
			return _nodeB;
		}

		set
		{
			_nodeB = value;
		}
	}

}
