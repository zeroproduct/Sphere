using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelScript : MonoBehaviour {

	public Button levelOne;
	public Button levelTwo;
	public Button levelThree;
	public Button exitButton;
	
	void Start () {
		levelOne = levelOne.GetComponent<Button> ();
		levelTwo = levelTwo.GetComponent<Button> ();
		levelThree = levelThree.GetComponent<Button> ();
		exitButton = exitButton.GetComponent<Button> ();
	}
	
	public void StartLevelOne() {
		Application.LoadLevel (2);
	}

	public void StartLevelTwo() {
		Application.LoadLevel (3);
	}

	public void StartLevelThree() {
		Application.LoadLevel (4);
	}

	public void ExitGame() {
		Application.Quit ();
	}
}
