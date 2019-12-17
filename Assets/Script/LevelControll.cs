using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelControll : MonoBehaviour {

	public Button tombolLevel2, tombolLevel3, tombolLevel4, tombolLevel5, tombolLevel6;
	int levelTerlewati;

	// Use this for initialization
	void Start () {
		levelTerlewati = PlayerPrefs.GetInt ("LevelTerlewati");
		tombolLevel2.interactable = false;
		tombolLevel3.interactable = false;

		switch(levelTerlewati){
			case 1:
				tombolLevel2.interactable = true;
				break;
			case 2:
				tombolLevel2.interactable = true;
				tombolLevel3.interactable = true;
				break;
			case 3:
				tombolLevel2.interactable = true;
				tombolLevel3.interactable = true;
				tombolLevel4.interactable = true;
				break;
			case 4:
				tombolLevel2.interactable = true;
				tombolLevel3.interactable = true;
				tombolLevel4.interactable = true;
				tombolLevel5.interactable = true;
				break;
			case 5:
				tombolLevel2.interactable = true;
				tombolLevel3.interactable = true;
				tombolLevel4.interactable = true;
				tombolLevel5.interactable = true;
				tombolLevel6.interactable = true;
				break;
		}
	}

	public void levelToLoad (int level){
		SceneManager.LoadScene(level);
	}
	
	public void resetPlayerPrefs(){
		tombolLevel2.interactable = false;
		tombolLevel3.interactable = false;
		tombolLevel4.interactable = false;
		tombolLevel5.interactable = false;
		tombolLevel6.interactable = false;
		PlayerPrefs.DeleteAll();
	}
}
