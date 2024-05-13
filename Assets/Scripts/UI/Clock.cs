using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI ClockTxt;
    DateTime currentTime;
    private void Start()
    {
        currentTime = DateTime.Now;
    }

    private void Update()
    {
        ClockTxt.text = currentTime.ToString("HH:mm");
    }
}
