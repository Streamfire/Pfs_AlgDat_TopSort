using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CONDITIONS
{
VOR,NACH
}

public class ConditionData{

	private GameObject _nodeA;
	private GameObject _nodeB;

	private byte _condition;

	public ConditionData()
	{
		NodeA = null;
		NodeB = null;
		_condition = (byte)CONDITIONS.VOR;
	}

	public ConditionData(GameObject NodeA,GameObject NodeB)
	{
		this.NodeA = NodeA;
		this.NodeB = NodeB;
		_condition = (byte)CONDITIONS.VOR;
	}

	public ConditionData(GameObject NodeA, GameObject NodeB,CONDITIONS c)
	{
		this.NodeA = NodeA;
		this.NodeB = NodeB;
		_condition = (byte)c;
	}

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
