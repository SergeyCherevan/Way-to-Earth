using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOutOfMap : MonoBehaviour
{
    public GameObject eventHandler;

    void Update()
    {
        if (transform.position.x < MainCamera.MinX)
        {
            eventHandler.SendMessage("GameObjectDeletedByOutOfMap", gameObject);
            Destroy(gameObject);
        }
    }
}
