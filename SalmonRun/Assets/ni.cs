using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ni : MonoBehaviour {
    public string stopAudio;

    // Use this for initialization
    void Start () {
        Fabric.EventManager.Instance.PostEvent(stopAudio);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
