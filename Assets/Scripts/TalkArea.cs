using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TalkArea : MonoBehaviour
{
    // 엔피씨에게 말을 걸고 토크에리어의 충돌트리거를 담는다
    // 스크립트 캐싱은 엔피씨에게 함.
    // 

    [SerializeField] private GameObject talkArea;
    [SerializeField] private GameObject Player;

    [SerializeField] private GameObject TalkingToUI;
    [SerializeField] private GameObject TalkUI;


    private void Awake()
    {
        
    }
    private void Update()
    {
        if (GameManager.Instance.Player != null) return;
        else if (GameManager.Instance.Player == null && Player != null)
        {
            Player = GameManager.Instance.Player;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision) // collision은 충돌해오는 대상
    {
        if (collision.gameObject.layer == Player.layer)
        {

            TalkUI.SetActive(true);
        }

    }

    // 대화 시스템
    // 요구사항
    // - 튜터에게 가까이 가면 대화 걸기 버튼이 생깁니다.
    //튜터에게 멀어지면 다시 버튼이 사라집니다.
    //- 버튼을 누른다면 대화가 시작됩니다.

    // npc객체를 만든다
    // npc엔 보이지 않는 원형 오브젝트가 있다.
    // 이 범위에 플레이어 collider가 trigger하면 대화걸기 버튼ui가 팝업한다
    // 대화걸기버튼을 누르면 하단에 대화창이 뜬다. ui로 표현, 글씨는 직접 넣지않고 변수로 건네주기. 다른클래스에 string 저장하기
    // 대화 ui관련 스크립트는 따로 만들기


    // 






}
