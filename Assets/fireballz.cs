using UnityEngine;
using System.Collections;

public class fireballz : MonoBehaviour {
	public PlayerController pewPew; 
	Vector3 targetPos;
	// Use this for initialization
	void Start () {
		pewPew = FindObjectOfType<PlayerController> ();
		targetPos = pewPew.transform.position;	
	}
	
	// Update is called once per frame
	void Update () {
		MoveTowardTargetPosition ();
	}

	void MoveTowardTargetPosition (){
		transform.position = Vector3.MoveTowards(transform.position,targetPos,0.5f);
	}	
}
