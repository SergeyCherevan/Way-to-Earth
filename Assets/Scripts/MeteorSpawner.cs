using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab;
    public float timeToSpan;

    private float timer;

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            float rand = Random.Range(MainCamera.MinY, MainCamera.MaxY);

            GameObject meteor = Instantiate(meteorPrefab, transform.position + Vector3.up * rand, new Quaternion(0, 180, 0, 0));

            timer = timeToSpan;
        }
    }
}
