using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RunMove : MonoBehaviour
{
    private float TouchStart, JumpTime;
    public float Speed;
    public float JumpSpeed;
    Rigidbody2D PlayerRig;
    public int jumps = 0; 

    // Use this for initialization
    void Start()
    {
        PlayerRig = GetComponent<Rigidbody2D>();
        JumpTime = 0.8f;
    }

    // Update is called once per frame
    void Update() {
        transform.Translate(Vector3.right * Speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.J) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)) {
            // lähtöaika talteen
            TouchStart = Time.time;
        }

        if (Input.GetKeyUp(KeyCode.J) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)) {
            if (Time.time - TouchStart < JumpTime && jumps < 2) // jos nykyinen aika - lähtöaika riittävän pieni
            {
                //transform.Translate(Vector3.up * JumpSpeed * Time.deltaTime);
                PlayerRig.AddForce(Vector2.up * JumpSpeed);
                jumps++;
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D col) 
    {

        if (col.gameObject.tag == "Ground") {
            jumps = 0;
        }
    }
        
}


