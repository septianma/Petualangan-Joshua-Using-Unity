using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour {

	// Use this for initialization
	private void OnTriggerEnter2D(Collider2D collision){
		if(collision.CompareTag("Player")){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			Debug.Log("Die");
		}
	}
}
