using UnityEngine;
using System.Collections;

public class ClosePopup : MonoBehaviour {
	
	public GameObject popup;
	
	public void closePopup() {
		popup.SetActive (false);	
	}
}