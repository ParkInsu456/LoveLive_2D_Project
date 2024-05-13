using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InGameChangeCharacter : MonoBehaviour
{
    [SerializeField] private GameObject SelectCharacterMenu; // �̰ſ� �巡�׾ص��
    
    [SerializeField] public GameObject prevPlayer;
    [SerializeField] public GameObject nextPlayer;
    [SerializeField] private string tempName;
    private Vector3 tempPos;

    private void Awake()
    {
        SelectCharacterMenu = gameObject;
    }

    // ���� �÷��� �� ĳ���͸� �ٲ۴�.

    // �÷��̾ �� �����ո� �ٲ۴�. => ���籸���� �� �ٲ۴ٴ� ��...
    // ���� ĳ���� ���� �� ��ġ����, �̸������� temp�� �����ϰ� ����. �������� ������ ���� �����ϱ�.
    public void EXE()
    {
        GetPrevPlayerInfo();
        GetPrefab();
        Change();
    }

    void GetPrevPlayerInfo()
    {
        tempName = prevPlayer.GetComponent<PlayerInfo>().TxtplayerName.text;
        tempPos = prevPlayer.transform.position;
        
        Destroy(prevPlayer);
    }
    void GetPrefab()
    {
        nextPlayer = SelectCharacterMenu.GetComponent<SelectCharacterMenu>().SelectedPrefab; // �������� ������
        
    }

    void Change()
    {
        
        GameManager.Instance.InstantiatePlayer(nextPlayer, tempPos);
        GameManager.Instance.Player.GetComponent<PlayerInfo>().TxtplayerName.text = tempName; 
       // �����տ��� ����� ���� �� �ִ�...
       
        //GameManager.Instance.Player = nextPlayer;
        nextPlayer = null;
    }

    // ĳ���� ����â�� ��Ȱ�� �����ϴ�.

    

    



}

// �����ο� UI
// �䱸����
// ȭ�� �����ʿ� ���� �ʿ� �ִ� ����� ����� �����ݴϴ�.


// Users ���̾��� �̸��� ����ϴ� ���
// ������ ���̾� ��ü�� üũ, �� �̸��� ���
// �̰� ���� ������Ʈ?? �ؽ�Ʈ�� �Ʒ��� ������� ��������� �ϴ¹�. ī������� ī�� ������� ������ġ ����ȭ

// üũ�� ��ü�� �̸��� ����
// �迭�� ����
// Text�� �迭 ���̸�ŭ ��������
// Text�� �迭[i]�� ���




// ��ȭ �ý���
// �䱸����
// - Ʃ�Ϳ��� ������ ���� ��ȭ �ɱ� ��ư�� ����ϴ�.
//Ʃ�Ϳ��� �־����� �ٽ� ��ư�� ������ϴ�.
//- ��ư�� �����ٸ� ��ȭ�� ���۵˴ϴ�.

// npc��ü�� �����
// npc�� ������ �ʴ� ���� ������Ʈ�� �ִ�.
// �� ������ �÷��̾� collider�� trigger�ϸ� ��ȭ�ɱ� ��ưui�� �˾��Ѵ�
// ��ȭ�ɱ��ư�� ������ �ϴܿ� ��ȭâ�� ���. ui�� ǥ��, �۾��� ���� �����ʰ� ������ �ǳ��ֱ�. �ٸ�Ŭ������ string �����ϱ�
// 