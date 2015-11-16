using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {
	
	public void MainMenu()
	{
		Application.LoadLevel("Menu");
	}
	
	public void Quit(){
		Application.Quit ();
	}
}
