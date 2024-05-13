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
       
    [SerializeField] private PlayerInfo playerInfo; // 인스펙터에서 캐싱
    [SerializeField] private TMP_InputField nameTxt;  // 여기에 InputField에서 입력한 txt를 인스펙터에 캐싱하기
    [SerializeField] private Button enterButton;
    [SerializeField] private Image enterButtonImage;

    [SerializeField] private GameObject SelectCharacterMenu;
    [SerializeField] public GameObject SelectedCharacter;
    [SerializeField] private Image sourceImage; // 여기에 드래그앤드롭해야함.



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
        // 캐릭터를 생성한다
        GameManager.Instance.InstantiatePlayer(SelectedCharacter);
        Time.timeScale = 1f;
    }


    // 입력한 이름이 2~10글자 사이가 아니라면 버튼을 비활성화시키고 색을 어둡게하는 기능
    void LimitedNameLength()
    {
        string curInput = nameTxt.text;       
        if(curInput.Length < 2 || curInput.Length > 10)
        {
            //버튼 비활성화
            enterButton.enabled = false;
            enterButtonImage.color = Color.gray;
        }
        else
        {
             enterButton.enabled = true;
            enterButtonImage.color = Color.white;
        }
    }

    // 버튼을 누르면 Login ui를 끄고 캐릭터셀렉트를 띄운다.
    public void SwapToSelectCharacterMenu()
    {
        gameObject.SetActive(false);
        SelectCharacterMenu.SetActive(true);
    }

    // 선택된 프리팹의 스프라이트를 이미지로 띄운다
    void LoadImage()
    {
        Sprite temp = SelectedCharacter.GetComponentInChildren<SpriteRenderer>().sprite;
        sourceImage.sprite = temp;
    }

    
}


