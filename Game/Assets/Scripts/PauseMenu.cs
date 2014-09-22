using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public AudioSource audio;

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
	}

	public void unpause() {
		audio.Play ();
		Time.timeScale = 1;
		gameObject.SetActive(false);
	}

	public void retry() {
		unpause ();
		Application.LoadLevel(Application.loadedLevel);
	}
}
