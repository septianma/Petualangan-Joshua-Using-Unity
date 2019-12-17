using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kontrol : MonoBehaviour {

	public GameObject Player, peluru, posPeluru;
	float fireRate = 0;
	float nextFire = 0;
	// Use this for initialization
	void Start () {
		
	}

	public void tembak(){
		Instantiate (peluru, posPeluru.transform.position, posPeluru.transform.rotation);
	}

	void OnMouseDown(){
		if(gameObject.name == "tombolKiri"){

		} else if(gameObject.name == "tombolKanan"){

		} else if(gameObject.name == "tombolLompat"){
			Player.GetComponent<Player> ().melompat();
		} 
	}

	void OnMouseUp(){
		if(gameObject.name == "tombolKiri"){
			Player.GetComponent<Player> ().berhenti();
		} else if(gameObject.name == "tombolKanan"){
			Player.GetComponent<Player> ().berhenti();
		} else if(gameObject.name == "tombolLompat"){
			
		} else if(gameObject.name == "tombolTembak"){
			tembak();
		}
	}

	void OnMouseDrag(){
		if(gameObject.name == "tombolKiri"){
			Player.GetComponent<Player> ().jalan_kiri();
		} else if(gameObject.name == "tombolKanan"){
			Player.GetComponent<Player> ().jalan_kanan();
		} else if(gameObject.name == "tombolLompat"){
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(fireRate == 0){
			if(Input.GetKeyDown(KeyCode.Space)){
			tembak();
			}
			else{
				if(Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire){
					nextFire = Time.time + nextFire;
					tembak();
				}
			}
		}
	}
}
