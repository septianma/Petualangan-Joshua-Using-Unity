using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class failThrough : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("TargetTemabak"), LayerMask.NameToLayer("TargetTembak"));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
