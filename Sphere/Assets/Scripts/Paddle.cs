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
	private float timer = 0;
	public float airSpeed = 1000f;
	public int checkpoint = 2;
	void Start(){
		rb = GetComponent <Rigidbody> ();
		
	}
	void update ()
	{

	}


	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3(0, 0.0f, moveVertical);
		movement = Camera.main.transform.TransformDirection (movement);
		movement.y = 0;
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
		if (transform.position.y < -10 && checkpoint == 0)
		{
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (1.736405f, 3.638f, -3.824f);
		} 
		else if (transform.position.y < -10 && checkpoint == 1) 
		{
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (3.28f, -2.27f, 37.75f);
		}
		else if (transform.position.y < -10 && checkpoint == 2)
		{
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (13.05f, 2.27f, 58f);
		}
		else if (transform.position.y < -10 && checkpoint == 3)
		{
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (25.39f, 2.22f, 75.41f);
		}
		else if (transform.position.y < -10 && checkpoint == 4)
		{
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (32.92f, -7.63f, 104f);
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Checkpoint") {
			other.gameObject.SetActive (false);
			checkpoint++;
		}
	}
	void OnCollisionEnter (Collision collisionInfo)
	{
		if (collisionInfo.gameObject.tag == "Trap") {
			transform.position = new Vector3 (13.05f, 2.27f, 58f);
		}
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

