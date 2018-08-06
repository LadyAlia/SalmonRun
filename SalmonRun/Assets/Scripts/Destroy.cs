using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour {
    public string stopAudio;

    private void OnTriggerEnter2D(Collider2D other) {
        Destroy(other.gameObject);
        Fabric.EventManager.Instance.PostEvent(stopAudio);
        SceneManager.LoadScene("GameIsOver");
        
    }
}
