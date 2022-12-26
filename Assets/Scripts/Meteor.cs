using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float score;

    void Update()
    {
        transform.Translate(-transform.right * score * Time.deltaTime);
    }
}
