using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public float timeToSpan;

    float timer;
    float deflectionAngle { get => Mathf.Atan2(MainCamera.MaxY, 2 * MainCamera.MaxX) / Mathf.PI * 180; }

    public GameObject includedObject;

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            float randY = Random.Range(MainCamera.MinY, MainCamera.MaxY);
            float randAngle = Random.Range(-deflectionAngle, deflectionAngle);

            GameObject go = Instantiate(objectPrefab, transform.position + Vector3.up * randY, Quaternion.identity);
            go.transform.Rotate(0, 0, randAngle);

            if (go.GetComponent<DeleteOutOfMap>() is DeleteOutOfMap deleteOutOfMap)
            {
                deleteOutOfMap.eventHandler = includedObject;
            }

            if (go.GetComponent<Heart>() is Heart heart)
            {
                heart.hpLine = includedObject;
            }

            timer = timeToSpan;
        }
    }
}
