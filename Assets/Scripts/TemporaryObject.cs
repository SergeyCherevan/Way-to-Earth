using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemporaryObject : MonoBehaviour
{
    public float timeToDelete;


    private float timer;

    void Start()
    {
        timer = timeToDelete;
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
