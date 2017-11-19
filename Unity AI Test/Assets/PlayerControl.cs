using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float maxSpeed;
    Rigidbody playerRidgidbody;

    // Use this for initialization
    void Start()
    {

        playerRidgidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");

        //playerRidgidbody.velocity = new Vector3(move * maxSpeed, playerRidgidbody.velocity.y, playerRidgidbody.velocity.x);
    }
}
