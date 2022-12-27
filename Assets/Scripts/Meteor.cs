using UnityEngine;
using UnityEngine.SceneManagement;

public class Meteor : MonoBehaviour
{
    public Rigidbody2D rigidBody;

    public GameObject bangPrefab;

    public float score;

    void Update()
    {
        rigidBody.velocity = transform.right * score;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject bang = Instantiate(bangPrefab, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);

        if (collision.TryGetComponent<Rocket>(out _))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
