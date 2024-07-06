using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text CounterText;
    public int totalBalls = 0;
    public static GameManager instance;
    void Awake()
    {
        instance = this;
    }
    public void AddCount()
    {
        totalBalls += 1;
        FormatNumber(totalBalls);
    }
    void FormatNumber(double number)
    {
        string formattedNumber = "";

        if (Math.Abs(number) >= 1.0e9)
        {
            formattedNumber = (number / 1.0e9).ToString("F2") + "B";
        }
        else if (Math.Abs(number) >= 1.0e6)
        {
            formattedNumber = (number / 1.0e6).ToString("F2") + "M";
        }
        else if (Math.Abs(number) >= 1.0e3)
        {
            formattedNumber = (number / 1.0e3).ToString("F2") + "K";
        }
        else
        {
            formattedNumber = number.ToString("F2");
        }

        CounterText.text = formattedNumber;
    }
}
