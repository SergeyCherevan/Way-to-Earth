using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingForwardObject : MonoBehaviour
{
    public Rigidbody2D rigidBody;

    public float score;

    void Update()
    {
        rigidBody.velocity = -transform.right * score;
    }
}
