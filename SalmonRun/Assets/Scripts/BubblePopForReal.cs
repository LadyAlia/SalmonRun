using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblePopForReal : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D player) {

        player.GetComponent<PlayerHealth>().curHealth += 1;
        Destroy(gameObject);
    }
}
