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
    [SerializeField] private PlayerInfo playerInfo; // �ν����Ϳ��� ĳ��
    [SerializeField] private TextMeshProUGUI nameTxt;  // ���⿡ InputField���� �Է��� txt�� �ν����Ϳ� ĳ���ϱ�
    

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


