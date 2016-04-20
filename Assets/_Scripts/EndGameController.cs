using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndGameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void StartButtonClick()
    {
        SceneManager.LoadScene("main");
    }

    public void BacktoMenuButtonClick()
    {
        SceneManager.LoadScene("Menu");
    }
}
