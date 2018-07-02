using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {
	
	[SerializeField] Text textComponent;
	[SerializeField] State startingState;

	State state;

	// Use this for initialization
	void Start () {
		textComponent.text = ("Welcome to the future...");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
