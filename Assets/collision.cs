using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.name == "Player") 
		{
			other.GetComponent<PlayerController> ().die = true;
//			if (other.transform.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("slash")){
//				Destroy (gameObject); 
//			}
		}
		if (other.gameObject.tag == "Blade") 
		{
			Destroy (gameObject);
		}
     }
}


