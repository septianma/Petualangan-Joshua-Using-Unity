using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEND : MonoBehaviour {

	public int nextSceneLoad;

	void Start () {
		nextSceneLoad = SceneManager.GetActiveScene().buildIndex - 7;
	}

	public void LoadNextLevel(){
		SceneManager.LoadScene(nextSceneLoad);
		if(nextSceneLoad > PlayerPrefs.GetInt("levelAt")){
			PlayerPrefs.SetInt("levelAt", nextSceneLoad);
		}
	}
}
