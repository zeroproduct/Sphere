using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	private Vector3 pos = new Vector3 (5,-1,2);
	public float speed = 1000F;
	public float jumpSpeed = 10.0F;
	public float gravity = 10.0F;
	public Rigidbody rb;
	public Camera camera;
	public bool isGrounded;
	public float boost = 3F;
	public float extraTime = 3F;
	private float timer = 0;
	public float airSpeed = 1000f;
	void Start(){
		rb = GetComponent <Rigidbody> ();
		
	}
	void update ()
	{

	}


	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		movement = Camera.main.transform.TransformDirection (movement);
		if (isGrounded == true) {
			rb.AddForce (movement * speed * Time.deltaTime);
		} 
		else if (isGrounded == false) {
			rb.AddForce (movement * airSpeed * Time.deltaTime);
		}
			if (Input.GetButton ("Jump")&& isGrounded==true) {
			Vector3 jumping = new Vector3 (0, jumpSpeed, 0);
			rb.AddForce (jumping);

		}
		if(transform.position.y <-10)
		{
			transform.position = new Vector3(0,2,0);
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Cube") {
			other.gameObject.SetActive (false);
		}
	}
	void OnCollisionEnter (Collision collisionInfo)
	{
		isGrounded = true;
	}
	void OnCollisionStay (Collision collisionInfo)
	{
		isGrounded = true;
	}
	void OnCollisionExit (Collision collisionInfo)
	{
		isGrounded = false;
	}
}

