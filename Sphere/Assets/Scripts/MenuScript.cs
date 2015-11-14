﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public Button startText;
	public Button exitText;
	
	void Start () {
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
	}

	public void StartLevel() {
		Application.LoadLevel (1);
	}

	public void ExitGame() {
		Application.Quit ();
	}

}
