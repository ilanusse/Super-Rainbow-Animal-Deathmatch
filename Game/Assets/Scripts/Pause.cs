using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	private bool paused = false;
	public KeyCode pauseKey = KeyCode.Escape;
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (pauseKey)) {
			if(paused) {
				Time.timeScale = 1;
				paused = false;
			} else {
				Time.timeScale = 0;
				paused = true;
			}
		}
	}
}
