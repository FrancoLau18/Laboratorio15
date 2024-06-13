using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D _compRigidbody2D;
    public float speed;
    public int yDirection;
    public GameObject Blast;
    private void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(0,speed * yDirection);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Instantiate(Blast,transform.position,transform.rotation);
        }
    }

}
