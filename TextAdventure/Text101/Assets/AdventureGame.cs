using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {
	
	[SerializeField] Text textComponent;
	[SerializeField] State startingState;

	string[] oddNumbers = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

	State state;

	// Use this for initialization
	void Start () {
		state = startingState;
		textComponent.text = state.GetStateStory();
		Debug.Log(oddNumbers[3]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
