using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    public GameObject effect;
    public float xPos;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x < xPos)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            collision.GetComponent<PlayerMove>().health -= damage;
            Debug.Log(collision.GetComponent<PlayerMove>().health);
            Destroy(gameObject);
        }
    }
}
