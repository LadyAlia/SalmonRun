using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dyyniscript1 : MonoBehaviour {

    public float Speed;
    public string musicOne;
    // Update is called once per frame

    private void Start() {
        Fabric.EventManager.Instance.PostEvent(musicOne);
    }

    void Update () {

        transform.Translate(Vector3.right * Speed * Time.deltaTime);
    }
}
