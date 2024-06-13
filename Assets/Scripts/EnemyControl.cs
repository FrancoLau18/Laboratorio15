using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D _compRigidBody2D;
    public float speedY;
    public EnemyContainerControl  enemyContainer;
    private void Awake()
    {
        _compRigidBody2D = GetComponent<Rigidbody2D>();
    }  
    private void FixedUpdate()
    {
        _compRigidBody2D.velocity = new Vector2(0, -speedY);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
            enemyContainer.IncreasePoints(10);
        }
    }
    public void SetEnemyContainerControl(EnemyContainerControl enemyContainer)
    {
        this.enemyContainer = enemyContainer;
    }
}
