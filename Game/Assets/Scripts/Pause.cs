using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public KeyCode pauseKey = KeyCode.Escape;
	public AudioSource audio;
	public FinishManager fm;
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (pauseKey) && !fm.done) {
			audio.Pause();
			Time.timeScale = 0;
			gameObject.GetComponent<OpenPopup>().openPopup();
		}
	}
}
