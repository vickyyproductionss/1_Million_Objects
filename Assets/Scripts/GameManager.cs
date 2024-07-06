using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text CounterText;
    double totalBalls = 0;
    public static GameManager instance;
    void Awake()
    {
        instance = this;
    }
    public void AddCount()
    {
        totalBalls += 1;
        CounterText.text = totalBalls.ToString();
    }
}
