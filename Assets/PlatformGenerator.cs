using UnityEngine;
using System.Collections;

public class PlatformGenerator : MonoBehaviour {

	public GameObject thePlatform; 
	public Transform generationPoint; 
	public float distanceBetween; 
	SpriteRenderer sprt;
	PlayerController thunderMegazord;
	// Use this for initialization
	void Start () {
		//platformWidth = thePlatform.GetComponent<BoxCollider2D> ().size.x; 
		sprt = GetComponent<SpriteRenderer>();
		thunderMegazord = FindObjectOfType<PlayerController> ();
	}
	


	// Update is called once per frame
	void Update () {
	 

//		if (transform.position.x < generationPoint.position.x) 
//		{
//			//transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position
//
//			Instantiate (thePlatform, transform.position, transform.rotation); 
//
//	     }
		sprt.material.mainTextureOffset += Vector2.right *thunderMegazord.GetComponent<Rigidbody2D>().velocity.x * 0.01f * Time.deltaTime;
	}
}
