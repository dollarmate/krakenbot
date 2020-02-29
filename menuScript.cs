using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class menuScript : MonoBehaviour {

	public void triggerMenu(int trigger) {
		switch (trigger) {
		case(0) :
			SceneManager.LoadScene("gameScene");
			break;
		case(1) :
			Application.Quit();
			break;
		case(2) :
			SceneManager.LoadScene("level3");
			break;
		case(3) :
			SceneManager.LoadScene("level1");
			break;
		case(4) :
			SceneManager.LoadScene("about_menu");
			break;
		case(5) :
			SceneManager.LoadScene("credits");
			break;
		}
	}
}
