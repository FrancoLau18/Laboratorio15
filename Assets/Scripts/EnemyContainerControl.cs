using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContainerControl : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float timeCreateEnemy = 2;
    private float timeCurrentCreateEnemy = 0;
    public float minX ;
    public float maxX;
    public float yPosition ;
    public GameManagerControl gameManager;
    void CreateEnemy()
    {
        float xPosition = Random.Range(minX, maxX);
        Vector2 positionToCreate = new Vector2(xPosition, yPosition);
        GameObject enemy = Instantiate(enemyPrefab, positionToCreate , transform.rotation);
        enemy.GetComponent<Enemy>().SetEnemyContainerControl(this);

    }
    void Update()
    {
        timeCurrentCreateEnemy = timeCurrentCreateEnemy + Time.deltaTime;
        if (timeCurrentCreateEnemy >= timeCreateEnemy)
        {
            timeCurrentCreateEnemy = 0;
            CreateEnemy();
        }
    }
    public void IncreasePoints(int pointsToAdd)
    {
        gameManager.IncreasePoints(pointsToAdd );
    }
}
