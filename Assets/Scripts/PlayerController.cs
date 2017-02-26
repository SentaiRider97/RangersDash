using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour {

	public float moveSpeed; 
	public float jumpForce; 
	public Text dieText; 

	private Rigidbody2D myRigidbody; 

	public bool grounded;
	public LayerMask whatIsGround; 

//	private Collider2D myCollider;

	private Animator myAnimator; 

	public bool die;

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent <Rigidbody2D> (); 

//		myCollider = GetComponent<Collider2D> (); 

		myAnimator = GetComponent<Animator> (); 
	}
	
	// Update is called once per frame
	void Update () {
		if (die) {
			Die ();
			return;	
		}
		myRigidbody.velocity = new Vector2 (moveSpeed, myRigidbody.velocity.y);

		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
			myRigidbody.velocity = new Vector2 (myRigidbody.velocity.x, jumpForce); 
		}
		
		
		if(Input.GetKeyDown(KeyCode.Return))
		{
			
			myAnimator.Play ("slash"); 
		   } 

		}

	void Die(){
		myRigidbody.velocity = Vector2.zero;
		myAnimator.Play ("megazorddown"); 
		dieText.text = "Game Over! Rita has won!\nContinue? Press \"R\"";
	}
   
    } 




