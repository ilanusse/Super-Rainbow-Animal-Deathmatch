using UnityEngine;
using System.Collections;

public class FinishManager : MonoBehaviour {

	public PlayerEnd player1End;
	public PlayerEnd player2End;
	public GameObject generalEnd;
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
				player1End.win();
				player2End.lose();
			} else {
				player1End.lose();
				player2End.win();
			}
			generalEnd.SetActive(true);
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
