using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyHealth : MonoBehaviour {

	public float enemyMaxHealth;

	///public GameObject enemyDeathFX;
	public Slider enemyHealthBar;

	float currentHealth;

	// Use this for initialization
	void Start () {
		currentHealth = enemyMaxHealth;
		enemyHealthBar.maxValue = currentHealth;
		enemyHealthBar.value = currentHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addDamage(float damage){
		enemyHealthBar.gameObject.SetActive(true);
		currentHealth = currentHealth-damage;
		enemyHealthBar.value = currentHealth;

		if(currentHealth<=0) makeDead();
	}

	void makeDead(){
		Destroy(gameObject);
		///Instantiate(enemyDeathFX, transform.position, transform.rotation);
	}
}
