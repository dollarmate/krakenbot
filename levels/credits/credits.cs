using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class credits : MonoBehaviour {

	public void triggerMenu(int trigger) {
		switch (trigger) {
		case(0) :
			SceneManager.LoadScene("menuScene");
			break;
		case(1) :
			Application.Quit();
			break;
		
		}
	}
}
