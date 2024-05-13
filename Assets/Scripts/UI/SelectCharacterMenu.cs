using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacterMenu : MonoBehaviour
{    
    [SerializeField] public GameObject SelectedPrefab;
    [SerializeField] private GameObject Prefab1;    // ���⿡ �������� �巡�׾ص������ ĳ���Ѵ�.
    [SerializeField] private GameObject Prefab2;
    
    public GameObject LoginPanel;
    private InGameChangeCharacter inGameChangeCharacter;

    private event Action OnBoolEvent;
    public bool IsInGame = false;
    [SerializeField] private GameObject button1;
    [SerializeField] private GameObject button2;
    [SerializeField] private GameObject buttonInGame1;
    [SerializeField] private GameObject buttonInGame2;



    private void Awake()
    {
        inGameChangeCharacter = GetComponent<InGameChangeCharacter>();
    }
    private void Start()
    {
        OnBoolEvent += ButtonSwap;
    }

    public void CallBoolEvent()
    {
        OnBoolEvent?.Invoke();
        Debug.Log("Invoked");
    }


    public void ButtonToLoadPrefab(GameObject Prefab)
    {
        SelectedPrefab = Prefab;
    }

    public void ButtonSelect1()
    {
        SelectedPrefab = Prefab1;
        Login.Instance.SelectedCharacter = SelectedPrefab;
        SwapToLoginPanel();
    }
    public void ButtonSelect2()
    {
        SelectedPrefab = Prefab2;
        Login.Instance.SelectedCharacter = SelectedPrefab;
        SwapToLoginPanel();
    }

    public void SwapToLoginPanel()
    {
        gameObject.SetActive(false);
        LoginPanel.SetActive(true);        
    }


    // �׶������ ��ư���� ĳ���ͼ���â�� �����ϸ� 
    // ���� ��ư�� ��Ȱ��ȭ ��Ű�� �Ȱ��� ���� ��ư�� ��Ÿ����. 
    void ButtonSwap()
    {
        
        inGameChangeCharacter.prevPlayer = GameManager.Instance.Player;
        button1.SetActive(false);
        button2.SetActive(false);
        buttonInGame1.SetActive(true);
        buttonInGame2.SetActive(true);
    }
    void ButtonSwapElse()
    {
        buttonInGame1.SetActive(false);
        buttonInGame2.SetActive(false);
        button1.SetActive(true);
        button2.SetActive(true);
    }



    // ������ �Լ��� �ΰ��� �������� �α���ȭ������ ���� �ʰ� ����ȭ������ ���� �����.
    public void ButtonInGameSelect1()
    {
        SelectedPrefab = Prefab1;
        inGameChangeCharacter.nextPlayer = SelectedPrefab;
        inGameChangeCharacter.EXE();
        ButtonSwapElse();
        gameObject.SetActive(false);
    }
    public void ButtonInGameSelect2()
    {
        SelectedPrefab = Prefab2;
        inGameChangeCharacter.nextPlayer = SelectedPrefab;
        inGameChangeCharacter.EXE();
        ButtonSwapElse();
        gameObject.SetActive(false);
    }



    //�Ұ��� Ʈ�簡 �Ǹ� �̺�Ʈ ��������.
    // �̺�Ʈ�� SetActive�� ü���Ѵ�.

}
