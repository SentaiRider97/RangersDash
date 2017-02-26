using UnityEngine;
using System.Collections;

public class madamewoeshooting : MonoBehaviour {
	public GameObject fireball; 

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	public void shooting () { 
		Debug.Log ("shoot");
		Instantiate(fireball, transform.position, Quaternion.identity);
	} 
}
