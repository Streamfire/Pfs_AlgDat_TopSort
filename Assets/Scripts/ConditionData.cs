using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Enum fuer die States einer Kondition Vor und Nach
/// </summary>
public enum CONDITION
{
VOR,NACH, NONE
}

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
	/// Die Kondition die angibt ob A vor B oder A nach B.
	/// </summary>
	private CONDITION _condition;

	/// <summary>
	/// Standardkonstruktor.
	/// </summary>
	public ConditionData()
	{
		NodeA = null;
		NodeB = null;
		Condition = CONDITION.NONE;
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
		Condition = CONDITION.NONE;
	}
	/// <summary>
	/// Konstruktor der 2 Nodes und eine Condition vereint.
	/// </summary>
	/// <param name="NodeA">Ausgangsknoten</param>
	/// <param name="NodeB">Zielknoten</param>
	/// <param name="c">Kondition aus der Condition enum</param>
	public ConditionData(GameObject NodeA, GameObject NodeB,CONDITION c)
	{
		this.NodeA = NodeA;
		this.NodeB = NodeB;
		Condition = c;
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

	/// <summary>
	/// Get/Set für die Kondition.
	/// </summary>
	public CONDITION Condition
	{
		get
		{
			return _condition;
		}

		set
		{
			_condition = value;
		}
	}
}
