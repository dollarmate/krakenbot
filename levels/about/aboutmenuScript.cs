using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class aboutmenuScript : MonoBehaviour {

	public void triggerMenu(int trigger) {
		switch (trigger) {
		case(0) :
			SceneManager.LoadScene("menuScene");
			break;
		case(1) :
			Application.Quit();
			break;
		case(2) :
			SceneManager.LoadScene("waterfront");
			break;
		case(3) :
			SceneManager.LoadScene("fort");
			break;
		case(4) :
			SceneManager.LoadScene("temple");
			break;
		case(5) :
			SceneManager.LoadScene("cat");
			break;
		case(6) :
			SceneManager.LoadScene("museum");
			break;
		case(7) :
			SceneManager.LoadScene("textile");
			break;
		case(8) :
			SceneManager.LoadScene("mosque");
			break;
		case(9) :
			SceneManager.LoadScene("bridge");
			break;
		}
	}
}
