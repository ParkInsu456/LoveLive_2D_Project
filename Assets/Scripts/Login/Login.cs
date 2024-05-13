using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    private GameObject loginPanel;
    [SerializeField] private PlayerInfo playerInfo; // 인스펙터에서 캐싱
    [SerializeField] private TextMeshProUGUI nameTxt;  // 여기에 InputField에서 입력한 txt를 인스펙터에 캐싱하기
    

    private void Awake()
    {
        loginPanel = gameObject;
    }

    void Start()
    {
        Time.timeScale = 0f;
    }

    private void InputName()
    {
        PlayerInfo.Name = nameTxt.text;
        playerInfo.NameUpdate();
    }


    public void ClickEnterButton()
    {
        InputName();
        loginPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}


