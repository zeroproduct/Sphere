using UnityEngine;
using System.Collections;

public class PortalToMenu : MonoBehaviour {

	//chances scene on collision
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			Application.LoadLevel ("GameOver");

		}
	
	}
}
