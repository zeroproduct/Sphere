using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

	void Start () {
	
	}

	void Update () {
		transform.Rotate (new Vector3 (0, 0, 0.5F));
	}

	void OnTriggerEnter(Collider col) {

		if (col.gameObject.tag == "Key") {
			Destroy (this.gameObject);
			Destroy (GameObject.FindGameObjectWithTag("Dungeon2Gate"));
		}

		//Destroy (this.gameObject);
		//Destroy (GameObject.FindGameObjectWithTag ("Door"));
	}
}
