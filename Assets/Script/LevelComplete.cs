using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

	public int nextSceneLoad;

	void Start () {
		nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
	}

	public void LoadNextLevel(){
		SceneManager.LoadScene(nextSceneLoad);
		if(nextSceneLoad > PlayerPrefs.GetInt("levelAt")){
			PlayerPrefs.SetInt("levelAt", nextSceneLoad);
		}
	}
}
