using UnityEngine;
using System.Collections;

public class FinishLevel1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter() {
		Application.LoadLevel ("Level 2");
		//Debug.Log ("Finished!");

	}
}
