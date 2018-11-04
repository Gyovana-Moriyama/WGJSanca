using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card : ScriptableObject 
{
	[SerializeField] public Sprite frontCardSprite;
	[SerializeField] public Sprite backCardSprite;  
	[SerializeField] public string increaseText;  
    [SerializeField] public string decreaseText; 
	private SpriteRenderer spriteRenderer;
	public string description;
	[SerializeField] public string increaseOption; 
	[SerializeField] public string decreaseOption; 
	[SerializeField] public int increaseValue;  
	[SerializeField] public int decreaseValue; 
	[SerializeField] public bool isAnswer;
	public abstract int Points(string option);
}