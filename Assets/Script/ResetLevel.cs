using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLevel : MonoBehaviour {

	// Use this for initialization
	void Update()
    {
		
    }

	public void resetLevel(){
		PlayerPrefs.DeleteAll();
	}
}
