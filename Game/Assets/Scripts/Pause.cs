using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public KeyCode pauseKey = KeyCode.Escape;
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (pauseKey)) {
			Time.timeScale = 0;
			gameObject.GetComponent<OpenPopup>().openPopup();
		}
	}
}
