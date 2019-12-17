using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame(){
		SceneManager.LoadScene("PilihLevel");
	}
	public void ExitGame(){
		Application.Quit();
	}
	public void BackToMenu(){
		SceneManager.LoadScene("Menu");
	}
	public void SettingButton(){
		SceneManager.LoadScene("Setting");
	}


	public void Keluar(){
		Application.Quit();
	}
}
