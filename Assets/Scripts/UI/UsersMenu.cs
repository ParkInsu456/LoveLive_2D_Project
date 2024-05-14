using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UsersMenu : MonoBehaviour
{

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



    //배열을 만든다
    public GameObject textBox;
    public GameObject List;

    private List<string> userNames;
    // 찾는 레이어 이름
    public string layerName = "Users";
    public string layerName2 = "Player";

    public static event Action OnUsersMenuEvent;

    

    public static void CallUsersMenuEvent()
    {
        OnUsersMenuEvent?.Invoke();
    }
    private void OnEnable()
    {
        OnUsersMenuEvent += GetUsersName;
        OnUsersMenuEvent += MakeUserNameList;        
    }

    private void Start()
    {
        userNames = new List<string>();
        CallUsersMenuEvent();
    }
    private void GetUsersName()
    {
        // 해당 레이어의 모든 게임 객체를 찾음
        GameObject[] objs = GameObject.FindObjectsOfType<GameObject>();
        foreach (GameObject obj in objs)
        {
            if (obj.layer == LayerMask.NameToLayer(layerName) || obj.layer == LayerMask.NameToLayer(layerName2) && obj.transform.parent == null) 
            {
                PlayerInfo info = obj.GetComponent<PlayerInfo>();
                // 해당 레이어에 속한 객체의 이름을 리스트에 추가  
                userNames.Add(info.Name);    // TODO :: 이름 바꿔넣기
            }
        }
    }

    private void MakeUserNameList()
    {
        for (int i = 0; i < userNames.Count; i++)
        {
            GameObject userNameBox = Instantiate(textBox, List.transform);
            userNameBox.GetComponentInChildren<Text>().text = userNames[i];

            float x = List.transform.position.x;
            float y = List.transform.position.y + (-20f * i);

            userNameBox.transform.position = new Vector2(x, y);



        }
    }



















    public void ButtonExitMenu()
    {
        gameObject.SetActive(false);
    }










}


