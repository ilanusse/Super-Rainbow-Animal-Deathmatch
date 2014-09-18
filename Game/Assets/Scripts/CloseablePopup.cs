using UnityEngine;
using System.Collections;

public class CloseablePopup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
	}

	void Update() {
		if(Input.anyKeyDown)
			gameObject.SetActive (false);
	}
}
