using UnityEngine;
using System.Collections;

public class PlayerEnd : MonoBehaviour {

	public GameObject menu;
	public GameObject victory;
	public GameObject defeat;		

	public void win() {
		menu.SetActive (true);	
		victory.SetActive (true);
		defeat.SetActive (false);
	}

	public void lose() {
		menu.SetActive (true);
		victory.SetActive (false);
		defeat.SetActive (true);
	}
}
