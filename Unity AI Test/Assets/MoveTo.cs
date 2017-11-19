using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    public float speed;
    public Transform goal;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = goal.position - this.transform.position;

        if (direction.magnitude > 1)
            this.transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}