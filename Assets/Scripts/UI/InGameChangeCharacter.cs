using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InGameChangeCharacter : MonoBehaviour
{
    [SerializeField] private GameObject SelectCharacterMenu; // 이거에 드래그앤드롭
    
    [SerializeField] public GameObject prevPlayer;
    [SerializeField] public GameObject nextPlayer;
    [SerializeField] private string strTempName;
    private Vector3 tempPos;

    private void Awake()
    {
        SelectCharacterMenu = gameObject;
    }

    // 게임 플레이 중 캐릭터를 바꾼다.

    // 기존 캐릭터 삭제 전 위치정보, 이름정보를 temp에 저장하고 삭제. 이정보를 가지고 새로 생성하기.
    public void EXE()
    {
        GetPrevPlayerInfo();
        GetPrefab();
        Change();
    }

    void GetPrevPlayerInfo()
    {
        prevPlayer = GameManager.Instance.Player;
        strTempName = prevPlayer.GetComponent<PlayerInfo>().Name;
        tempPos = prevPlayer.transform.position;
        
        Destroy(prevPlayer);
    }
    void GetPrefab()
    {
        nextPlayer = SelectCharacterMenu.GetComponent<SelectCharacterMenu>().SelectedPrefab; // 프리팹을 가져옴 // 이름 다시짓기가 필요하다. 플레이어와 프리팹 병용으로 혼란이 옴        
    }

    void Change()
    {
        
        GameManager.Instance.InstantiatePlayer(nextPlayer, tempPos);
        GameManager.Instance.Player.GetComponent<PlayerInfo>().Name = strTempName;
        GameManager.Instance.Player.GetComponent<PlayerInfo>().NameUpdate();
        // 프리팹에도 기록이 남을 수 있다...

        //GameManager.Instance.Player = nextPlayer;
        nextPlayer = null;
    }
    // 캐릭터 선택창은 재활용 가능하다.
}


