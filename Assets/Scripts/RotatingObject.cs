using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObject : MonoBehaviour
{
    public float angleVelocity;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, angleVelocity * Time.deltaTime));
    }
}
