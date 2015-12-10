using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public Button startText;
	public Button exitText;

	Vector3 spawnPosition;
	public GameObject SpherePrefab;
	GameObject spherePrefabClone;

	
	void Start () {
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
	}

	void FixedUpdate() {
		//spawnPosition = new Vector3 (Random.Range (-130.0F, 130.0F), Random.Range (-80.0F, 80.0F), 130.0F);
		//spherePrefabClone = (GameObject)Instantiate (SpherePrefab, spawnPosition, SpherePrefab.transform.rotation);
		//Destroy (spherePrefabClone, 0.5F);
	}

	public void StartLevel() {
		Application.LoadLevel ("LevelSelect");
	}

	public void ExitGame() {
		Application.Quit ();
	}

}
