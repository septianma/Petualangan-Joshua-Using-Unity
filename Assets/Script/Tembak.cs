using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tembak : MonoBehaviour {
	public GameObject peluru, posPeluru;

	// Use this for initialization
	void Start () {
		
	}

	void OnMouseDown(){
		Instantiate (peluru, posPeluru.transform.position, posPeluru.transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
