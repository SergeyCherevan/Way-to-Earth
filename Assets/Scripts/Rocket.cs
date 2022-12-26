using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public GameObject fire;

    public bool isMoving;
    public float vericalSpeed;

    void Start()
    {
        isMoving = false;
    }

    void Update()
    {
        isMoving = false;

        if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(transform.up * vericalSpeed * Time.deltaTime);
            if (transform.position.y > 5)
            {
                transform.position = new Vector2(transform.position.x, 5);
            }

            isMoving = true;
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-transform.up * vericalSpeed * Time.deltaTime);
            if (transform.position.y < -5)
            {
                transform.position = new Vector2(transform.position.x, -5);
            }

            isMoving = true;
        }

        fire.SetActive(isMoving);
    }
}
