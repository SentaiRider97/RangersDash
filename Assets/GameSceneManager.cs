using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftShift)) {
			SceneManager.LoadScene ("Restart"); 

		}
		if (Input.GetKeyDown (KeyCode.R)) {
			SceneManager.LoadScene ("animation"); 
	}
}

}
