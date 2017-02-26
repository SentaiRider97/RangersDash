using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class ScoreManager : MonoBehaviour {

	public Text scoreText; 
	public Text hiScoreText; 

	public float scoreCount; 
	public float hiScoreCount; 

	public float pointsPerSecond; 

	public bool scoreIncreasing; 

	PlayerController player;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController> ();
	}
	
	// Update is called once per frame


	void Update () {

		if (player.die)
			return;

		if (scoreIncreasing) {
			scoreCount += pointsPerSecond = Time.deltaTime; 
		}


		if (scoreCount > hiScoreCount) {
			hiScoreCount = scoreCount; 
		}


		scoreText.text = "Score: " + Mathf.Round (scoreCount); 
		hiScoreText.text = "High Score: " + Mathf.Round (hiScoreCount); 


	}

	public void AddScore (int pointsToAdd)
	{
		scoreCount += pointsToAdd; 

}

} 



class ACLASS : MonoBehaviour{

	int variable1;

	float variable2;

	void function1(){
	}

	void function2(){
	}

	int fuunction3(int lala){
		return lala;
	}
}