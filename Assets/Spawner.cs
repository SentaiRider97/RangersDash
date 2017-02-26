using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject whatever;
	public GameObject coin;
	public GameObject monster;
	public GameObject madamewoe; 
	// Use this for initialization
	void Start () {
//		Instantiate (coin, whatever.transform.position + Vector3.right * 4, Quaternion.identity);
//		Instantiate (monster, whatever.transform.position + Vector3.right * 30, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
//		if (Time.frameCount % 120 == 0) {
//			Instantiate (coin, whatever.transform.position + Vector3.right * 4, Quaternion.identity);
//			Instantiate (coin, whatever.transform.position + Vector3.right * 8, Quaternion.identity);
//			Instantiate (coin, whatever.transform.position + Vector3.right * 12, Quaternion.identity);
//			Instantiate (coin, whatever.transform.position + Vector3.right * 16, Quaternion.identity);
//			Instantiate (coin, whatever.transform.position + Vector3.right * 20, Quaternion.identity);
//			Instantiate (monster, whatever.transform.position + Vector3.right * 5, Quaternion.identity);
//			Instantiate (monster, whatever.transform.position + Vector3.right * 10, Quaternion.identity);
//			Instantiate (monster, whatever.transform.position + Vector3.right * 15, Quaternion.identity);
//			Instantiate (monster, whatever.transform.position + Vector3.right * 20, Quaternion.identity);
//			Instantiate (monster, whatever.transform.position + Vector3.right * 25, Quaternion.identity);
//		
		if (Time.frameCount % 30 == 0) {
			if(Random.value > 0.5f)
			Instantiate (coin, transform.position, Quaternion.identity);
		}

		if (Time.frameCount % 60 == 0) {
			Instantiate (monster, transform.position, Quaternion.identity);
		}
	if (Time.frameCount % 90 == 0) {
		Instantiate (madamewoe, transform.position, Quaternion.identity);
	}
}
} 