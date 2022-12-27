using UnityEngine;

public class Rocket : MonoBehaviour
{
    public GameObject fire;
    public Rigidbody2D rigidBody;

    public bool isMoving;
    public float vericalSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        Move();        
    }

    void Move()
    {
        isMoving = false;
        rigidBody.velocity = Vector3.zero;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rigidBody.velocity = transform.up * vericalSpeed;

            isMoving = true;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rigidBody.velocity = -transform.up * vericalSpeed;

            isMoving = true;
        }

        if (transform.position.y > 5)
        {
            transform.position = new Vector2(transform.position.x, 5);
        }
        if (transform.position.y < -5)
        {
            transform.position = new Vector2(transform.position.x, -5);
        }

        fire.SetActive(isMoving);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Meteor>(out _))
        {
            HP_Line.instanse.ChangeHP(-1);
        }
    }
}
