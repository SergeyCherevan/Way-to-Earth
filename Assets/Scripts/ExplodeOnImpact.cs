using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeOnImpact : MonoBehaviour
{
    public GameObject bangPrefab;

    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject bang = Instantiate(bangPrefab, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
