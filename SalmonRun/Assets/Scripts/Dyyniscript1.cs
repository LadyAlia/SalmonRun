﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dyyniscript1 : MonoBehaviour {

    public float Speed;

    // Update is called once per frame

    void Update () {

        transform.Translate(Vector3.right * Speed * Time.deltaTime);
    }
}
