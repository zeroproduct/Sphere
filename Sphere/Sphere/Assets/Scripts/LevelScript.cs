using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelScript : MonoBehaviour {

	public Button levelOne;
	public Button levelTwo;
	public Button backButton;
	
	void Start () {
		levelOne = levelOne.GetComponent<Button> ();
		levelTwo = levelTwo.GetComponent<Button> ();
		backButton = backButton.GetComponent<Button> ();
	}
	
	public void StartLevelOne() {
		Application.LoadLevel ("Level_1");
	}

	public void StartLevelTwo() {
		Application.LoadLevel ("Level_2");
	}

	public void goToMenu() {
		Application.LoadLevel ("Menu");
	}
}
