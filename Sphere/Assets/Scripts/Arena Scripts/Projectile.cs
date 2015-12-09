using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	
	public LayerMask collisionMask;
	float speed = 10;
	
	public void SetSpeed(float newSpeed) {
		speed = newSpeed;
	}
	
	void Update () {
		float moveDistance = speed * Time.deltaTime;
		CheckCollisions (moveDistance);
		transform.Translate (Vector3.forward * moveDistance);
		Destroy (gameObject, 3.0F);
	}
	
	void CheckCollisions(float moveDistance) {
		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hit;
		
		if (Physics.Raycast (ray, out hit, moveDistance, collisionMask)) {
			OnHitObject(hit);
		}
	}
	
	void OnHitObject(RaycastHit hit) {
		print (hit.collider.gameObject.name);
		GameObject.Destroy (gameObject);
	}
	
	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Enemy") {
			Destroy (col.gameObject);
			Destroy (this.gameObject);
		} else if (col.gameObject.tag == "Box") {
			Destroy (col.gameObject);
			Destroy (this.gameObject);
		} else if (col.gameObject.tag == "Wall") {
			Destroy (this.gameObject);
		}

	}
}
