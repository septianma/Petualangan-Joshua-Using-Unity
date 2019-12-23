using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public float fullHealth;
	//public GameObject deathFX;
	float currentHealth;

	Player playerControl;

	public AudioClip playerDeathSound;

	public RestartGame theGameManager;

	//Player Heart Bar
	public Slider heartBar;
	public Image damageScreen;
	public GameObject gameOverScreen;

	bool damaged = false;
	Color damagedColour = new Color(0f,0f,0f,0.5f);
	float smoothColour = 5f;

	// Use this for initialization
	void Start () {
		currentHealth = fullHealth;
		playerControl = GetComponent<Player>();

		//Heart Bar
		heartBar.maxValue=fullHealth;
		heartBar.value=fullHealth;

		damaged = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(damaged){
			damageScreen.color = damagedColour;
		}
		else{
			damageScreen.color = Color.Lerp(damageScreen.color, Color.clear, smoothColour*Time.deltaTime);
		}
		damaged = false;
	}

	public void addDamage(float damage){
		if(damage<=0) return;
		currentHealth = currentHealth - damage;

		heartBar.value = currentHealth;
		damaged = true;

		if(currentHealth<=0){
			makeDead();
		}
	}

	public void addHealth(float healthAmount){
		currentHealth += healthAmount;
		if(currentHealth > fullHealth) currentHealth = fullHealth;
		heartBar.value = currentHealth;
	}

	public void makeDead(){
		//Instantiate(deathFX, transform.position, transform.rotation);
		Destroy(gameObject);
		AudioSource.PlayClipAtPoint(playerDeathSound, transform.position);
		damageScreen.color = damagedColour;

		Animator gameOverAnimator = gameOverScreen.GetComponent<Animator>();
		gameOverAnimator.SetTrigger("gameOver");
		theGameManager.restartTheGame();
	}
}
