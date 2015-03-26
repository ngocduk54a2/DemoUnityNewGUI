using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {
	public GameObject resume;
	public GameObject back;
	public bool isPause = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void clickPause() {
		if (!isPause) {
			isPause = true;
			resume.SetActive(true);
			back.SetActive(true);
		}
	}

	public void clickResume() {
		if (isPause) {
			isPause = false;
			resume.SetActive(false);
			back.SetActive(false);
		}
	}

	public void clickBack() {
		Application.LoadLevel ("Menu");
	}
}
