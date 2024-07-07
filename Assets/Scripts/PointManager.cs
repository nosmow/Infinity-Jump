using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PointManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textScore;
    int score = 0;

    public void AddPoint()
    {
        score++;
        textScore.text = "Score: " + score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            AddPoint();
        }
    }
}
