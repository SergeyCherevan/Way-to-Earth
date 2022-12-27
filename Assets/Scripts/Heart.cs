using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public GameObject hpLine;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Rocket"))
        {
            hpLine.GetComponent<HP_Line>().ChangeHP(1);
        }
        Destroy(gameObject);
    }
}
