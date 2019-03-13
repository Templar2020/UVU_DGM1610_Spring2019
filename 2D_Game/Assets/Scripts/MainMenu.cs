using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	//Indexed level to load
	public int levelToLoad;
	// This function loads the indexed level stored in the levelToLoad variable after button is pressed
	public void LoadLevel(){
		SceneManager.LoadScene(levelToLoad);
	}
	// This function quits the game after the button is presssed
	public void LevelExit(){
		Application.Quit();
	}
}
