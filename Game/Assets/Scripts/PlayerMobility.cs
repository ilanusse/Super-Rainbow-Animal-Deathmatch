using UnityEngine;
using System.Collections;
using System;

public class PlayerMobility : MonoBehaviour {

	public float speed;
	private Animator animCtrl;
	private bool dead;
	private bool walk;  

	void Start() {
		animCtrl = GetComponent<Animator>();
		walk = false;
		dead = false;
	}

	void FixedUpdate() {
		var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Quaternion rot = Quaternion.LookRotation (transform.position - mousePosition, Vector3.forward);
		transform.rotation = rot;
		transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);
		rigidbody2D.angularVelocity = 0;

		/*float input = Input.GetAxis ("Vertical");
		rigidbody2D.AddForce (gameObject.transform.up * speed * input);*/

		if (Input.GetKey (KeyCode.W)) {
			var dif = (mousePosition - transform.position);
			if (Math.Abs(dif.x) > 0.1f || Math.Abs(dif.y) > 0.1f){
				rigidbody2D.AddForce (gameObject.transform.up * speed);
			}
			walk = true;
			animCtrl.SetBool ("walk", true);
		} else if(Input.GetKey(KeyCode.A)) {
			rigidbody2D.AddForce(-gameObject.transform.right * speed);
			walk = true;
			animCtrl.SetBool ("walk", true);
		} else if(Input.GetKey(KeyCode.S)) {
			rigidbody2D.AddForce(-gameObject.transform.up * 0.7f * speed);
			walk = true;
			animCtrl.SetBool ("walk", true);
		} else if(Input.GetKey(KeyCode.D)) {
			rigidbody2D.AddForce(gameObject.transform.right * speed);
			walk = true;
			animCtrl.SetBool ("walk", true);
		} else {
			walk = false;
			animCtrl.SetBool ("walk", false);
		}
	}
}