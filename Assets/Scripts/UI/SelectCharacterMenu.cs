using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacterMenu : MonoBehaviour
{    
    [SerializeField] public GameObject SelectedPrefab;
    [SerializeField] private GameObject Prefab1;    // 여기에 프리팹을 드래그앤드랍으로 캐싱한다.
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


    // 그라운드바의 버튼으로 캐릭터선택창에 진입하면 
    // 기존 버튼을 비활성화 시키고 똑같이 생긴 버튼이 나타난다. 
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



    // 내부의 함수를 인게임 전용으로 로그인화면으로 가지 않고 게임화면으로 가게 만든다.
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



    //불값이 트루가 되면 이벤트 실행힌다.
    // 이벤트엔 SetActive를 체인한다.

}
