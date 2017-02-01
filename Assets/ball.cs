using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
using UnityEngine.Advertisements.SceneManagement 

public class ball : MonoBehaviour {

	bool beingHeldByMouse = false; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 mouseScreenPos = Input.mousePosition; 
		Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint (mouseScreenPos);

		if (beingHeldByMouse) { 

			transform.position = new Vector3 (mouseWorldPos.x, mouseWorldPos.y, 0); 
			if (!Input

		} else {
			if (Input.GetMouseButtonDown (0)) { 
				Collider2D ourCollider = GetComponent<Collider2D>();
				if (ourCollider.OverlapPoint (mouseWorldPos)) { 
					beingHeldByMouse = true; 
				}
			}
		}
	}
				void OnTriggerEnter2D(Collider2D otherCollider) { 

		SceneManager.LoadScene ("GoalScene"); 

					Debug.Log(GOAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAALLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL!!!!!!)
	} 
}
