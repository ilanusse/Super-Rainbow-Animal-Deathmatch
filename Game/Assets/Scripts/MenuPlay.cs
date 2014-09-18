using UnityEngine;
using System.Collections;

public class MenuPlay : MonoBehaviour {

	public void play() {
		Time.timeScale = 1;
		Application.LoadLevel("mainScene"); 
	}
}
