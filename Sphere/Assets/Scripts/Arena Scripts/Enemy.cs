using UnityEngine;
using System.Collections;

[RequireComponent (typeof(NavMeshAgent))]
public class Enemy : MonoBehaviour {
	
	NavMeshAgent pathfinder;
	Transform target;
	
	void Start () {
		pathfinder = GetComponent<NavMeshAgent> ();
		target = GameObject.FindGameObjectWithTag ("Player").transform;
		
		StartCoroutine (UpdatePath ());
	}
	
	void Update () {

	}
	
	IEnumerator UpdatePath() {
		float refreshRate = .1f;
		
		while (target != null) {
			Vector3 targetPosition = new Vector3(target.position.x, 0, target.position.z);
			pathfinder.SetDestination (targetPosition);
			yield return new WaitForSeconds(refreshRate);
		}
	}
	
	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player") {
			Application.LoadLevel (0);
		}
		
	}
}
