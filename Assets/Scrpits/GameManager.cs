using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text points;
    int score;


    // Update is called once per frame
    void Update()
    {

        points.text = "Points: " + score;
    }

    void Score(int points)
    {
        score += points;
    }
}
