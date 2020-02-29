using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class aboutScript : MonoBehaviour {

	public void triggerMenu(int trigger) {
		switch (trigger) {
		case(0) :
			SceneManager.LoadScene("about_menu");
			break;
		case(1) :
			Application.Quit();
			break;
		
		}
	}
}
