using UnityEngine;

public class RocketFiring : MonoBehaviour
{
    public GameObject miniRocketPrefab;
    public float timeToSpan;

    float timer;

    public GameObject includedObject;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                GameObject miniRocket = Instantiate(
                    miniRocketPrefab,
                    transform.position + transform.right * transform.lossyScale.x,
                    Quaternion.identity
                );

                timer = timeToSpan;
            }
        }
        else
        {
            timer = 0;
        }
    }
}
