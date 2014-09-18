using UnityEngine;
using System.Collections;

public class GoToMenu : MonoBehaviour {
	
	public void exit() {
		Application.LoadLevel("menuScene"); 
	}
}
