﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbloPop : MonoBehaviour {

	void Update () {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D player) {

        player.GetComponent<PlayerHealth>().curHealth += 1;
        Destroy(gameObject);
    }
}