using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeluruKontrol : MonoBehaviour {
	float scale_karakter;
	///public GameObject explosionEffect;
	public float weaponDamage;

	// Use this for initialization
	void Start () {
		scale_karakter = GameObject.Find("PlayerIdle").transform.localScale.x;
	}
	
	// Update is called once per frame
	void Update () {
		if(scale_karakter == 0.5f){
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (12f, GetComponent<Rigidbody2D>().velocity.y);
		}
		else{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-12f, GetComponent<Rigidbody2D>().velocity.y);
		}
	}

	void OnTriggerEnter2D(Collider2D obj){
		if(obj.gameObject.name == "Batas" || obj.gameObject.name == "Batas2"){
			Destroy (gameObject);
		}
		if(obj.gameObject.layer == LayerMask.NameToLayer("TargetTembak")){
			///Instantiate(explosionEffect, transform.position, transform.rotation);
			Destroy (gameObject);
			if(obj.gameObject.tag == "Enemy"){
				enemyHealth hurtEnemy = obj.gameObject.GetComponent<enemyHealth>();
				hurtEnemy.addDamage(weaponDamage);
			}
		}
		
	}

	void OnTriggerStay2D(Collider2D obj){
		if(obj.gameObject.name == "Batas" || obj.gameObject.name == "Batas2"){
			Destroy (gameObject);
		}
		if(obj.gameObject.layer == LayerMask.NameToLayer("TargetTembak")){
			///Instantiate(explosionEffect, transform.position, transform.rotation);
			Destroy (gameObject);
			if(obj.gameObject.tag == "Enemy"){
				enemyHealth hurtEnemy = obj.gameObject.GetComponent<enemyHealth>();
				hurtEnemy.addDamage(weaponDamage);
			}
		}
		
	}

	public void removeForce(){
		GetComponent<Rigidbody2D> ().velocity = new Vector2(0,0);
	}
}
 