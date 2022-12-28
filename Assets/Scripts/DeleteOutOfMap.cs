using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOutOfMap : MonoBehaviour
{
    public GameObject eventHandler;

    void Update()
    {
        if (transform.position.x < MainCamera.MinX || transform.position.x > MainCamera.MaxX ||
            transform.position.y < MainCamera.MinY || transform.position.y > MainCamera.MaxY)
        {
            if (eventHandler != null)
            {
                eventHandler.SendMessage("GameObjectDeletedByOutOfMap", gameObject);
            }
            Destroy(gameObject);
        }
    }
}
