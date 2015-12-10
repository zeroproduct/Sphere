using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class timeManager : MonoBehaviour {

	public int score;
	public Texture scoreText;

	// Use this for initialization
	void Start () {
		PlayerPrefs.GetInt ("scorePref");
		//score =
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
