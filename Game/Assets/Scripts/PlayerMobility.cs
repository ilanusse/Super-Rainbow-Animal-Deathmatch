using UnityEngine;
using System.Collections;
using System;

public class PlayerMobility : MonoBehaviour {

	public float turnSpeed;
	public float speed;
	public KeyCode leftKey = KeyCode.A;
	public KeyCode rightKey = KeyCode.D;
	public KeyCode jumpKey = KeyCode.Space;
	public float jumpForce;
	private Boolean midair = false;

	void FixedUpdate() {
		Vector3 vel = transform.forward * speed;
		rigidbody.angularVelocity = new Vector3 (0, 0, 0);
		rigidbody.rotation = new Quaternion (0f, rigidbody.rotation.y, rigidbody.rotation.z, rigidbody.rotation.w);
		rigidbody.velocity = new Vector3 (vel.x, rigidbody.velocity.y, vel.z);
		
		if (Input.GetKey (leftKey)) {
			transform.Rotate (-Vector3.up * turnSpeed * Time.deltaTime);
		} 
		if (Input.GetKey (rightKey)) {
			transform.Rotate (Vector3.up * turnSpeed * Time.deltaTime);
		}
		if (Input.GetKey (jumpKey)) {
			if(!midair) {
				rigidbody.AddForce(new Vector3(0f, jumpForce, 0f));
				midair = true;
			}
		}
	}

	void OnCollisionEnter(Collision col) {
		midair = false;
	}
}