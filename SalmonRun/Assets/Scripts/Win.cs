using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D player) {
        Time.timeScale = 0.5f;
        Invoke("VictoryScreen", 0.75f);
    }

    void VictoryScreen() {
        Time.timeScale = 1;
        SceneManager.LoadScene("GameWin");
    }
}
