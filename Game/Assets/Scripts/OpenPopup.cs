using UnityEngine;
using System.Collections;

public class OpenPopup : MonoBehaviour {

	public GameObject popup;
	
	public void openPopup() {
		popup.SetActive (true);	
	}
}
