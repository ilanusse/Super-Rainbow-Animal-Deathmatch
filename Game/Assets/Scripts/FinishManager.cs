using UnityEngine;
using System.Collections;

public class FinishManager : MonoBehaviour {

	public OpenPopup player1Wins;
	public OpenPopup player2Wins;
	public GameObject player1;
	public GameObject player2;
	public GameObject explosion;	
	public float maxFall;
	public int endTime;
	public bool done = false;

	public void finish(int player) {
		if (!done) {
			done = true;
			Invoke ("stopTime", endTime); 
			if (player == 1) {
				player1Wins.openPopup ();
			} else {
				player2Wins.openPopup ();
			}
		}
	}

	void Update() {
		if (player1.transform.position.y < maxFall) {
			Destroy(player1);
			Instantiate(explosion, player1.transform.position, Quaternion.identity);
			finish (2);
		} else if (player2.transform.position.y < maxFall) {
			Destroy(player2);
			Instantiate(explosion, player2.transform.position, Quaternion.identity);
			finish(1);
		}
	}

	void stopTime() {
		Time.timeScale = 0;
	}
}
