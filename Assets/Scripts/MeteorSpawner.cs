using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab;
    public float timeToSpan;


    private float timer;
    float deflectionAngle { get => Mathf.Atan2(MainCamera.MaxY, 2 * MainCamera.MaxX) / Mathf.PI * 180; }

    void Start()
    {

    }

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

            GameObject meteor = Instantiate(meteorPrefab, transform.position + Vector3.up * randY, Quaternion.identity);
            meteor.transform.Rotate(0, 0, 180 + randAngle);

            timer = timeToSpan;
        }
    }
}
