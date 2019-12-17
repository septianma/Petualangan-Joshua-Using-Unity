using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour {
	public GameObject Player;
	public float jarak;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = new Vector3 (Player.transform.localPosition.x+(Player.transform.localScale.x*jarak),0,-10f);
		transform.localPosition = Vector3.Slerp (transform.localPosition, pos, 0.05f);
	}
}
