using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public static Login Instance;
    private GameObject loginPanel;
       
    [SerializeField] private PlayerInfo playerInfo; // �ν����Ϳ��� ĳ��
    [SerializeField] private TMP_InputField nameTxt;  // ���⿡ InputField���� �Է��� txt�� �ν����Ϳ� ĳ���ϱ�
    [SerializeField] private Button enterButton;
    [SerializeField] private Image enterButtonImage;

    [SerializeField] private GameObject SelectCharacterMenu;
    [SerializeField] public GameObject SelectedCharacter;
    [SerializeField] private Image sourceImage; // ���⿡ �巡�׾ص���ؾ���.



    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        loginPanel = gameObject;
    }

    private void OnEnable()
    {
        LoadImage();
    }

    void Start()
    {
        Time.timeScale = 0f;
    }

    private void Update()
    {
        LimitedNameLength();
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
        // ĳ���͸� �����Ѵ�
        GameManager.Instance.InstantiatePlayer(SelectedCharacter);
        Time.timeScale = 1f;
    }


    // �Է��� �̸��� 2~10���� ���̰� �ƴ϶�� ��ư�� ��Ȱ��ȭ��Ű�� ���� ��Ӱ��ϴ� ���
    void LimitedNameLength()
    {
        string curInput = nameTxt.text;       
        if(curInput.Length < 2 || curInput.Length > 10)
        {
            //��ư ��Ȱ��ȭ
            enterButton.enabled = false;
            enterButtonImage.color = Color.gray;
        }
        else
        {
             enterButton.enabled = true;
            enterButtonImage.color = Color.white;
        }
    }

    // ��ư�� ������ Login ui�� ���� ĳ���ͼ���Ʈ�� ����.
    public void SwapToSelectCharacterMenu()
    {
        gameObject.SetActive(false);
        SelectCharacterMenu.SetActive(true);
    }

    // ���õ� �������� ��������Ʈ�� �̹����� ����
    void LoadImage()
    {
        Sprite temp = SelectedCharacter.GetComponentInChildren<SpriteRenderer>().sprite;
        sourceImage.sprite = temp;
    }

    
}


