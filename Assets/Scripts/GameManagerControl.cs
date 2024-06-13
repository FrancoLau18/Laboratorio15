using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerControl : MonoBehaviour
{
    public string sceneToLoad;
    public Text texPoints;
    public int points;

    private void Start()
    {
        IncreasePoints(0);
    }
    public void IncreasePoints(int pointsToAdd)
    {
        points = points + pointsToAdd;
        texPoints.text = "Puntos: " + points;
    }
}