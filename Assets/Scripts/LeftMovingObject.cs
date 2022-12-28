using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMovingObject : MonoBehaviour
{
    public Rigidbody2D rigidBody;

    public float score;

    void Start()
    {
        rigidBody.velocity = -transform.right * score;
    }
}
