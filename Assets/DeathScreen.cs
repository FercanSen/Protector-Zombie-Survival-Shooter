using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour {
	
	void Start()
	{
		
		Cursor.visible = true;
	}
	
	public void PlayGame()
	{
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
		SceneManager.LoadScene("Main Scene");
	}
	public void Quit()
	{
		SceneManager.LoadScene("Menu");
	}
}
