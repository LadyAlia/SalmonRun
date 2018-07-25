using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunMove : MonoBehaviour {

    public float Speed;
    Rigidbody2D PlayerRig;

	// Use this for initialization
	void Start ()
    {
        PlayerRig = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.right * Speed * Time.deltaTime);
    }
}
