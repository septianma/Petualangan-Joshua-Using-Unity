using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed, scaleX, lompat;
	float lompatLompat = 0;
	float nextLompat = 0;
	// Use this for initialization
	void Start () {
		scaleX = transform.localScale.x;
	}

	public void jalan_kiri(){
		if(GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("PlayerIdle")){
			GetComponent<Animator> ().SetTrigger("Lari");
		}
		transform.localScale = new Vector3 (-scaleX,transform.localScale.y,transform.localScale.z);
		transform.Translate (Vector3.left*speed*Time.fixedDeltaTime, Space.Self);
	}

	public void jalan_kanan(){
		if(GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("PlayerIdle")){
			GetComponent<Animator> ().SetTrigger("Lari");
		}
		transform.localScale = new Vector3 (scaleX,transform.localScale.y,transform.localScale.z);
		transform.Translate (Vector3.right*speed*Time.fixedDeltaTime, Space.Self);
	}

	public void melompat(){
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,lompat);
	}

	public void berhenti(){
		GetComponent<Animator> ().SetTrigger ("Diam");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey (KeyCode.LeftArrow)){
			jalan_kiri();
		}
		if(Input.GetKey (KeyCode.RightArrow)){
			jalan_kanan();
		}
		if(lompatLompat == 0){
			if(Input.GetKeyDown (KeyCode.UpArrow)){
			melompat();
			}
			else
			{
				if(Input.GetKeyDown(KeyCode.UpArrow) && Time.time > nextLompat){
					nextLompat = Time.time + nextLompat;
					melompat();
				}
			}
		}
		if(Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)){
			berhenti();
		}
	}
}
