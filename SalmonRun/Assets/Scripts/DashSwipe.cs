using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashSwipe : MonoBehaviour {

    private Vector2 startTouchPosition, endTouchPosition;
    private Rigidbody2D rb;
    public float DashForce = 700f;
    private bool DashForward = false;

    // Use this for initialization
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        SwipeCheck();
    }

    private void FixedUpdate()
    {
        DashIfAllowed();
    }

    private void SwipeCheck()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            startTouchPosition = Input.GetTouch(0).position;

        if (Input.touchCount > 1 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;
            if (endTouchPosition.x > startTouchPosition.x && rb.velocity.x == 0)
                DashForward = true;
        }
    }

    private void DashIfAllowed()
    {
        if (DashForward)
        {
            rb.AddForce(Vector2.right * DashForce);
            DashForward = false;
        }
    }

}


