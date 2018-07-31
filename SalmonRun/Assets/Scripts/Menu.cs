using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {
    public Canvas MenuCanvas;
    public Canvas CreditsCanvas;
  

    // Use this for initialization
    void Start ()
    {
        MenuCanvas = GameObject.Find("MenuCanvas").GetComponent<Canvas>();
        CreditsCanvas = GameObject.Find("CreditsCanvas").GetComponent<Canvas>();

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void PlayGame()
    {
        SceneManager.LoadScene("TheGame");
    }

    public void ToCredits()
    {
        MenuCanvas.enabled = false;
        CreditsCanvas.enabled = true;
    }

    public void ToMenu()
    {
        MenuCanvas.enabled = true;
        CreditsCanvas.enabled = false;
    }

    public void QuitTheGame()
    {
        Application.Quit();
    }
}
