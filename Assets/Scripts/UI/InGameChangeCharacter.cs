using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InGameChangeCharacter : MonoBehaviour
{
    [SerializeField] private GameObject SelectCharacterMenu; // 이거에 드래그앤드롭
    
    [SerializeField] public GameObject prevPlayer;
    [SerializeField] public GameObject nextPlayer;
    [SerializeField] private string tempName;
    private Vector3 tempPos;

    private void Awake()
    {
        SelectCharacterMenu = gameObject;
    }

    // 게임 플레이 중 캐릭터를 바꾼다.

    // 플레이어에 들어간 프리팹만 바꾼다. => 현재구조상 다 바꾼다는 뜻...
    // 기존 캐릭터 삭제 전 위치정보, 이름정보를 temp에 저장하고 삭제. 이정보를 가지고 새로 생성하기.
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
        nextPlayer = SelectCharacterMenu.GetComponent<SelectCharacterMenu>().SelectedPrefab; // 프리팹을 가져옴
        
    }

    void Change()
    {
        
        GameManager.Instance.InstantiatePlayer(nextPlayer, tempPos);
        GameManager.Instance.Player.GetComponent<PlayerInfo>().TxtplayerName.text = tempName; 
       // 프리팹에도 기록이 남을 수 있다...
       
        //GameManager.Instance.Player = nextPlayer;
        nextPlayer = null;
    }

    // 캐릭터 선택창은 재활용 가능하다.

    

    



}

// 참석인원 UI
// 요구사항
// 화면 오른쪽에 현재 맵에 있는 사람의 목록을 보여줍니다.


// Users 레이어의 이름을 출력하는 기능
// 씬에서 레이어 객체를 체크, 그 이름을 출력
// 이걸 위한 컴포넌트?? 텍스트를 아래에 순서대로 만들어지게 하는법. 카드뒤집기 카드 만들듯이 생성위치 수식화

// 체크한 객체의 이름을 추출
// 배열에 넣음
// Text를 배열 길이만큼 동적생성
// Text가 배열[i]를 출력




// 대화 시스템
// 요구사항
// - 튜터에게 가까이 가면 대화 걸기 버튼이 생깁니다.
//튜터에게 멀어지면 다시 버튼이 사라집니다.
//- 버튼을 누른다면 대화가 시작됩니다.

// npc객체를 만든다
// npc엔 보이지 않는 원형 오브젝트가 있다.
// 이 범위에 플레이어 collider가 trigger하면 대화걸기 버튼ui가 팝업한다
// 대화걸기버튼을 누르면 하단에 대화창이 뜬다. ui로 표현, 글씨는 직접 넣지않고 변수로 건네주기. 다른클래스에 string 저장하기
// 