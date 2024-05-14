using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InGameChangeCharacter : MonoBehaviour
{
    [SerializeField] private GameObject SelectCharacterMenu; // �̰ſ� �巡�׾ص��
    
    [SerializeField] public GameObject prevPlayer;
    [SerializeField] public GameObject nextPlayer;
    [SerializeField] private string strTempName;
    private Vector3 tempPos;

    private void Awake()
    {
        SelectCharacterMenu = gameObject;
    }

    // ���� �÷��� �� ĳ���͸� �ٲ۴�.

    // ���� ĳ���� ���� �� ��ġ����, �̸������� temp�� �����ϰ� ����. �������� ������ ���� �����ϱ�.
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
        nextPlayer = SelectCharacterMenu.GetComponent<SelectCharacterMenu>().SelectedPrefab; // �������� ������ // �̸� �ٽ����Ⱑ �ʿ��ϴ�. �÷��̾�� ������ �������� ȥ���� ��        
    }

    void Change()
    {
        
        GameManager.Instance.InstantiatePlayer(nextPlayer, tempPos);
        GameManager.Instance.Player.GetComponent<PlayerInfo>().Name = strTempName;
        GameManager.Instance.Player.GetComponent<PlayerInfo>().NameUpdate();
        // �����տ��� ����� ���� �� �ִ�...

        //GameManager.Instance.Player = nextPlayer;
        nextPlayer = null;
    }
    // ĳ���� ����â�� ��Ȱ�� �����ϴ�.
}


