using UnityEngine;

public class BulletSooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float timeToSpan;
    public float timeOfShooting;

    float timerToSpan;
    float timerOfShooting;

    public GameObject includedObject;

    private void Start()
    {
        timerOfShooting = timeOfShooting;
    }

    void Update()
    {
        UpdateTimerOfShooting();
        KeyboardControl();
    }

    void UpdateTimerOfShooting()
    {
        if (timerOfShooting > 0)
        {
            timerOfShooting -= Time.deltaTime;
        }
        else
        {
            Destroy(this);
        }
    }

    void KeyboardControl()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (timerToSpan > 0)
            {
                timerToSpan -= Time.deltaTime;
            }
            else
            {
                GameObject miniRocket = Instantiate(
                    bulletPrefab,
                    transform.position + transform.right * transform.lossyScale.x,
                    Quaternion.identity
                );

                timerToSpan = timeToSpan;
            }
        }
        else
        {
            timerToSpan = 0;
        }
    }
}
