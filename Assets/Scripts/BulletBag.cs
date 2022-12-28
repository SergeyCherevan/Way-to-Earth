using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBag : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float timeToSpan;
    public float timeOfShooting;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Rocket"))
        {
            BulletSooting bulletSooting = collision.gameObject.AddComponent<BulletSooting>();
            bulletSooting.bulletPrefab = this.bulletPrefab;
            bulletSooting.timeToSpan = this.timeToSpan;
            bulletSooting.timeOfShooting = this.timeOfShooting;
        }
        Destroy(gameObject);
    }
}
