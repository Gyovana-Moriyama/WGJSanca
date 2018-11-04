using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card : ScriptableObject 
{
	public string description;
	public string increaseOption;
	public string decreaseOption;
	public int increaseValue;
	public int decreaseValue;
	public abstract void Points(string option);

}