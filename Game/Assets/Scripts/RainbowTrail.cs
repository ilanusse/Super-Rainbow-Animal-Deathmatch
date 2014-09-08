using UnityEngine;
using System.Collections;

public class RainbowTrail : MonoBehaviour
{
	public float time = 2.0f;
	public int rate = 10;
	
	private Vector3[] arv3;
	private int head;
	private int tail= 0;
	private float sliceTime;
	private RaycastHit hit;
	public GameObject player;
	
	void  Start (){
		sliceTime = 1.0f / rate;
		arv3 = new Vector3[(Mathf.RoundToInt(time * rate) + 1)];
		
		for (int i= 0; i < arv3.Length; i++)
			arv3[i] = player.transform.position;
		head = arv3.Length-1;
		StartCoroutine(CollectData());
	}
	
	IEnumerator CollectData (){
		while (true) {
			if (player.transform.position != arv3[head]) {
				head = (head + 1) % arv3.Length;
				tail = (tail + 1) % arv3.Length;
				arv3[head] = player.transform.position;
			}
			yield return new WaitForSeconds(sliceTime);
		}
	}
	
	void  Update (){
		if (Hit ()) {
			Destroy(hit.collider.gameObject);
			Debug.Log ("I hit: " + hit.collider.name);
		}
	}
	
	bool Hit (){
		int i= head;
		int j= (head  - 1);
		if (j < 0) j = arv3.Length - 1;
		
		while (j != head) {
			
			if (Physics.Linecast(arv3[i], arv3[j], out hit))
				return true;
			i = i - 1; 
			if (i < 0) i = arv3.Length - 1;
			j = j - 1;
			if (j < 0) j = arv3.Length - 1;
		}
		return false;
	}
}

